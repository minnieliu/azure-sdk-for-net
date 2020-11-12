// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IotAlertsOperations.
    /// </summary>
    public static partial class IotAlertsOperationsExtensions
    {
            /// <summary>
            /// List IoT alerts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='solutionName'>
            /// The name of the IoT Security solution.
            /// </param>
            /// <param name='minStartTimeUtc'>
            /// Filter by minimum startTimeUtc (ISO 8601 format)
            /// </param>
            /// <param name='maxStartTimeUtc'>
            /// Filter by maximum startTimeUtc (ISO 8601 format)
            /// </param>
            /// <param name='alertType'>
            /// Filter by alert type
            /// </param>
            /// <param name='compromisedEntity'>
            /// Filter by compromised device
            /// </param>
            /// <param name='limit'>
            /// Limit the number of items returned in a single page
            /// </param>
            /// <param name='skipToken'>
            /// Skip token used for pagination
            /// </param>
            public static IPage<IotAlert> List(this IIotAlertsOperations operations, string resourceGroupName, string solutionName, string minStartTimeUtc = default(string), string maxStartTimeUtc = default(string), string alertType = default(string), string compromisedEntity = default(string), int? limit = default(int?), string skipToken = default(string))
            {
                return operations.ListAsync(resourceGroupName, solutionName, minStartTimeUtc, maxStartTimeUtc, alertType, compromisedEntity, limit, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List IoT alerts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='solutionName'>
            /// The name of the IoT Security solution.
            /// </param>
            /// <param name='minStartTimeUtc'>
            /// Filter by minimum startTimeUtc (ISO 8601 format)
            /// </param>
            /// <param name='maxStartTimeUtc'>
            /// Filter by maximum startTimeUtc (ISO 8601 format)
            /// </param>
            /// <param name='alertType'>
            /// Filter by alert type
            /// </param>
            /// <param name='compromisedEntity'>
            /// Filter by compromised device
            /// </param>
            /// <param name='limit'>
            /// Limit the number of items returned in a single page
            /// </param>
            /// <param name='skipToken'>
            /// Skip token used for pagination
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IotAlert>> ListAsync(this IIotAlertsOperations operations, string resourceGroupName, string solutionName, string minStartTimeUtc = default(string), string maxStartTimeUtc = default(string), string alertType = default(string), string compromisedEntity = default(string), int? limit = default(int?), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, solutionName, minStartTimeUtc, maxStartTimeUtc, alertType, compromisedEntity, limit, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get IoT alert
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='solutionName'>
            /// The name of the IoT Security solution.
            /// </param>
            /// <param name='iotAlertId'>
            /// Id of the alert
            /// </param>
            public static IotAlert Get(this IIotAlertsOperations operations, string resourceGroupName, string solutionName, string iotAlertId)
            {
                return operations.GetAsync(resourceGroupName, solutionName, iotAlertId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get IoT alert
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='solutionName'>
            /// The name of the IoT Security solution.
            /// </param>
            /// <param name='iotAlertId'>
            /// Id of the alert
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IotAlert> GetAsync(this IIotAlertsOperations operations, string resourceGroupName, string solutionName, string iotAlertId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, solutionName, iotAlertId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List IoT alerts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query: Subscription (i.e. /subscriptions/{subscriptionId}) or
            /// IoT Hub (i.e.
            /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Devices/iotHubs/{iotHubName})
            /// </param>
            /// <param name='minStartTimeUtc'>
            /// Filter by minimum startTimeUtc (ISO 8601 format)
            /// </param>
            /// <param name='maxStartTimeUtc'>
            /// Filter by maximum startTimeUtc (ISO 8601 format)
            /// </param>
            /// <param name='alertType'>
            /// Filter by alert type
            /// </param>
            /// <param name='deviceManagementType'>
            /// Get devices only from specific type, Managed or Unmanaged. Possible values
            /// include: 'Managed', 'Unmanaged'
            /// </param>
            /// <param name='compromisedEntity'>
            /// Filter by compromised device
            /// </param>
            /// <param name='limit'>
            /// Limit the number of items returned in a single page
            /// </param>
            /// <param name='skipToken'>
            /// Skip token used for pagination
            /// </param>
            public static IPage<IotAlertModel> List1(this IIotAlertsOperations operations, string scope, string minStartTimeUtc = default(string), string maxStartTimeUtc = default(string), string alertType = default(string), string deviceManagementType = default(string), string compromisedEntity = default(string), int? limit = default(int?), string skipToken = default(string))
            {
                return operations.List1Async(scope, minStartTimeUtc, maxStartTimeUtc, alertType, deviceManagementType, compromisedEntity, limit, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List IoT alerts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query: Subscription (i.e. /subscriptions/{subscriptionId}) or
            /// IoT Hub (i.e.
            /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Devices/iotHubs/{iotHubName})
            /// </param>
            /// <param name='minStartTimeUtc'>
            /// Filter by minimum startTimeUtc (ISO 8601 format)
            /// </param>
            /// <param name='maxStartTimeUtc'>
            /// Filter by maximum startTimeUtc (ISO 8601 format)
            /// </param>
            /// <param name='alertType'>
            /// Filter by alert type
            /// </param>
            /// <param name='deviceManagementType'>
            /// Get devices only from specific type, Managed or Unmanaged. Possible values
            /// include: 'Managed', 'Unmanaged'
            /// </param>
            /// <param name='compromisedEntity'>
            /// Filter by compromised device
            /// </param>
            /// <param name='limit'>
            /// Limit the number of items returned in a single page
            /// </param>
            /// <param name='skipToken'>
            /// Skip token used for pagination
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IotAlertModel>> List1Async(this IIotAlertsOperations operations, string scope, string minStartTimeUtc = default(string), string maxStartTimeUtc = default(string), string alertType = default(string), string deviceManagementType = default(string), string compromisedEntity = default(string), int? limit = default(int?), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.List1WithHttpMessagesAsync(scope, minStartTimeUtc, maxStartTimeUtc, alertType, deviceManagementType, compromisedEntity, limit, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get IoT alert
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query: Subscription (i.e. /subscriptions/{subscriptionId}) or
            /// IoT Hub (i.e.
            /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Devices/iotHubs/{iotHubName})
            /// </param>
            /// <param name='iotAlertId'>
            /// Id of the alert
            /// </param>
            public static IotAlertModel Get1(this IIotAlertsOperations operations, string scope, string iotAlertId)
            {
                return operations.Get1Async(scope, iotAlertId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get IoT alert
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the query: Subscription (i.e. /subscriptions/{subscriptionId}) or
            /// IoT Hub (i.e.
            /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Devices/iotHubs/{iotHubName})
            /// </param>
            /// <param name='iotAlertId'>
            /// Id of the alert
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IotAlertModel> Get1Async(this IIotAlertsOperations operations, string scope, string iotAlertId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Get1WithHttpMessagesAsync(scope, iotAlertId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List IoT alerts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IotAlert> ListNext(this IIotAlertsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List IoT alerts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IotAlert>> ListNextAsync(this IIotAlertsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List IoT alerts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IotAlertModel> List1Next(this IIotAlertsOperations operations, string nextPageLink)
            {
                return operations.List1NextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List IoT alerts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IotAlertModel>> List1NextAsync(this IIotAlertsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.List1NextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}