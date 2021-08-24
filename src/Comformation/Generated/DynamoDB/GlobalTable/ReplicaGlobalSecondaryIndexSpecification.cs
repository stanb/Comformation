using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.GlobalTable
{
    /// <summary>
    /// AWS::DynamoDB::GlobalTable ReplicaGlobalSecondaryIndexSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaglobalsecondaryindexspecification.html
    /// </summary>
    public class ReplicaGlobalSecondaryIndexSpecification
    {

        /// <summary>
        /// IndexName
        /// The name of the global secondary index. The name must be unique among all other indexes on this
        /// table.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("IndexName")]
        public Union<string, IntrinsicFunction> IndexName { get; set; }

        /// <summary>
        /// ContributorInsightsSpecification
        /// Updates the status for contributor insights for a specific table or index.
        /// Required: No
        /// Type: ContributorInsightsSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContributorInsightsSpecification")]
        public ContributorInsightsSpecification ContributorInsightsSpecification { get; set; }

        /// <summary>
        /// ReadProvisionedThroughputSettings
        /// Allows you to specify the read capacity settings for a replica global secondary index when the
        /// BillingMode is set to PROVISIONED.
        /// Required: No
        /// Type: ReadProvisionedThroughputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReadProvisionedThroughputSettings")]
        public ReadProvisionedThroughputSettings ReadProvisionedThroughputSettings { get; set; }

    }
}
