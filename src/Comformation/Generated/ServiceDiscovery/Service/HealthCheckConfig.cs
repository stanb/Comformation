using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceDiscovery.Service
{
    /// <summary>
    /// AWS::ServiceDiscovery::Service HealthCheckConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-healthcheckconfig.html
    /// </summary>
    public class HealthCheckConfig
    {

        /// <summary>
        /// Type
        /// The type of health check that you want to create, which indicates how Route&#160;53 determines whether an
        /// endpoint is healthy.
        /// Important You can&#39;t change the value of Type after you create a health check.
        /// You can create the following types of health checks:
        /// HTTP: Route&#160;53 tries to establish a TCP connection. If successful, Route&#160;53 submits an HTTP request
        /// and waits for an HTTP status code of 200 or greater and less than 400. HTTPS: Route&#160;53 tries to
        /// establish a TCP connection. If successful, Route&#160;53 submits an HTTPS request and waits for an HTTP
        /// status code of 200 or greater and less than 400. Important If you specify HTTPS for the value of
        /// Type, the endpoint must support TLS v1. 0 or later. TCP: Route&#160;53 tries to establish a TCP
        /// connection. If you specify TCP for Type, don&#39;t specify a value for ResourcePath.
        /// For more information, see How Route&#160;53 Determines Whether an Endpoint Is Healthy in the Route&#160;53
        /// Developer Guide.
        /// Required: Yes
        /// Type: String
        /// Allowed values: HTTP | HTTPS | TCP
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// ResourcePath
        /// The path that you want Route&#160;53 to request when performing health checks. The path can be any value
        /// for which your endpoint will return an HTTP status code of 2xx or 3xx when the endpoint is healthy,
        /// such as the file /docs/route53-health-check. html. Route&#160;53 automatically adds the DNS name for the
        /// service. If you don&#39;t specify a value for ResourcePath, the default value is /.
        /// If you specify TCP for Type, you must not specify a value for ResourcePath.
        /// Required: No
        /// Type: String
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourcePath")]
        public Union<string, IntrinsicFunction> ResourcePath { get; set; }

        /// <summary>
        /// FailureThreshold
        /// The number of consecutive health checks that an endpoint must pass or fail for Route&#160;53 to change
        /// the current status of the endpoint from unhealthy to healthy or vice versa. For more information,
        /// see How Route&#160;53 Determines Whether an Endpoint Is Healthy in the Route&#160;53 Developer Guide.
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
