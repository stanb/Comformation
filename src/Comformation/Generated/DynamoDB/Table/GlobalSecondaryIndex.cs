using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// Amazon DynamoDB Table GlobalSecondaryIndex
    /// Describes global secondary indexes for the AWS::DynamoDB::Table resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-gsi.html
    /// </summary>
    public class GlobalSecondaryIndex
    {

        /// <summary>
        /// IndexName
        /// The name of the global secondary index. The index name can be 3 – 255 characters long and must
        /// satisfy the regular expression pattern [a-zA-Z0-9_. -]+.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("IndexName")]
        public Union<string, IntrinsicFunction> IndexName { get; set; }

        /// <summary>
        /// KeySchema
        /// The complete index key schema for the global secondary index, which consists of one or more pairs of
        /// attribute names and key types.
        /// Required: Yes
        /// Type: List of DynamoDB Table KeySchema
        /// </summary>
        [JsonProperty("KeySchema")]
        public Union<List<KeySchema>, IntrinsicFunction> KeySchema { get; set; }

        /// <summary>
        /// Projection
        /// Attributes that are copied (projected) from the source table into the index. These attributes are in
        /// addition to the primary key attributes and index key attributes, which are automatically projected.
        /// Required: Yes
        /// Type: DynamoDB Table Projection
        /// </summary>
        [JsonProperty("Projection")]
        public Union<Projection, IntrinsicFunction> Projection { get; set; }

        /// <summary>
        /// ProvisionedThroughput
        /// The provisioned throughput settings for the index.
        /// Required: Yes
        /// Type: DynamoDB Table ProvisionedThroughput
        /// </summary>
        [JsonProperty("ProvisionedThroughput")]
        public Union<ProvisionedThroughput, IntrinsicFunction> ProvisionedThroughput { get; set; }

    }
}
