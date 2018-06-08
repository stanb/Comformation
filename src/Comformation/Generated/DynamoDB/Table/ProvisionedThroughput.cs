using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// Amazon DynamoDB Table ProvisionedThroughput
    /// Describes a set of provisioned throughput values for an AWS::DynamoDB::Table resource. DynamoDB uses these
    /// capacity units to allocate sufficient resources to provide the requested throughput.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-provisionedthroughput.html
    /// </summary>
    public class ProvisionedThroughput
    {

        /// <summary>
        /// ReadCapacityUnits
        /// Sets the desired minimum number of consistent reads of items (up to 1KB in size) per second for the
        /// specified table before Amazon DynamoDB balances the load.
        /// Required: Yes
        /// Type: Number
        /// </summary>
        [JsonProperty("ReadCapacityUnits")]
        public Union<long, IntrinsicFunction> ReadCapacityUnits { get; set; }

        /// <summary>
        /// WriteCapacityUnits
        /// Sets the desired minimum number of consistent writes of items (up to 1KB in size) per second for the
        /// specified table before Amazon DynamoDB balances the load.
        /// Required: Yes
        /// Type: Number
        /// </summary>
        [JsonProperty("WriteCapacityUnits")]
        public Union<long, IntrinsicFunction> WriteCapacityUnits { get; set; }

    }
}
