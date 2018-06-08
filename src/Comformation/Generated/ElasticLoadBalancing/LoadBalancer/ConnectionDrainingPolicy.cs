using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// Elastic Load Balancing ConnectionDrainingPolicy
    /// The ConnectionDrainingPolicy property describes how deregistered or unhealthy instances handle in-flight
    /// requests for the AWS::ElasticLoadBalancing::LoadBalancer resource. Connection draining ensures that the load
    /// balancer completes serving all in-flight requests made to a registered instance when the instance is
    /// deregistered or becomes unhealthy. Without connection draining, the load balancer closes connections to
    /// deregistered or unhealthy instances, and any in-flight requests are not completed.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-connectiondrainingpolicy.html
    /// </summary>
    public class ConnectionDrainingPolicy
    {

        /// <summary>
        /// Enabled
        /// Whether or not connection draining is enabled for the load balancer.
        /// Required: Yes
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// Timeout
        /// The time in seconds after the load balancer closes all connections to a deregistered or unhealthy
        /// instance.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("Timeout")]
        public Union<int, IntrinsicFunction> Timeout { get; set; }

    }
}
