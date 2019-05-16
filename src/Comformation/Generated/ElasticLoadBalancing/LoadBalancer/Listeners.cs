using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// AWS::ElasticLoadBalancing::LoadBalancer Listeners
    /// Specifies a listener for your Classic Load Balancer.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-listener.html
    /// </summary>
    public class Listeners
    {

        /// <summary>
        /// InstancePort
        /// The port on which the instance is listening.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstancePort")]
        public Union<string, IntrinsicFunction> InstancePort { get; set; }

        /// <summary>
        /// InstanceProtocol
        /// 	
        /// The protocol to use for routing traffic to instances: HTTP, HTTPS, TCP, or SSL.
        /// 	
        /// If the front-end protocol is HTTP, HTTPS, TCP, or SSL, InstanceProtocol must be at the same
        /// protocol.
        /// 	
        /// If there is another listener with the same InstancePort whose InstanceProtocol is secure, 	 (HTTPS
        /// or SSL), the listener&#39;s InstanceProtocol must also be secure.
        /// If there is another listener with the same InstancePort whose InstanceProtocol is HTTP or TCP, the
        /// listener&#39;s InstanceProtocol must be HTTP or TCP.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceProtocol")]
        public Union<string, IntrinsicFunction> InstanceProtocol { get; set; }

        /// <summary>
        /// LoadBalancerPort
        /// The port on which the load balancer is listening. On EC2-VPC, you can specify any port from the
        /// range 1-65535. On EC2-Classic, you can specify any port from the following list: 25, 80, 443, 465,
        /// 587, 1024-65535.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoadBalancerPort")]
        public Union<string, IntrinsicFunction> LoadBalancerPort { get; set; }

        /// <summary>
        /// PolicyNames
        /// The names of the policies to associate with the listener.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyNames")]
        public List<Union<string, IntrinsicFunction>> PolicyNames { get; set; }

        /// <summary>
        /// Protocol
        /// The load balancer transport protocol to use for routing: HTTP, HTTPS, TCP, or SSL.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// SSLCertificateId
        /// The Amazon Resource Name (ARN) of the server certificate.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SSLCertificateId")]
        public Union<string, IntrinsicFunction> SSLCertificateId { get; set; }

    }
}
