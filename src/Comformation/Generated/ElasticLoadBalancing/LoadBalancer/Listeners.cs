using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// Elastic Load Balancing V1 Listener
    /// The Listener property is an embedded property of the AWS::ElasticLoadBalancing::LoadBalancer type. A listener
    /// is a process that checks for connection requests. It is configured with a protocol and a port for front-end
    /// (client to load balancer) connections, and a protocol and a port for back-end (load balancer to back-end
    /// instance) connections. For more information, see Listeners for Your Classic Load Balancer in the User Guide
    /// for Classic Load Balancers.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-listener.html
    /// </summary>
    public class Listeners
    {

        /// <summary>
        /// InstancePort
        /// The TCP port on which the instance server listens. You can&#39;t modify this property during the life of
        /// the load balancer.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("InstancePort")]
        public Union<string, IntrinsicFunction> InstancePort { get; set; }

        /// <summary>
        /// InstanceProtocol
        /// The protocol to use for routing traffic to back-end instances: HTTP, HTTPS, TCP, or SSL. You can&#39;t
        /// modify this property during the life of the load balancer.
        /// If the front-end protocol is HTTP or HTTPS, InstanceProtocol must be on the same protocol layer
        /// (HTTP or HTTPS). Likewise, if the front-end protocol is TCP or SSL, InstanceProtocol must be TCP or
        /// SSL. By default, Elastic Load Balancing sets the instance protocol to HTTP or TCP. If there is
        /// another Listener with the same InstancePort whose InstanceProtocol is secure, (using HTTPS or SSL),
        /// the InstanceProtocol of the Listener must be secure (using HTTPS or SSL). If there is another
        /// Listener with the same InstancePort whose InstanceProtocol is HTTP or TCP, the InstanceProtocol of
        /// the Listener must be either HTTP or TCP.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("InstanceProtocol")]
        public Union<string, IntrinsicFunction> InstanceProtocol { get; set; }

        /// <summary>
        /// LoadBalancerPort
        /// The load balancer port number. You can&#39;t modify this property during the life of the load balancer.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("LoadBalancerPort")]
        public Union<string, IntrinsicFunction> LoadBalancerPort { get; set; }

        /// <summary>
        /// PolicyNames
        /// The ElasticLoadBalancing policies to associate with the Listener. Specify only policies that are
        /// compatible with a Listener. For more information, see DescribeLoadBalancerPolicyTypes in the Elastic
        /// Load Balancing API Reference version 2012-06-01.
        /// Note By default, Elastic Load Balancing associates the latest predefined policy with your load
        /// balancer. When a new predefined policy is added, we recommend that you update your load balancer to
        /// use the new predefined policy. Alternatively, you can select a different predefined security policy
        /// or create a custom policy. To create a security policy, use the Policies property of the
        /// AWS::ElasticLoadBalancing::LoadBalancer resource.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("PolicyNames")]
        public List<Union<string, IntrinsicFunction>> PolicyNames { get; set; }

        /// <summary>
        /// Protocol
        /// The load balancer transport protocol to use for routing: HTTP, HTTPS, TCP or SSL. You can&#39;t modify
        /// this property during the life of the load balancer.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// SSLCertificateId
        /// The ARN of the SSL certificate to use for HTTPS or SSL listeners. For more information, see SSL/TLS
        /// Certificates for Classic Load Balancers in the User Guide for Classic Load Balancers.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("SSLCertificateId")]
        public Union<string, IntrinsicFunction> SSLCertificateId { get; set; }

    }
}
