using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Fleet
{
    /// <summary>
    /// AWS::GameLift::Fleet LocationCapacity
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-locationcapacity.html
    /// </summary>
    public class LocationCapacity
    {

        /// <summary>
        /// DesiredEC2Instances
        /// The number of Amazon EC2 instances you want to maintain in the specified fleet location. This value
        /// must fall between the minimum and maximum size limits.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DesiredEC2Instances")]
        public Union<int, IntrinsicFunction> DesiredEC2Instances { get; set; }

        /// <summary>
        /// MinSize
        /// The minimum number of instances that are allowed in the specified fleet location. If this parameter
        /// is not set, the default is 0.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinSize")]
        public Union<int, IntrinsicFunction> MinSize { get; set; }

        /// <summary>
        /// MaxSize
        /// The maximum number of instances that are allowed in the specified fleet location. If this parameter
        /// is not set, the default is 1.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxSize")]
        public Union<int, IntrinsicFunction> MaxSize { get; set; }

    }
}
