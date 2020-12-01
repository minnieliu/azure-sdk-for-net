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

            var searchPhoneNumberOperation = await phoneNumberClient.StartSearchAvailablePhoneNumbersAsync(
                countryCode: "US",
                numberType: PhoneNumberType.Geographic,
                assignmentType: AssignmentType.Application,
                capabilities: new CapabilitiesRequest()
                {
                    Sms = CapabilityValue.Outbound,
                    Calling = CapabilityValue.InboundOutbound,
                },
                areaCode: "425",
                quantity: 2);
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
            var purchasePhoneNumberOperation = await phoneNumberClient.StartPurchasePhoneNumbersAsync(searchId);
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

            var updatePhoneNumberOperation = await phoneNumberClient.StartUpdatePhoneNumberAsync(
                "PHONE_NUMBER",
                callbackurl: "https://contoso.com/webhooks/phone",
                applicationId: "1dcb5bde-f5f5-4195-a1c1-43f157688769",
                capabilities: new CapabilitiesRequest() { Sms = CapabilityValue.InboundOutbound }
            );
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
