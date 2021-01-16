using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster CloudWatchLogs
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-cloudwatchlogs.html
    /// </summary>
    public class CloudWatchLogs
    {

        /// <summary>
        /// LogGroup
        /// The CloudWatch log group that is the destination for broker logs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogGroup")]
        public Union<string, IntrinsicFunction> LogGroup { get; set; }

        /// <summary>
        /// Enabled
        /// Specifies whether broker logs get sent to the specified CloudWatch Logs destination.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
