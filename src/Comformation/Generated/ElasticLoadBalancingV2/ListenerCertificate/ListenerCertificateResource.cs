using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerCertificate
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenercertificate.html
    /// </summary>
    public class ListenerCertificateResource : ResourceBase
    {
        public class ListenerCertificateProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenercertificate.html#cfn-elasticloadbalancingv2-listenercertificate-certificates
            /// </summary>
			public Union<List<Certificate>, IntrinsicFunction> Certificates { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenercertificate.html#cfn-elasticloadbalancingv2-listenercertificate-listenerarn
            /// </summary>
			public Union<string, IntrinsicFunction> ListenerArn { get; set; }

        }
    
        public string Type { get; } = "AWS::ElasticLoadBalancingV2::ListenerCertificate";
        
        public ListenerCertificateProperties Properties { get; } = new ListenerCertificateProperties();
    }
}
