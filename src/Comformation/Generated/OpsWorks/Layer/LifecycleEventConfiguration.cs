using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// AWS OpsWorks Layer LifeCycleConfiguration
    /// LifeCycleConfiguration is property of the AWS::OpsWorks::Layer resource that specifies the lifecycle event
    /// configuration for the layer.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-lifecycleeventconfiguration.html
    /// </summary>
    public class LifecycleEventConfiguration
    {

        /// <summary>
        /// ShutdownEventConfiguration
        /// Specifies the shutdown event configuration for a layer.
        /// Required: No
        /// Type: AWS OpsWorks Layer LifeCycleConfiguration ShutdownEventConfiguration
        /// </summary>
        [JsonProperty("ShutdownEventConfiguration")]
        public Union<ShutdownEventConfiguration, IntrinsicFunction> ShutdownEventConfiguration { get; set; }

    }
}
