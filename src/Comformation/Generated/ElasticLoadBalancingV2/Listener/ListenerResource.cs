using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.Listener
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::Listener
    /// The AWS::ElasticLoadBalancingV2::Listener resource creates a listener for an Application Load Balancer or a
    /// Network Load Balancer. The listener checks for connection requests and forwards them to one or more target
    /// groups. For more information, see Listeners for Your Application Load Balancers in the User Guide for
    /// Application Load Balancers or Listeners for Your Network Load Balancers in the User Guide for Network Load
    /// Balancers.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html
    /// </summary>
    public class ListenerResource : ResourceBase
    {
        public class ListenerProperties
        {
            /// <summary>
            /// Certificates
            /// [HTTPS and TLS listeners] The default SSL server certificate for the listener.
            /// Required: Conditional. If you specify HTTPS or TLS for the Protocol property, you must specify
            /// exactly one certificate.
            /// Type: List of Elastic Load Balancing V2 Certificate
            /// Update requires: No interruption
            /// </summary>
			public List<Certificate> Certificates { get; set; }

            /// <summary>
            /// DefaultActions
            /// The actions for the default rule for the listener.
            /// Required: Yes
            /// Type: List of Elastic Load Balancing V2 Action
            /// Update requires: No interruption
            /// </summary>
			public List<Action> DefaultActions { get; set; }

            /// <summary>
            /// LoadBalancerArn
            /// The Amazon Resource Name (ARN) of the load balancer.
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
            /// [HTTPS and TLS listeners] The security policy that defines the ciphers and protocols that the
            /// listener supports. The default is the current predefined security policy.
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
