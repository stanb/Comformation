using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.Listener
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::Listener
    /// Specifies a listener for an Application Load Balancer or Network Load Balancer.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html
    /// </summary>
    public class ListenerResource : ResourceBase
    {
        public class ListenerProperties
        {
            /// <summary>
            /// Certificates
            /// The default SSL server certificate. You must provide exactly one certificate if the listener
            /// protocol is HTTPS or TLS.
            /// Required: Conditional
            /// Type: List of Certificate
            /// Update requires: No interruption
            /// </summary>
			public List<Certificate> Certificates { get; set; }

            /// <summary>
            /// DefaultActions
            /// The actions for the default rule.
            /// Required: Yes
            /// Type: List of Action
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
            /// The port on which the load balancer is listening.
            /// Required: Yes
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 65535
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// Protocol
            /// The protocol for connections from clients to the load balancer. For Application Load Balancers, the
            /// supported protocols are HTTP and HTTPS. For Network Load Balancers, the supported protocols are TCP
            /// and TLS.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: HTTP | HTTPS | TCP | TLS
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Protocol { get; set; }

            /// <summary>
            /// SslPolicy
            /// [HTTPS and TLS listeners] The security policy that defines which ciphers and protocols are
            /// supported. The default is the current predefined security policy.
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
