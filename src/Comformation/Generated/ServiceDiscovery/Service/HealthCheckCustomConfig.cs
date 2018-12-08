using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Service
{
    /// <summary>
    /// AWS Cloud Map ServiceDiscovery Service HealthCheckCustomConfig
    /// The HealthCheckCustomConfig property type specifies information about an optional custom health check.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-healthcheckcustomconfig.html
    /// </summary>
    public class HealthCheckCustomConfig
    {

        /// <summary>
        /// FailureThreshold
        /// The number of 30-second intervals that you want service discovery to wait after receiving an
        /// UpdateInstanceCustomHealthStatus request before it changes the health status of a service instance.
        /// For example, suppose you specify a value of 2 for FailureTheshold , and then your application sends
        /// an UpdateInstanceCustomHealthStatus request. Service discovery waits for approximately 60 seconds (2
        /// x 30) before changing the status of the service instance based on that request.
        /// Sending a second or subsequent UpdateInstanceCustomHealthStatus request with the same value before
        /// FailureThreshold x 30 seconds has passed doesn&#39;t accelerate the change. Service discovery still
        /// waits FailureThreshold x 30 seconds after the first request to make the change.
        /// Minimum value of 1. Maximum value of 10.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FailureThreshold")]
        public Union<double, IntrinsicFunction> FailureThreshold { get; set; }

    }
}
