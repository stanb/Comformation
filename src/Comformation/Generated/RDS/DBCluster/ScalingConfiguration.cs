using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBCluster
{
    /// <summary>
    /// Amazon Relational Database Service DBCluster ScalingConfiguration
    /// The ScalingConfiguration property type specifies the scaling configuration of an Aurora Serverless DB cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbcluster-scalingconfiguration.html
    /// </summary>
    public class ScalingConfiguration
    {

        /// <summary>
        /// AutoPause
        /// A value that specifies whether to allow or disallow automatic pause for an Aurora DB cluster in
        /// serverless DB engine mode. A DB cluster can be paused only when it&#39;s idle (it has no connections).
        /// Note If a DB cluster is paused for more than seven days, the DB cluster might be backed up with a
        /// snapshot. In this case, the DB cluster is restored when there is a request to connect to it.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AutoPause")]
        public Union<bool, IntrinsicFunction> AutoPause { get; set; }

        /// <summary>
        /// MaxCapacity
        /// The maximum capacity for an Aurora DB cluster in serverless DB engine mode.
        /// Valid capacity values are 2, 4, 8, 16, 32, 64, 128, and 256.
        /// The maximum capacity must be greater than or equal to the minimum capacity.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxCapacity")]
        public Union<int, IntrinsicFunction> MaxCapacity { get; set; }

        /// <summary>
        /// MinCapacity
        /// The minimum capacity for an Aurora DB cluster in serverless DB engine mode.
        /// Valid capacity values are 2, 4, 8, 16, 32, 64, 128, and 256.
        /// The minimum capacity must be less than or equal to the maximum capacity.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinCapacity")]
        public Union<int, IntrinsicFunction> MinCapacity { get; set; }

        /// <summary>
        /// SecondsUntilAutoPause
        /// The time, in seconds, before an Aurora DB cluster in serverless mode is paused.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecondsUntilAutoPause")]
        public Union<int, IntrinsicFunction> SecondsUntilAutoPause { get; set; }

    }
}
