using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerCertificate
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerCertificate
    /// Specifies a certificate list for an HTTPS listener.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenercertificate.html
    /// </summary>
    public class ListenerCertificateResource : ResourceBase
    {
        public class ListenerCertificateProperties
        {
            /// <summary>
            /// Certificates
            /// The certificates to add. Duplicates are not allowed.
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
