using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// AWS::DynamoDB::Table ProvisionedThroughput
    /// Throughput for the specified table, which consists of values for ReadCapacityUnits and WriteCapacityUnits. For
    /// more information about the contents of a provisioned throughput structure, see Amazon DynamoDB Table
    /// ProvisionedThroughput.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-provisionedthroughput.html
    /// </summary>
    public class ProvisionedThroughput
    {

        /// <summary>
        /// ReadCapacityUnits
        /// The maximum number of strongly consistent reads consumed per second before DynamoDB returns a
        /// ThrottlingException. For more information, see Specifying Read and Write Requirements in the Amazon
        /// DynamoDB Developer Guide.
        /// If read/write capacity mode is PAY_PER_REQUEST the value is set to 0.
        /// Required: Yes
        /// Type: Long
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReadCapacityUnits")]
        public Union<long, IntrinsicFunction> ReadCapacityUnits { get; set; }

        /// <summary>
        /// WriteCapacityUnits
        /// The maximum number of writes consumed per second before DynamoDB returns a ThrottlingException. For
        /// more information, see Specifying Read and Write Requirements in the Amazon DynamoDB Developer Guide.
        /// If read/write capacity mode is PAY_PER_REQUEST the value is set to 0.
        /// Required: Yes
        /// Type: Long
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WriteCapacityUnits")]
        public Union<long, IntrinsicFunction> WriteCapacityUnits { get; set; }

    }
}
