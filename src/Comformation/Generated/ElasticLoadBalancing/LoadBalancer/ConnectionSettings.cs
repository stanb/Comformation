using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// Elastic Load Balancing ConnectionSettings
    /// ConnectionSettings is a property of the AWS::ElasticLoadBalancing::LoadBalancer resource that describes how
    /// long the front-end and back-end connections of your load balancer can remain idle. For more information, see
    /// Configure Idle Connection Timeout in the Elastic Load Balancing User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-connectionsettings.html
    /// </summary>
    public class ConnectionSettings
    {

        /// <summary>
        /// IdleTimeout
        /// The time (in seconds) that a connection to the load balancer can remain idle, which means no data is
        /// sent over the connection. After the specified time, the load balancer closes the connection.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public Union<int, IntrinsicFunction> IdleTimeout { get; set; }

    }
}
