using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Communication.Administration.Models;
using Azure.Communication.Chat;
using Azure.Communication.Identity;
using Azure.Core.TestFramework;

namespace Azure.Communication.Administration.Tests.samples
{
    public partial class Sample1_Authentication
    {
        public async Task CreateCommunicationUserIssueToken()
        {
            string connectionString = "<connectionString>";

            CommunicationIdentityClient communicationIdentityClient = new CommunicationIdentityClient(connectionString);
            Response<CommunicationUser> communicationUser = await communicationIdentityClient.CreateUserAsync();
            CommunicationUserToken communicationUserToken = await communicationIdentityClient.IssueTokenAsync(
                communicationUser: communicationUser.Value,
                scopes: new[] { CommunicationTokenScope.Chat });

            Console.WriteLine("Communication User Id: " + communicationUser.Value.Id);
            Console.WriteLine("Communication User Issued Token Value: " + communicationUserToken.Token);
        }

        public async Task CreateChatClient()
        {
            string connectionString = "<connectionString>";

            CommunicationIdentityClient communicationIdentityClient = new CommunicationIdentityClient(connectionString);
            Response<CommunicationUser> communicationUser = await communicationIdentityClient.CreateUserAsync();
            CommunicationUserToken communicationUserToken = await communicationIdentityClient.IssueTokenAsync(
                communicationUser: communicationUser.Value,
                scopes: new[] { CommunicationTokenScope.Chat });

            string userToken = communicationUserToken.Token;
            string endpoint = "<endpoint>";

            ChatClient chatClient = new ChatClient(
                new Uri(endpoint),
                new CommunicationUserCredential(userToken));

            Console.WriteLine("Chat Client successfully instantiated");
        }

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
                    new ChatThreadMember(new CommunicationUser(communicationUserToken1.User.Id)) { DisplayName ="display name member 1"},
                    new ChatThreadMember(new CommunicationUser(communicationUserToken2.User.Id)) { DisplayName ="display name member 2"},
                    new ChatThreadMember(new CommunicationUser(communicationUserToken3.User.Id)) { DisplayName ="display name member 3"}
                });

            AsyncPageable<ChatThreadMember> allMembers = chatThreadClient.GetMembersAsync();
            await foreach (ChatThreadMember member in allMembers)
            {
                Console.WriteLine("Chat Member Id: " + member.User.Id);
            }
        }
    }
}
