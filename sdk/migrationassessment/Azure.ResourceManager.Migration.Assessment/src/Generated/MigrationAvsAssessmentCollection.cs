// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Migration.Assessment
{
    /// <summary>
    /// A class representing a collection of <see cref="MigrationAvsAssessmentResource"/> and their operations.
    /// Each <see cref="MigrationAvsAssessmentResource"/> in the collection will belong to the same instance of <see cref="MigrationAssessmentGroupResource"/>.
    /// To get a <see cref="MigrationAvsAssessmentCollection"/> instance call the GetMigrationAvsAssessments method from an instance of <see cref="MigrationAssessmentGroupResource"/>.
    /// </summary>
    public partial class MigrationAvsAssessmentCollection : ArmCollection, IEnumerable<MigrationAvsAssessmentResource>, IAsyncEnumerable<MigrationAvsAssessmentResource>
    {
        private readonly ClientDiagnostics _migrationAvsAssessmentAvsAssessmentsOperationsClientDiagnostics;
        private readonly AvsAssessmentsRestOperations _migrationAvsAssessmentAvsAssessmentsOperationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MigrationAvsAssessmentCollection"/> class for mocking. </summary>
        protected MigrationAvsAssessmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MigrationAvsAssessmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MigrationAvsAssessmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _migrationAvsAssessmentAvsAssessmentsOperationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Migration.Assessment", MigrationAvsAssessmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MigrationAvsAssessmentResource.ResourceType, out string migrationAvsAssessmentAvsAssessmentsOperationsApiVersion);
            _migrationAvsAssessmentAvsAssessmentsOperationsRestClient = new AvsAssessmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, migrationAvsAssessmentAvsAssessmentsOperationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MigrationAssessmentGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MigrationAssessmentGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a AvsAssessment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsAssessmentsOperations_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAvsAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="assessmentName"> AVS Assessment ARM name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MigrationAvsAssessmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string assessmentName, MigrationAvsAssessmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _migrationAvsAssessmentAvsAssessmentsOperationsClientDiagnostics.CreateScope("MigrationAvsAssessmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _migrationAvsAssessmentAvsAssessmentsOperationsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, assessmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AssessmentArmOperation<MigrationAvsAssessmentResource>(new MigrationAvsAssessmentOperationSource(Client), _migrationAvsAssessmentAvsAssessmentsOperationsClientDiagnostics, Pipeline, _migrationAvsAssessmentAvsAssessmentsOperationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, assessmentName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a AvsAssessment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsAssessmentsOperations_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAvsAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="assessmentName"> AVS Assessment ARM name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MigrationAvsAssessmentResource> CreateOrUpdate(WaitUntil waitUntil, string assessmentName, MigrationAvsAssessmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _migrationAvsAssessmentAvsAssessmentsOperationsClientDiagnostics.CreateScope("MigrationAvsAssessmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _migrationAvsAssessmentAvsAssessmentsOperationsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, assessmentName, data, cancellationToken);
                var operation = new AssessmentArmOperation<MigrationAvsAssessmentResource>(new MigrationAvsAssessmentOperationSource(Client), _migrationAvsAssessmentAvsAssessmentsOperationsClientDiagnostics, Pipeline, _migrationAvsAssessmentAvsAssessmentsOperationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, assessmentName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a AvsAssessment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsAssessmentsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAvsAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentName"> AVS Assessment ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentName"/> is null. </exception>
        public virtual async Task<Response<MigrationAvsAssessmentResource>> GetAsync(string assessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var scope = _migrationAvsAssessmentAvsAssessmentsOperationsClientDiagnostics.CreateScope("MigrationAvsAssessmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _migrationAvsAssessmentAvsAssessmentsOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, assessmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationAvsAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a AvsAssessment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsAssessmentsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAvsAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentName"> AVS Assessment ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentName"/> is null. </exception>
        public virtual Response<MigrationAvsAssessmentResource> Get(string assessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var scope = _migrationAvsAssessmentAvsAssessmentsOperationsClientDiagnostics.CreateScope("MigrationAvsAssessmentCollection.Get");
            scope.Start();
            try
            {
                var response = _migrationAvsAssessmentAvsAssessmentsOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, assessmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationAvsAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List AvsAssessment resources by Group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsAssessmentsOperations_ListByGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAvsAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MigrationAvsAssessmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MigrationAvsAssessmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _migrationAvsAssessmentAvsAssessmentsOperationsRestClient.CreateListByGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _migrationAvsAssessmentAvsAssessmentsOperationsRestClient.CreateListByGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MigrationAvsAssessmentResource(Client, MigrationAvsAssessmentData.DeserializeMigrationAvsAssessmentData(e)), _migrationAvsAssessmentAvsAssessmentsOperationsClientDiagnostics, Pipeline, "MigrationAvsAssessmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List AvsAssessment resources by Group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsAssessmentsOperations_ListByGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAvsAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MigrationAvsAssessmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MigrationAvsAssessmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _migrationAvsAssessmentAvsAssessmentsOperationsRestClient.CreateListByGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _migrationAvsAssessmentAvsAssessmentsOperationsRestClient.CreateListByGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MigrationAvsAssessmentResource(Client, MigrationAvsAssessmentData.DeserializeMigrationAvsAssessmentData(e)), _migrationAvsAssessmentAvsAssessmentsOperationsClientDiagnostics, Pipeline, "MigrationAvsAssessmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsAssessmentsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAvsAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentName"> AVS Assessment ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string assessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var scope = _migrationAvsAssessmentAvsAssessmentsOperationsClientDiagnostics.CreateScope("MigrationAvsAssessmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _migrationAvsAssessmentAvsAssessmentsOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, assessmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsAssessmentsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAvsAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentName"> AVS Assessment ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string assessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var scope = _migrationAvsAssessmentAvsAssessmentsOperationsClientDiagnostics.CreateScope("MigrationAvsAssessmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _migrationAvsAssessmentAvsAssessmentsOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, assessmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsAssessmentsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAvsAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentName"> AVS Assessment ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentName"/> is null. </exception>
        public virtual async Task<NullableResponse<MigrationAvsAssessmentResource>> GetIfExistsAsync(string assessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var scope = _migrationAvsAssessmentAvsAssessmentsOperationsClientDiagnostics.CreateScope("MigrationAvsAssessmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _migrationAvsAssessmentAvsAssessmentsOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, assessmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MigrationAvsAssessmentResource>(response.GetRawResponse());
                return Response.FromValue(new MigrationAvsAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/avsAssessments/{assessmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvsAssessmentsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAvsAssessmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assessmentName"> AVS Assessment ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentName"/> is null. </exception>
        public virtual NullableResponse<MigrationAvsAssessmentResource> GetIfExists(string assessmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var scope = _migrationAvsAssessmentAvsAssessmentsOperationsClientDiagnostics.CreateScope("MigrationAvsAssessmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _migrationAvsAssessmentAvsAssessmentsOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, assessmentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MigrationAvsAssessmentResource>(response.GetRawResponse());
                return Response.FromValue(new MigrationAvsAssessmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MigrationAvsAssessmentResource> IEnumerable<MigrationAvsAssessmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MigrationAvsAssessmentResource> IAsyncEnumerable<MigrationAvsAssessmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
