using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Service
{
    /// <summary>
    /// AWS::ServiceDiscovery::Service HealthCheckCustomConfig
    /// A complex type that contains information about an optional custom health check. A custom health check, which
    /// requires that you 			use a third-party health checker to evaluate the health of your resources, is useful in
    /// the following circumstances:
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-healthcheckcustomconfig.html
    /// </summary>
    public class HealthCheckCustomConfig
    {

        /// <summary>
        /// FailureThreshold
        /// 		
        /// The number of 30-second intervals that you want Cloud Map to wait after receiving an
        /// UpdateInstanceCustomHealthStatus request 			before it changes the health status of a service
        /// instance. For example, suppose you specify a value of 2 for FailureTheshold, 			and then your
        /// application sends an UpdateInstanceCustomHealthStatus request. Cloud Map waits for approximately 60
        /// seconds (2 x 30) 			before changing the status of the service instance based on that request.
        /// 		
        /// Sending a second or subsequent UpdateInstanceCustomHealthStatus request with the same value before
        /// 			FailureThreshold x 30 seconds has passed doesn&#39;t accelerate the change. Cloud Map still waits
        /// 			FailureThreshold x 30 seconds after the first request to make the change.
        /// 		 	
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
