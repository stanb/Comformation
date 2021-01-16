using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.Listener
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::Listener
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html
    /// </summary>
    public class ListenerResource : ResourceBase
    {
        public class ListenerProperties
        {
            /// <summary>
            /// SslPolicy
            /// [HTTPS and TLS listeners] The security policy that defines which protocols and ciphers are
            /// supported.
            /// For more information, see Security policies in the Application Load Balancers Guide and Security
            /// policies in the Network Load Balancers Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SslPolicy { get; set; }

            /// <summary>
            /// LoadBalancerArn
            /// The Amazon Resource Name (ARN) of the load balancer.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LoadBalancerArn { get; set; }

            /// <summary>
            /// DefaultActions
            /// The actions for the default rule. You cannot define a condition for a default rule.
            /// To create additional rules for an Application Load Balancer, use
            /// AWS::ElasticLoadBalancingV2::ListenerRule.
            /// Required: Yes
            /// Type: List of Action
            /// Update requires: No interruption
            /// </summary>
            public List<Action> DefaultActions { get; set; }

            /// <summary>
            /// Port
            /// The port on which the load balancer is listening. You cannot specify a port for a Gateway Load
            /// Balancer.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 65535
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Port { get; set; }

            /// <summary>
            /// Certificates
            /// The default SSL server certificate for a secure listener. You must provide exactly one certificate
            /// if the listener protocol is HTTPS or TLS.
            /// To create a certificate list for a secure listener, use
            /// AWS::ElasticLoadBalancingV2::ListenerCertificate.
            /// Required: Conditional
            /// Type: List of Certificate
            /// Update requires: No interruption
            /// </summary>
            public List<Certificate> Certificates { get; set; }

            /// <summary>
            /// Protocol
            /// The protocol for connections from clients to the load balancer. For Application Load Balancers, the
            /// supported protocols are HTTP and HTTPS. For Network Load Balancers, the supported protocols are TCP,
            /// TLS, UDP, and TCP_UDP. You can’t specify the UDP or TCP_UDP protocol if dual-stack mode is enabled.
            /// You cannot specify a protocol for a Gateway Load Balancer.
            /// Required: No
            /// Type: String
            /// Allowed values: GENEVE | HTTP | HTTPS | TCP | TCP_UDP | TLS | UDP
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Protocol { get; set; }

            /// <summary>
            /// AlpnPolicy
            /// [TLS listener] The name of the Application-Layer Protocol Negotiation (ALPN) policy.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AlpnPolicy { get; set; }

        }

        public string Type { get; } = "AWS::ElasticLoadBalancingV2::Listener";

        public ListenerProperties Properties { get; } = new ListenerProperties();

    }

    public static class ListenerAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ListenerArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ListenerArn");
    }
}
