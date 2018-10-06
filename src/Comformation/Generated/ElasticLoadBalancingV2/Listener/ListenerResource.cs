using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.Listener
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::Listener
    /// The AWS::ElasticLoadBalancingV2::Listener resource creates a listener for an Elastic Load Balancing
    /// Application or Network load balancer. The listener checks for connection requests and forwards them to one or
    /// more target groups. For more information, see Getting Started in the Elastic Load Balancing User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html
    /// </summary>
    public class ListenerResource : ResourceBase
    {
        public class ListenerProperties
        {
            /// <summary>
            /// Certificates
            /// The SSL server certificate for the listener. With a certificate, you can encrypt traffic between the
            /// load balancer and the clients that initiate HTTPS sessions, and traffic between the load balancer
            /// and your targets.
            /// This property represents the default certificate for the listener. You can specify only one
            /// certificate for the AWS::ElasticLoadBalancingV2::Listener resource.
            /// Required: Conditional. If you specify HTTPS for the Protocol property, specify a certificate.
            /// Type: List of Elastic Load Balancing Listener Certificate
            /// Update requires: No interruption
            /// </summary>
			public List<Certificate> Certificates { get; set; }

            /// <summary>
            /// DefaultActions
            /// The default actions that the listener takes when handling incoming requests.
            /// Required: Yes
            /// Type: List of Elastic Load Balancing Listener Action
            /// Update requires: No interruption
            /// </summary>
			public List<Action> DefaultActions { get; set; }

            /// <summary>
            /// LoadBalancerArn
            /// The Amazon Resource Name (ARN) of the load balancer to associate with the listener.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LoadBalancerArn { get; set; }

            /// <summary>
            /// Port
            /// The port on which the listener listens for requests.
            /// For valid values, see the Port parameter for the CreateListener action in the Elastic Load Balancing
            /// API Reference version 2015-12-01.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// Protocol
            /// The protocol that clients must use to send requests to the listener.
            /// For valid values, see the Protocol parameter for the CreateListener action in the Elastic Load
            /// Balancing API Reference version 2015-12-01.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Protocol { get; set; }

            /// <summary>
            /// SslPolicy
            /// The security policy that defines the ciphers and protocols that the load balancer supports.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SslPolicy { get; set; }

        }
    
        public string Type { get; } = "AWS::ElasticLoadBalancingV2::Listener";
        
        public ListenerProperties Properties { get; } = new ListenerProperties();

    }
}
