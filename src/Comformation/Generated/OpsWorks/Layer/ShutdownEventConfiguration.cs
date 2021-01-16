using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// AWS::OpsWorks::Layer ShutdownEventConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-lifecycleeventconfiguration-shutdowneventconfiguration.html
    /// </summary>
    public class ShutdownEventConfiguration
    {

        /// <summary>
        /// DelayUntilElbConnectionsDrained
        /// Whether to enable Elastic Load Balancing connection draining. For more information, see Connection
        /// Draining
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DelayUntilElbConnectionsDrained")]
        public Union<bool, IntrinsicFunction> DelayUntilElbConnectionsDrained { get; set; }

        /// <summary>
        /// ExecutionTimeout
        /// The time, in seconds, that AWS OpsWorks Stacks will wait after triggering a Shutdown event before
        /// shutting down an instance.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExecutionTimeout")]
        public Union<int, IntrinsicFunction> ExecutionTimeout { get; set; }

    }
}
