using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Service
{
    /// <summary>
    /// AWS::ServiceDiscovery::Service HealthCheckCustomConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-healthcheckcustomconfig.html
    /// </summary>
    public class HealthCheckCustomConfig
    {

        /// <summary>
        /// FailureThreshold
        /// Important This parameter is no longer supported and is always set to 1. AWS Cloud Map waits for
        /// approximately 30 seconds after receiving an UpdateInstanceCustomHealthStatus request before changing
        /// the status of the service instance.
        /// The number of 30-second intervals that you want AWS Cloud Map to wait after receiving an
        /// UpdateInstanceCustomHealthStatus request before it changes the health status of a service instance.
        /// Sending a second or subsequent UpdateInstanceCustomHealthStatus request with the same value before
        /// 30 seconds has passed doesn&#39;t accelerate the change. AWS Cloud Map still waits 30 seconds after the
        /// first request to make the change.
        /// Required: No
        /// Type: Double
        /// Minimum: 1
        /// Maximum: 10
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FailureThreshold")]
        public Union<double, IntrinsicFunction> FailureThreshold { get; set; }

    }
}
