using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Communication.Administration.Models;
using Azure.Communication.Chat;
using Azure.Communication.Identity;
using Azure.Core.TestFramework;

namespace Azure.Communication.Administration.Tests.samples
{
    public partial class Sample1_Authentication
    {
        private const string SampleToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJleHAiOjMyNTAzNjgwMDAwfQ.9i7FNNHHJT8cOzo-yrAUJyBSfJ-tPPk2emcHavOEpWc";

        public async Task CreateCommunicationUserIssueToken()
        {
            string connectionString = "CONNECTION_STRING";
            CommunicationIdentityClient communicationIdentityClient = new CommunicationIdentityClient(connectionString);

            Response<CommunicationUser> communicationUser = await communicationIdentityClient.CreateUserAsync();
            CommunicationUserToken communicationUserToken = await communicationIdentityClient.IssueTokenAsync(
                communicationUser: communicationUser.Value,
                scopes: new[] { CommunicationTokenScope.Chat });

            Console.WriteLine("Communication User Id: " + communicationUser.Value.Id);
            Console.WriteLine("Communication User Issued Token Value: " + communicationUserToken.Token);
        }

        public async Task CreateChatClientWithStringToken()
        {
            string connectionString = "CONNECTION_STRING";
            string endpoint = "ENDPOINT";

            CommunicationIdentityClient communicationIdentityClient = new CommunicationIdentityClient(connectionString);
            Response<CommunicationUser> communicationUser = await communicationIdentityClient.CreateUserAsync();
            CommunicationUserToken communicationUserToken = await communicationIdentityClient.IssueTokenAsync(
                communicationUser: communicationUser.Value,
                scopes: new[] { CommunicationTokenScope.Chat });

            string userToken = communicationUserToken.Token;

            ChatClient chatClient = new ChatClient(
                new Uri(endpoint),
                new CommunicationUserCredential(userToken));

            Console.WriteLine("Chat Client successfully instantiated");
        }

        public async Task CreateChatClientWithTokenFromCallbackProactiveRefreshing()
        {
            string endpoint = "ENDPOINT";

            using var userCredential = new CommunicationUserCredential(
               refreshProactively: true, // Indicates if the token should be proactively refreshed in the background or only on-demand
               tokenRefresher: cancellationToken => FetchTokenForUserFromMyServer("bob@contoso.com", cancellationToken),
               asyncTokenRefresher: cancellationToken => FetchTokenForUserFromMyServerAsync("bob@contoso.com", cancellationToken));
            await userCredential.GetTokenAsync();

            ChatClient chatClient = new ChatClient(
              new Uri(endpoint),
              userCredential);
        }

        private static string FetchTokenForUserFromMyServer(string userId, CancellationToken cancellationToken) => SampleToken;

        private static ValueTask<string> FetchTokenForUserFromMyServerAsync(string userId, CancellationToken cancellationToken) => new ValueTask<string>(SampleToken);

        public async Task ListChatParticipants()
        {
            string endpoint = "<endpoint>";
            string connectionString = "<connectionString>";
            CommunicationIdentityClient communicationIdentityClient = new CommunicationIdentityClient(connectionString);

            Response<CommunicationUser> threadMember1 = await communicationIdentityClient.CreateUserAsync();
            Response<CommunicationUser> threadMember2 = await communicationIdentityClient.CreateUserAsync();
            Response<CommunicationUser> threadMember3 = await communicationIdentityClient.CreateUserAsync();

            CommunicationUserToken communicationUserToken1 = await communicationIdentityClient.IssueTokenAsync(threadMember1.Value, new[] { CommunicationTokenScope.Chat });
            CommunicationUserToken communicationUserToken2 = await communicationIdentityClient.IssueTokenAsync(threadMember2.Value, new[] { CommunicationTokenScope.Chat });
            CommunicationUserToken communicationUserToken3 = await communicationIdentityClient.IssueTokenAsync(threadMember3.Value, new[] { CommunicationTokenScope.Chat });

            string threadCreatorUserToken = communicationUserToken1.Token;
            ChatClient chatClient = new ChatClient(
                new Uri(endpoint),
                new CommunicationUserCredential(threadCreatorUserToken));

            ChatThreadClient chatThreadClient = await chatClient.CreateChatThreadAsync(
                topic: "Hello world!",
                members: new[] {
                    new ChatThreadMember(communicationUserToken1.User) { DisplayName ="Bob"},
                    new ChatThreadMember(communicationUserToken2.User) { DisplayName ="Mary"},
                    new ChatThreadMember(communicationUserToken3.User) { DisplayName ="Sarah"}
                });

            AsyncPageable<ChatThreadMember> allMembers = chatThreadClient.GetMembersAsync();
            await foreach (ChatThreadMember member in allMembers)
            {
                Console.WriteLine("Chat Member Id: " + member.User.Id);
            }
        }
    }
}
