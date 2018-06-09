using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// ElasticLoadBalancing LoadBalancer HealthCheck
    /// The HealthCheck property configures health checks for the availability of your EC2 instances. For more
    /// information, see Configure Health Checks for Your Classic Load Balancer in the User Guide for Classic Load
    /// Balancers.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-health-check.html
    /// </summary>
    public class HealthCheck
    {

        /// <summary>
        /// HealthyThreshold
        /// Specifies the number of consecutive health probe successes required before moving the instance to
        /// the Healthy state.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("HealthyThreshold")]
        public Union<string, IntrinsicFunction> HealthyThreshold { get; set; }

        /// <summary>
        /// Interval
        /// Specifies the approximate interval, in seconds, between health checks of an individual instance.
        /// Valid values are 5 to 300. The default is 30.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Interval")]
        public Union<string, IntrinsicFunction> Interval { get; set; }

        /// <summary>
        /// Target
        /// Specifies the instance&#39;s protocol and port to check. The protocol can be TCP, HTTP, HTTPS, or SSL.
        /// The range of valid ports is 1 through 65535.
        /// Required: Yes
        /// Type: String
        /// Note For TCP and SSL, you specify a port pair. For example, you can specify TCP:5000 or SSL:5000.
        /// The health check attempts to open a TCP or SSL connection to the instance on the port that you
        /// specify. If the health check fails to connect within the configured timeout period, the instance is
        /// considered unhealthy. For HTTP or HTTPS, you specify a port and a path to ping (HTTP or
        /// HTTPS:port/PathToPing). For example, you can specify HTTP:80/weather/us/wa/seattle. In this case, an
        /// HTTP GET request is issued to the instance on the given port and path. If the health check receives
        /// any response other than 200 OK within the configured timeout period, the instance is considered
        /// unhealthy. The total length of the HTTP or HTTPS ping target cannot be more than 1024 16-bit Unicode
        /// characters.
        /// </summary>
        [JsonProperty("Target")]
        public Union<string, IntrinsicFunction> Target { get; set; }

        /// <summary>
        /// Timeout
        /// Specifies the amount of time, in seconds, during which no response means a failed health probe. This
        /// value must be less than the value for Interval.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Timeout")]
        public Union<string, IntrinsicFunction> Timeout { get; set; }

        /// <summary>
        /// UnhealthyThreshold
        /// Specifies the number of consecutive health probe failures required before moving the instance to the
        /// Unhealthy state.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("UnhealthyThreshold")]
        public Union<string, IntrinsicFunction> UnhealthyThreshold { get; set; }

    }
}
