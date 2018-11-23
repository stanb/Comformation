using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// ElasticLoadBalancing Listener
    /// The Listener property is an embedded property of the AWS::ElasticLoadBalancing::LoadBalancer type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-listener.html
    /// </summary>
    public class Listeners
    {

        /// <summary>
        /// InstancePort
        /// Specifies the TCP port on which the instance server listens. You can&#39;t modify this property during
        /// the life of the load balancer.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("InstancePort")]
        public Union<string, IntrinsicFunction> InstancePort { get; set; }

        /// <summary>
        /// InstanceProtocol
        /// Specifies the protocol to use for routing traffic to back-end instances: HTTP, HTTPS, TCP, or SSL.
        /// You can&#39;t modify this property during the life of the load balancer.
        /// Required: No
        /// Type: String
        /// Note If the front-end protocol is HTTP or HTTPS, InstanceProtocol must be on the same protocol layer
        /// (HTTP or HTTPS). Likewise, if the front-end protocol is TCP or SSL, InstanceProtocol must be TCP or
        /// SSL. By default, Elastic Load Balancing sets the instance protocol to HTTP or TCP. If there is
        /// another Listener with the same InstancePort whose InstanceProtocol is secure, (using HTTPS or SSL),
        /// the InstanceProtocol of the Listener must be secure (using HTTPS or SSL). If there is another
        /// Listener with the same InstancePort whose InstanceProtocol is HTTP or TCP, the InstanceProtocol of
        /// the Listener must be either HTTP or TCP.
        /// </summary>
        [JsonProperty("InstanceProtocol")]
        public Union<string, IntrinsicFunction> InstanceProtocol { get; set; }

        /// <summary>
        /// LoadBalancerPort
        /// Specifies the external load balancer port number. You can&#39;t modify this property during the life of
        /// the load balancer.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("LoadBalancerPort")]
        public Union<string, IntrinsicFunction> LoadBalancerPort { get; set; }

        /// <summary>
        /// PolicyNames
        /// A list of ElasticLoadBalancing policy names to associate with the Listener. Specify only policies
        /// that are compatible with a Listener. For more information, see DescribeLoadBalancerPolicyTypes in
        /// the Elastic Load Balancing API Reference version 2012-06-01.
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
        /// Specifies the load balancer transport protocol to use for routing: HTTP, HTTPS, TCP or SSL. You
        /// can&#39;t modify this property during the life of the load balancer.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// SSLCertificateId
        /// The ARN of the SSL certificate to use. For more information about SSL certificates, see Managing
        /// Server Certificates in the AWS Identity and Access Management User Guide.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("SSLCertificateId")]
        public Union<string, IntrinsicFunction> SSLCertificateId { get; set; }

    }
}
