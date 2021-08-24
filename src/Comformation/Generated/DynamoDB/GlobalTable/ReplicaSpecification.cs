using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.GlobalTable
{
    /// <summary>
    /// AWS::DynamoDB::GlobalTable ReplicaSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicaspecification.html
    /// </summary>
    public class ReplicaSpecification
    {

        /// <summary>
        /// Region
        /// The region in which this replica exists.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

        /// <summary>
        /// GlobalSecondaryIndexes
        /// Defines additional settings for the global secondary indexes of this replica.
        /// Required: No
        /// Type: List of ReplicaGlobalSecondaryIndexSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GlobalSecondaryIndexes")]
        public List<ReplicaGlobalSecondaryIndexSpecification> GlobalSecondaryIndexes { get; set; }

        /// <summary>
        /// ContributorInsightsSpecification
        /// The settings used to enable or disable CloudWatch Contributor Insights for the specified replica.
        /// When not specified, defaults to contributor insights disabled for the replica.
        /// Required: No
        /// Type: ContributorInsightsSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContributorInsightsSpecification")]
        public ContributorInsightsSpecification ContributorInsightsSpecification { get; set; }

        /// <summary>
        /// PointInTimeRecoverySpecification
        /// The settings used to enable point in time recovery. When not specified, defaults to point in time
        /// recovery disabled for the replica.
        /// Required: No
        /// Type: PointInTimeRecoverySpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PointInTimeRecoverySpecification")]
        public PointInTimeRecoverySpecification PointInTimeRecoverySpecification { get; set; }

        /// <summary>
        /// SSESpecification
        /// Allows you to specify a customer-managed key for the replica. When using customer-managed keys for
        /// server-side encryption, this property must have a value in all replicas.
        /// Required: No
        /// Type: ReplicaSSESpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SSESpecification")]
        public ReplicaSSESpecification SSESpecification { get; set; }

        /// <summary>
        /// Tags
        /// An array of key-value pairs to apply to this replica.
        /// For more information, see Tag.
        /// Required: No
        /// Type: List of Tag
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tags")]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// ReadProvisionedThroughputSettings
        /// Defines read capacity settings for the replica table.
        /// Required: No
        /// Type: ReadProvisionedThroughputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReadProvisionedThroughputSettings")]
        public ReadProvisionedThroughputSettings ReadProvisionedThroughputSettings { get; set; }

    }
}
