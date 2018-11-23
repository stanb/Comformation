using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerCertificate
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerCertificate
    /// The AWS::ElasticLoadBalancingV2::ListenerCertificate resource specifies certificates for an Elastic Load
    /// Balancing secure listener. For more information, see Getting Started in the Elastic Load Balancing User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenercertificate.html
    /// </summary>
    public class ListenerCertificateResource : ResourceBase
    {
        public class ListenerCertificateProperties
        {
            /// <summary>
            /// Certificates
            /// Certificates specified for the listener. Duplicates not allowed.
            /// Required: Yes
            /// Type: List of Certificate
            /// Update requires: Replacement
            /// </summary>
			public List<Certificate> Certificates { get; set; }

            /// <summary>
            /// ListenerArn
            /// The Amazon Resource Name (ARN) of the listener.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ListenerArn { get; set; }

        }

        public string Type { get; } = "AWS::ElasticLoadBalancingV2::ListenerCertificate";

        public ListenerCertificateProperties Properties { get; } = new ListenerCertificateProperties();

    }
}
