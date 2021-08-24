using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.GlobalTable
{
    /// <summary>
    /// AWS::DynamoDB::GlobalTable ReadProvisionedThroughputSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-readprovisionedthroughputsettings.html
    /// </summary>
    public class ReadProvisionedThroughputSettings
    {

        /// <summary>
        /// ReadCapacityUnits
        /// Specifies a fixed read capacity for the replica table or global secondary index.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReadCapacityUnits")]
        public Union<int, IntrinsicFunction> ReadCapacityUnits { get; set; }

        /// <summary>
        /// ReadCapacityAutoScalingSettings
        /// Specifies auto scaling settings for the replica table or global secondary index.
        /// Required: No
        /// Type: CapacityAutoScalingSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReadCapacityAutoScalingSettings")]
        public CapacityAutoScalingSettings ReadCapacityAutoScalingSettings { get; set; }

    }
}
