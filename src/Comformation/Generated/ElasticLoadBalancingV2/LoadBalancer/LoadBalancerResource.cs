using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.LoadBalancer
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::LoadBalancer
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html
    /// </summary>
    public class LoadBalancerResource : ResourceBase
    {
        public class LoadBalancerProperties
        {
            /// <summary>
            /// IpAddressType
            /// The IP address type. The possible values are ipv4 (for IPv4 addresses) and dualstack (for IPv4 and
            /// IPv6 addresses). Internal load balancers must use ipv4. You can’t specify dualstack for a load
            /// balancer with a UDP or TCP_UDP listener.
            /// Required: No
            /// Type: String
            /// Allowed values: dualstack | ipv4
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> IpAddressType { get; set; }

            /// <summary>
            /// LoadBalancerAttributes
            /// The load balancer attributes.
            /// Required: No
            /// Type: List of LoadBalancerAttribute
            /// Maximum: 20
            /// Update requires: No interruption
            /// </summary>
            public List<LoadBalancerAttribute> LoadBalancerAttributes { get; set; }

            /// <summary>
            /// Name
            /// The name of the load balancer. This name must be unique per region per account, can have a maximum
            /// of 32 characters, must contain only alphanumeric characters or hyphens, must not begin or end with a
            /// hyphen, and must not begin with &quot;internal-&quot;.
            /// If you don&#39;t specify a name, AWS CloudFormation generates a unique physical ID for the load
            /// balancer. If you specify a name, you cannot perform updates that require replacement of this
            /// resource, but you can perform other updates. To replace the resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Scheme
            /// The nodes of an Internet-facing load balancer have public IP addresses. The DNS name of an
            /// Internet-facing load balancer is publicly resolvable to the public IP addresses of the nodes.
            /// Therefore, Internet-facing load balancers can route requests from clients over the internet.
            /// The nodes of an internal load balancer have only private IP addresses. The DNS name of an internal
            /// load balancer is publicly resolvable to the private IP addresses of the nodes. Therefore, internal
            /// load balancers can route requests only from clients with access to the VPC for the load balancer.
            /// The default is an Internet-facing load balancer.
            /// You cannot specify a scheme for a Gateway Load Balancer.
            /// Required: No
            /// Type: String
            /// Allowed values: internal | internet-facing
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Scheme { get; set; }

            /// <summary>
            /// SecurityGroups
            /// [Application Load Balancers] The IDs of the security groups for the load balancer.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

            /// <summary>
            /// SubnetMappings
            /// The IDs of the public subnets. You can specify only one subnet per Availability Zone. You must
            /// specify either subnets or subnet mappings.
            /// [Application Load Balancers] You must specify subnets from at least two Availability Zones. You
            /// cannot specify Elastic IP addresses for your subnets.
            /// [Application Load Balancers on Outposts] You must specify one Outpost subnet.
            /// [Application Load Balancers on Local Zones] You can specify subnets from one or more Local Zones.
            /// [Network Load Balancers] You can specify subnets from one or more Availability Zones. You can
            /// specify one Elastic IP address per subnet if you need static IP addresses for your internet-facing
            /// load balancer. For internal load balancers, you can specify one private IP address per subnet from
            /// the IPv4 range of the subnet. For internet-facing load balancer, you can specify one IPv6 address
            /// per subnet.
            /// [Gateway Load Balancers] You can specify subnets from one or more Availability Zones. You cannot
            /// specify Elastic IP addresses for your subnets.
            /// Required: Conditional
            /// Type: List of SubnetMapping
            /// Update requires: No interruption
            /// </summary>
            public List<SubnetMapping> SubnetMappings { get; set; }

            /// <summary>
            /// Subnets
            /// The IDs of the subnets. You can specify only one subnet per Availability Zone. You must specify
            /// either subnets or subnet mappings.
            /// [Application Load Balancers] You must specify subnets from at least two Availability Zones. When you
            /// specify subnets for an existing Application Load Balancer, they replace the previously enabled
            /// subnets.
            /// [Network Load Balancers] You can specify subnets from one or more Availability Zones when you create
            /// the load balancer.
            /// Required: Conditional
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

            /// <summary>
            /// Tags
            /// The tags to assign to the load balancer.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Type
            /// The type of load balancer. The default is application.
            /// Required: No
            /// Type: String
            /// Allowed values: application | gateway | network
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

        }

        public string Type { get; } = "AWS::ElasticLoadBalancingV2::LoadBalancer";

        public LoadBalancerProperties Properties { get; } = new LoadBalancerProperties();

    }

    public static class LoadBalancerAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CanonicalHostedZoneID = new ResourceAttribute<Union<string, IntrinsicFunction>>("CanonicalHostedZoneID");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DNSName = new ResourceAttribute<Union<string, IntrinsicFunction>>("DNSName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LoadBalancerFullName = new ResourceAttribute<Union<string, IntrinsicFunction>>("LoadBalancerFullName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LoadBalancerName = new ResourceAttribute<Union<string, IntrinsicFunction>>("LoadBalancerName");
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> SecurityGroups = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("SecurityGroups");
    }
}
