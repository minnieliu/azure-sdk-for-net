using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Communication.Administration.Models;

namespace Azure.Communication.Administration.Tests.samples
{
    public partial class Sample1_PhoneNumberClient
    {
        public async Task SearchForPhoneNumbers()
        {
            string connectionString = "CONNECTION_STRING";
            PhoneNumberClient phoneNumberClient = new PhoneNumberClient(connectionString);

            CapabilitiesRequest capabilitiesRequest = new CapabilitiesRequest();
            capabilitiesRequest.Sms = CapabilityValue.Outbound;
            capabilitiesRequest.Calling = CapabilityValue.InboundOutbound;

            SearchRequest searchRequest = new SearchRequest(
                PhoneNumberType.Geographic,
                AssignmentType.Application,
                capabilitiesRequest,
                "425",
                2);

            var searchPhoneNumberOperation = await phoneNumberClient.StartSearchPhoneNumberAsync("US", searchRequest);
            await searchPhoneNumberOperation.WaitForCompletionAsync().ConfigureAwait(false);
            SearchResult searchResult = searchPhoneNumberOperation.Value;

            Console.WriteLine("SearchId: " + searchResult.Id);
            Console.WriteLine("Monthly Rate: " + searchResult.MonthlyRate.Value);
            Console.WriteLine("Expires by: " + searchResult.SearchExpiresBy.ToString());

            foreach (String phoneNumber in searchResult.PhoneNumbers)
            {
                Console.WriteLine("Available Phone Number: " + phoneNumber);
            }
        }

        public async Task PurchasePhoneNumbers()
        {
            string connectionString = "CONNECTION_STRING";
            PhoneNumberClient phoneNumberClient = new PhoneNumberClient(connectionString);

            string searchId = "SEARCH_ID";
            var purchasePhoneNumberOperation = await phoneNumberClient.StartPurchasePhoneNumberAsync(searchId);
            await purchasePhoneNumberOperation.WaitForCompletionAsync().ConfigureAwait(false);
            SearchResult searchResult = purchasePhoneNumberOperation.Value;

            Console.WriteLine("Purchase completed for the search:" + searchResult.Id);
            foreach (String phoneNumber in searchResult.PhoneNumbers)
            {
                Console.WriteLine("Purchased Phone Number: " + phoneNumber);
            }
        }

        public async Task UpdateAcquiredPhoneNumber()
        {
            string connectionString = "CONNECTION_STRING";
            PhoneNumberClient phoneNumberClient = new PhoneNumberClient(connectionString);

            string phoneNumber = "PHONE_NUMBER";

            CapabilitiesRequest capabilitiesRequest = new CapabilitiesRequest();
            capabilitiesRequest.Sms = CapabilityValue.InboundOutbound;

            AcquiredPhoneNumberUpdate acquiredPhoneNumberUpdate = new AcquiredPhoneNumberUpdate();
            acquiredPhoneNumberUpdate.ApplicationId = "1dcb5bde-f5f5-4195-a1c1-43f157688769";
            acquiredPhoneNumberUpdate.CallbackUrl = "https://contoso.com/webhooks/phone";
            acquiredPhoneNumberUpdate.Capabilities = capabilitiesRequest;

            var updatePhoneNumberOperation = await phoneNumberClient.StartUpdatePhoneNumberAsync(phoneNumber, acquiredPhoneNumberUpdate);
            await updatePhoneNumberOperation.WaitForCompletionAsync().ConfigureAwait(false);
            AcquiredPhoneNumber acquiredPhoneNumber = updatePhoneNumberOperation.Value;

            Console.WriteLine("Updated Application Id:" + acquiredPhoneNumber.ApplicationId.ToString());
            Console.WriteLine("Updated Callback Url:" + acquiredPhoneNumber.CallbackUrl.ToString());
            Console.WriteLine("Updated SMS:" + acquiredPhoneNumber.Capabilities.Sms.ToString());
        }

        public async Task ReleaseAcquiredPhoneNumber()
        {
            string connectionString = "CONNECTION_STRING";
            PhoneNumberClient phoneNumberClient = new PhoneNumberClient(connectionString);

            string phoneNumber = "PHONE_NUMBER";
            var releasePhoneNumberOperation = await phoneNumberClient.StartReleasePhoneNumberAsync(phoneNumber);
            await releasePhoneNumberOperation.WaitForCompletionAsync().ConfigureAwait(false);


            Console.WriteLine("Release succeeded for phone number: " + phoneNumber);

        }
        public void ListPhoneNumbers()
        {
            string connectionString = "CONNECTION_STRING";
            PhoneNumberClient phoneNumberClient = new PhoneNumberClient(connectionString);

            AcquiredPhoneNumber[] acquiredPhoneNumbers = phoneNumberClient.ListPhoneNumbers().ToArray();

            foreach (AcquiredPhoneNumber acquiredPhoneNumber in acquiredPhoneNumbers)
            {
                Console.WriteLine("Phone number: " + acquiredPhoneNumber.PhoneNumber);
                Console.WriteLine("Purchase date: " + acquiredPhoneNumber.PurchaseDate.ToString());
            }
        }
    }
}
