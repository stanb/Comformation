using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// AWS::ElasticLoadBalancing::LoadBalancer HealthCheck
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-health-check.html
    /// </summary>
    public class HealthCheck
    {

        /// <summary>
        /// HealthyThreshold
        /// The number of consecutive health checks successes required before moving the instance to the Healthy
        /// state.
        /// Required: Yes
        /// Type: String
        /// Minimum: 2
        /// Maximum: 10
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HealthyThreshold")]
        public Union<string, IntrinsicFunction> HealthyThreshold { get; set; }

        /// <summary>
        /// Interval
        /// The approximate interval, in seconds, between health checks of an individual instance.
        /// Required: Yes
        /// Type: String
        /// Minimum: 5
        /// Maximum: 300
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Interval")]
        public Union<string, IntrinsicFunction> Interval { get; set; }

        /// <summary>
        /// Target
        /// The instance being checked. The protocol is either TCP, HTTP, HTTPS, or SSL. The range of valid
        /// ports is one (1) through 65535.
        /// TCP is the default, specified as a TCP: port pair, for example &quot;TCP:5000&quot;. In this case, a health
        /// check simply attempts to open a TCP connection to the instance on the specified port. Failure to
        /// connect within the configured timeout is considered unhealthy.
        /// SSL is also specified as SSL: port pair, for example, SSL:5000.
        /// For HTTP/HTTPS, you must include a ping path in the string. HTTP is specified as a
        /// HTTP:port;/;PathToPing; grouping, for example &quot;HTTP:80/weather/us/wa/seattle&quot;. In this case, a HTTP
        /// GET request is issued to the instance on the given port and path. Any answer other than &quot;200 OK&quot;
        /// within the timeout period is considered unhealthy.
        /// The total length of the HTTP ping target must be 1024 16-bit Unicode characters or less.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Target")]
        public Union<string, IntrinsicFunction> Target { get; set; }

        /// <summary>
        /// Timeout
        /// The amount of time, in seconds, during which no response means a failed health check.
        /// This value must be less than the Interval value.
        /// Required: Yes
        /// Type: String
        /// Minimum: 2
        /// Maximum: 60
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Timeout")]
        public Union<string, IntrinsicFunction> Timeout { get; set; }

        /// <summary>
        /// UnhealthyThreshold
        /// The number of consecutive health check failures required before moving the instance to the Unhealthy
        /// state.
        /// Required: Yes
        /// Type: String
        /// Minimum: 2
        /// Maximum: 10
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UnhealthyThreshold")]
        public Union<string, IntrinsicFunction> UnhealthyThreshold { get; set; }

    }
}
