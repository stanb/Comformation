using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInsightsAnalysis
{
    /// <summary>
    /// AWS::EC2::NetworkInsightsAnalysis Explanation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-explanation.html
    /// </summary>
    public class Explanation
    {

        /// <summary>
        /// Acl
        /// The network ACL.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Acl")]
        public AnalysisComponent Acl { get; set; }

        /// <summary>
        /// AclRule
        /// The network ACL rule.
        /// Required: No
        /// Type: AnalysisAclRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AclRule")]
        public AnalysisAclRule AclRule { get; set; }

        /// <summary>
        /// Address
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Address")]
        public Union<string, IntrinsicFunction> Address { get; set; }

        /// <summary>
        /// Addresses
        /// The IPv4 addresses, in CIDR notation.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Addresses")]
        public List<Union<string, IntrinsicFunction>> Addresses { get; set; }

        /// <summary>
        /// AttachedTo
        /// The resource to which the component is attached.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttachedTo")]
        public AnalysisComponent AttachedTo { get; set; }

        /// <summary>
        /// AvailabilityZones
        /// The Availability Zones.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailabilityZones")]
        public List<Union<string, IntrinsicFunction>> AvailabilityZones { get; set; }

        /// <summary>
        /// Cidrs
        /// The CIDR ranges.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Cidrs")]
        public List<Union<string, IntrinsicFunction>> Cidrs { get; set; }

        /// <summary>
        /// Component
        /// The component.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Component")]
        public AnalysisComponent Component { get; set; }

        /// <summary>
        /// CustomerGateway
        /// The customer gateway.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomerGateway")]
        public AnalysisComponent CustomerGateway { get; set; }

        /// <summary>
        /// Destination
        /// The destination.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public AnalysisComponent Destination { get; set; }

        /// <summary>
        /// DestinationVpc
        /// The destination VPC.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationVpc")]
        public AnalysisComponent DestinationVpc { get; set; }

        /// <summary>
        /// Direction
        /// The direction. The following are possible values:
        /// egress ingress
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Direction")]
        public Union<string, IntrinsicFunction> Direction { get; set; }

        /// <summary>
        /// ExplanationCode
        /// The explanation code.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExplanationCode")]
        public Union<string, IntrinsicFunction> ExplanationCode { get; set; }

        /// <summary>
        /// IngressRouteTable
        /// The route table.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IngressRouteTable")]
        public AnalysisComponent IngressRouteTable { get; set; }

        /// <summary>
        /// InternetGateway
        /// The internet gateway.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InternetGateway")]
        public AnalysisComponent InternetGateway { get; set; }

        /// <summary>
        /// LoadBalancerArn
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1283
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoadBalancerArn")]
        public Union<string, IntrinsicFunction> LoadBalancerArn { get; set; }

        /// <summary>
        /// ClassicLoadBalancerListener
        /// The listener for a Classic Load Balancer.
        /// Required: No
        /// Type: AnalysisLoadBalancerListener
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClassicLoadBalancerListener")]
        public AnalysisLoadBalancerListener ClassicLoadBalancerListener { get; set; }

        /// <summary>
        /// LoadBalancerListenerPort
        /// The listener port of the load balancer.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoadBalancerListenerPort")]
        public Union<int, IntrinsicFunction> LoadBalancerListenerPort { get; set; }

        /// <summary>
        /// LoadBalancerTarget
        /// The target.
        /// Required: No
        /// Type: AnalysisLoadBalancerTarget
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoadBalancerTarget")]
        public AnalysisLoadBalancerTarget LoadBalancerTarget { get; set; }

        /// <summary>
        /// LoadBalancerTargetGroup
        /// The target group.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoadBalancerTargetGroup")]
        public AnalysisComponent LoadBalancerTargetGroup { get; set; }

        /// <summary>
        /// LoadBalancerTargetGroups
        /// The target groups.
        /// Required: No
        /// Type: List of AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoadBalancerTargetGroups")]
        public List<AnalysisComponent> LoadBalancerTargetGroups { get; set; }

        /// <summary>
        /// LoadBalancerTargetPort
        /// The target port.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoadBalancerTargetPort")]
        public Union<int, IntrinsicFunction> LoadBalancerTargetPort { get; set; }

        /// <summary>
        /// ElasticLoadBalancerListener
        /// The load balancer listener.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ElasticLoadBalancerListener")]
        public AnalysisComponent ElasticLoadBalancerListener { get; set; }

        /// <summary>
        /// MissingComponent
        /// The missing component.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MissingComponent")]
        public Union<string, IntrinsicFunction> MissingComponent { get; set; }

        /// <summary>
        /// NatGateway
        /// The NAT gateway.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NatGateway")]
        public AnalysisComponent NatGateway { get; set; }

        /// <summary>
        /// NetworkInterface
        /// The network interface.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkInterface")]
        public AnalysisComponent NetworkInterface { get; set; }

        /// <summary>
        /// PacketField
        /// The packet field.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PacketField")]
        public Union<string, IntrinsicFunction> PacketField { get; set; }

        /// <summary>
        /// VpcPeeringConnection
        /// The VPC peering connection.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcPeeringConnection")]
        public AnalysisComponent VpcPeeringConnection { get; set; }

        /// <summary>
        /// Port
        /// The port.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// PortRanges
        /// The port ranges.
        /// Required: No
        /// Type: List of PortRange
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PortRanges")]
        public List<PortRange> PortRanges { get; set; }

        /// <summary>
        /// PrefixList
        /// The prefix list.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrefixList")]
        public AnalysisComponent PrefixList { get; set; }

        /// <summary>
        /// Protocols
        /// The protocols.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocols")]
        public List<Union<string, IntrinsicFunction>> Protocols { get; set; }

        /// <summary>
        /// RouteTableRoute
        /// The route table route.
        /// Required: No
        /// Type: AnalysisRouteTableRoute
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RouteTableRoute")]
        public AnalysisRouteTableRoute RouteTableRoute { get; set; }

        /// <summary>
        /// RouteTable
        /// The route table.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RouteTable")]
        public AnalysisComponent RouteTable { get; set; }

        /// <summary>
        /// SecurityGroup
        /// The security group.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public AnalysisComponent SecurityGroup { get; set; }

        /// <summary>
        /// SecurityGroupRule
        /// The security group rule.
        /// Required: No
        /// Type: AnalysisSecurityGroupRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupRule")]
        public AnalysisSecurityGroupRule SecurityGroupRule { get; set; }

        /// <summary>
        /// SecurityGroups
        /// The security groups.
        /// Required: No
        /// Type: List of AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public List<AnalysisComponent> SecurityGroups { get; set; }

        /// <summary>
        /// SourceVpc
        /// The source VPC.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceVpc")]
        public AnalysisComponent SourceVpc { get; set; }

        /// <summary>
        /// State
        /// The state.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("State")]
        public Union<string, IntrinsicFunction> State { get; set; }

        /// <summary>
        /// Subnet
        /// The subnet.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Subnet")]
        public AnalysisComponent Subnet { get; set; }

        /// <summary>
        /// SubnetRouteTable
        /// The route table for the subnet.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetRouteTable")]
        public AnalysisComponent SubnetRouteTable { get; set; }

        /// <summary>
        /// Vpc
        /// The component VPC.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Vpc")]
        public AnalysisComponent Vpc { get; set; }

        /// <summary>
        /// vpcEndpoint
        /// The VPC endpoint.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("vpcEndpoint")]
        public AnalysisComponent vpcEndpoint { get; set; }

        /// <summary>
        /// VpnConnection
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpnConnection")]
        public AnalysisComponent VpnConnection { get; set; }

        /// <summary>
        /// VpnGateway
        /// The VPN gateway.
        /// Required: No
        /// Type: AnalysisComponent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpnGateway")]
        public AnalysisComponent VpnGateway { get; set; }

    }
}
