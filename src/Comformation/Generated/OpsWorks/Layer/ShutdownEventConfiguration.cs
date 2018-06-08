using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// AWS OpsWorks Layer LifeCycleConfiguration ShutdownEventConfiguration
    /// ShutdownEventConfiguration is a property of the AWS OpsWorks Layer LifeCycleConfiguration property that
    /// specifies the shutdown event configuration for a lifecycle event.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-lifecycleeventconfiguration-shutdowneventconfiguration.html
    /// </summary>
    public class ShutdownEventConfiguration
    {

        /// <summary>
        /// DelayUntilElbConnectionsDrained
        /// Indicates whether to wait for connections to drain from the Elastic Load Balancing load balancers.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("DelayUntilElbConnectionsDrained")]
        public Union<bool, IntrinsicFunction> DelayUntilElbConnectionsDrained { get; set; }

        /// <summary>
        /// ExecutionTimeout
        /// The time, in seconds, that AWS OpsWorks waits after a shutdown event has been triggered before
        /// shutting down an instance.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("ExecutionTimeout")]
        public Union<int, IntrinsicFunction> ExecutionTimeout { get; set; }

    }
}
