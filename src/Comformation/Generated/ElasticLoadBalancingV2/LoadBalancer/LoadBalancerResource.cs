using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.LoadBalancer
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::LoadBalancer
    /// The AWS::ElasticLoadBalancingV2::LoadBalancer resource creates an Elastic Load Balancing Application or
    /// Network Load Balancer. For more information, see Getting Started in the Elastic Load Balancing User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html
    /// </summary>
    public class LoadBalancerResource : ResourceBase
    {
        public class LoadBalancerProperties
        {
            /// <summary>
            /// IpAddressType
            /// [Application Load Balancers] The type of IP addresses that are used by the load balancer's subnets,
            /// such as ipv4 (for IPv4 addresses) or dualstack (for IPv4 and IPv6 addresses). For valid values, see
            /// the IpAddressType parameter for the CreateLoadBalancer action in the Elastic Load Balancing API
            /// Reference version 2015-12-01. The default value is ipv4.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// Note If Scheme is internal, then IpAddressType must be ipv4.
            /// </summary>
			public Union<string, IntrinsicFunction> IpAddressType { get; set; }

            /// <summary>
            /// LoadBalancerAttributes
            /// Specifies the load balancer configuration.
            /// Required: No
            /// Type: A list of Elastic Load Balancing LoadBalancer LoadBalancerAttributes
            /// Update requires: No interruption
            /// </summary>
			public Union<List<LoadBalancerAttribute>, IntrinsicFunction> LoadBalancerAttributes { get; set; }

            /// <summary>
            /// Name
            /// Specifies a name for the load balancer. This name must be unique within your AWS account and can
            /// have a maximum of 32 alphanumeric characters and hyphens. A name can't begin or end with a hyphen.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Scheme
            /// Specifies whether the load balancer is internal or Internet-facing. Valid values are internet-facing
            /// and internal. The default is internet-facing.
            /// The nodes of an Internet-facing load balancer have public IP addresses. The DNS name of an
            /// Internet-facing load balancer is publicly resolvable to the public IP addresses of the nodes.
            /// Therefore, Internet-facing load balancers can route requests from clients over the Internet.
            /// The nodes of an internal load balancer have only private IP addresses. The DNS name of an internal
            /// load balancer is publicly resolvable to the private IP addresses of the nodes. Therefore, internal
            /// load balancers can only route requests from clients with access to the VPC for the load balancer.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Scheme { get; set; }

            /// <summary>
            /// SecurityGroups
            /// [Application Load Balancers] Specifies a list of the IDs of the security groups to assign to the
            /// load balancer.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroups { get; set; }

            /// <summary>
            /// SubnetMappings
            /// The subnets to attach to the load balancer, specified as a list of SubnetMapping property types. You
            /// can specify only one subnet per Availability Zone. You must specify either subnets or subnet
            /// mappings.
            /// [Application Load Balancers] The load balancer is allocated one static IP address per subnet. You
            /// cannot specify your own Elastic IP addresses.
            /// [Network Load Balancers] You can specify one Elastic IP address per subnet.
            /// Required: No
            /// Type: List of Elastic Load Balancing LoadBalancer SubnetMapping
            /// Update requires: Replacement
            /// </summary>
			public Union<List<SubnetMapping>, IntrinsicFunction> SubnetMappings { get; set; }

            /// <summary>
            /// Subnets
            /// The subnets to attach to the load balancer, specified as a list of subnet IDs. You can specify only
            /// one subnet per Availability Zone. You must specify either subnets or subnet mappings.
            /// [Application Load Balancers] You must specify subnets from at least two Availability Zones.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Subnets { get; set; }

            /// <summary>
            /// Tags
            /// Specifies an arbitrary set of tags (key–value pairs) to associate with this load balancer. Use tags
            /// to manage your resources.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Type
            /// Specifies the type of load balancer to create. Valid values are application and network. The default
            /// is application.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
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
