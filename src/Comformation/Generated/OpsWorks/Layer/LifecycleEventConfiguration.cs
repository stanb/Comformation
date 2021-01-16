using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// AWS::OpsWorks::Layer LifecycleEventConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-lifecycleeventconfiguration.html
    /// </summary>
    public class LifecycleEventConfiguration
    {

        /// <summary>
        /// ShutdownEventConfiguration
        /// The Shutdown event configuration.
        /// Required: No
        /// Type: ShutdownEventConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ShutdownEventConfiguration")]
        public ShutdownEventConfiguration ShutdownEventConfiguration { get; set; }

    }
}
