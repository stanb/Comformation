using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Service
{
    /// <summary>
    /// AWS Cloud Map ServiceDiscovery HealthCheckConfig
    /// The 		HealthCheckConfig property type specifies settings for an optional Amazon Route&#160;53 health check. 		If
    /// you specify settings for a health check, AWS Cloud Map associates the health check with all the records 		that
    /// you specify in DnsConfig.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-healthcheckconfig.html
    /// </summary>
    public class HealthCheckConfig
    {

        /// <summary>
        /// Type
        /// 					
        /// The type of health check that you want to create, which indicates how Route&#160;53 determines whether an
        /// endpoint is healthy. 						Valid types include HTTP, HTTPS, and TCP.
        /// 					
        /// Required: Yes
        /// 					
        /// Type: String
        /// 					
        /// Update requires: No interruption
        /// 				
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// ResourcePath
        /// 					
        /// The path that you want Route&#160;53 to request when performing health checks. The path can be any value
        /// for which your endpoint 						will return an HTTP status code of 2xx or 3xx when the endpoint is
        /// healthy, such as the file 						/docs/route53-health-check. html. Route&#160;53 automatically adds the
        /// DNS name for the service and a 						leading forward slash (/) character.
        /// 					
        /// Required: No
        /// 					
        /// Type: String
        /// 					
        /// Update requires: No interruption
        /// 				
        /// </summary>
        [JsonProperty("ResourcePath")]
        public Union<string, IntrinsicFunction> ResourcePath { get; set; }

        /// <summary>
        /// FailureThreshold
        /// 					
        /// The number of consecutive health checks that an endpoint must pass or fail for Route&#160;53 to change
        /// the current status 						of the endpoint from unhealthy to healthy or vice versa. For more
        /// information, see 						How Route&#160;53 Determines Whether a Health Check Is Healthy 						in the Amazon
        /// Route&#160;53 Developer Guide
        /// 					
        /// Required: No
        /// 					
        /// Type: Double
        /// 					
        /// Update requires: No interruption
        /// 				
        /// </summary>
        [JsonProperty("FailureThreshold")]
        public Union<double, IntrinsicFunction> FailureThreshold { get; set; }

    }
}
