using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// AWS::ElasticLoadBalancing::LoadBalancer ConnectionSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-connectionsettings.html
    /// </summary>
    public class ConnectionSettings
    {

        /// <summary>
        /// IdleTimeout
        /// The time, in seconds, that the connection is allowed to be idle (no data has been sent over the
        /// connection) before it is closed by the load balancer.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 3600
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public Union<int, IntrinsicFunction> IdleTimeout { get; set; }

    }
}
