using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConnect.Flow
{
    /// <summary>
    /// AWS::MediaConnect::Flow FailoverConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-failoverconfig.html
    /// </summary>
    public class FailoverConfig
    {

        /// <summary>
        /// State
        /// The state of source failover on the flow. If the state is disabled, the flow can have only one
        /// source. If the state is enabled, the flow can have one or two sources.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("State")]
        public Union<string, IntrinsicFunction> State { get; set; }

        /// <summary>
        /// RecoveryWindow
        /// The size of the buffer (delay) that the service maintains. A larger buffer means a longer delay in
        /// transmitting the stream, but more room for error correction. A smaller buffer means a shorter delay,
        /// but less room for error correction.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RecoveryWindow")]
        public Union<int, IntrinsicFunction> RecoveryWindow { get; set; }

    }
}
