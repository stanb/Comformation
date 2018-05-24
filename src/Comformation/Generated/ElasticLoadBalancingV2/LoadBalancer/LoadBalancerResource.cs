using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.LoadBalancer
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html
    /// </summary>
    public class LoadBalancerResource : ResourceBase
    {
        public class LoadBalancerProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-ipaddresstype
            /// </summary>
			public Union<string, IntrinsicFunction> IpAddressType { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-loadbalancerattributes
            /// </summary>
			public Union<List<LoadBalancerAttribute>, IntrinsicFunction> LoadBalancerAttributes { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-scheme
            /// </summary>
			public Union<string, IntrinsicFunction> Scheme { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-securitygroups
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroups { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-subnetmappings
            /// </summary>
			public Union<List<SubnetMapping>, IntrinsicFunction> SubnetMappings { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-subnets
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Subnets { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-type
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

        }
    
        public string Type { get; } = "AWS::ElasticLoadBalancingV2::LoadBalancer";
        
        public LoadBalancerProperties Properties { get; } = new LoadBalancerProperties();
    }

	public static class LoadBalancerAttributes
	{
        public static readonly ResourceAttribute<string> CanonicalHostedZoneID = new ResourceAttribute<string>("CanonicalHostedZoneID");
        public static readonly ResourceAttribute<string> DNSName = new ResourceAttribute<string>("DNSName");
        public static readonly ResourceAttribute<string> LoadBalancerFullName = new ResourceAttribute<string>("LoadBalancerFullName");
        public static readonly ResourceAttribute<string> LoadBalancerName = new ResourceAttribute<string>("LoadBalancerName");
        public static readonly ResourceAttribute<List<string>> SecurityGroups = new ResourceAttribute<List<string>>("SecurityGroups");
	}
}
