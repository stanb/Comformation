using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.GlobalTable
{
    /// <summary>
    /// AWS::DynamoDB::GlobalTable WriteProvisionedThroughputSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-writeprovisionedthroughputsettings.html
    /// </summary>
    public class WriteProvisionedThroughputSettings
    {

        /// <summary>
        /// WriteCapacityAutoScalingSettings
        /// Specifies auto scaling settings for the replica table or global secondary index.
        /// Required: No
        /// Type: CapacityAutoScalingSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WriteCapacityAutoScalingSettings")]
        public CapacityAutoScalingSettings WriteCapacityAutoScalingSettings { get; set; }

    }
}
