using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HostedZone
{
    /// <summary>
    /// AWS::Route53::HostedZone
    /// The AWS::Route53::HostedZone resource creates a hosted zone, which can contain a collection of record sets for
    /// a domain. You cannot create a hosted zone for a top-level domain (TLD). For more information, see POST
    /// CreateHostedZone or POST CreateHostedZone (Private) in the Amazon Route 53 API Reference.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html
    /// </summary>
    public class HostedZoneResource : ResourceBase
    {
        public class HostedZoneProperties
        {
            /// <summary>
            /// HostedZoneConfig
            /// A complex type that contains an optional comment about your hosted zone.
            /// Required: No
            /// Type: Route 53 HostedZoneConfig Property
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-hostedzoneconfig
            /// </summary>
			public Union<HostedZoneConfig, IntrinsicFunction> HostedZoneConfig { get; set; }

            /// <summary>
            /// HostedZoneTags
            /// An arbitrary set of tags (key–value pairs) for this hosted zone.
            /// Required: No
            /// Type: List of Amazon Route 53 HostedZoneTags
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-hostedzonetags
            /// </summary>
			public Union<List<HostedZoneTag>, IntrinsicFunction> HostedZoneTags { get; set; }

            /// <summary>
            /// Name
            /// The name of the domain. For resource record types that include a domain name, specify a fully
            /// qualified domain name.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// QueryLoggingConfig
            /// The configuration for DNS query logging.
            /// Required: No
            /// Type: Route 53 QueryLoggingConfig
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-queryloggingconfig
            /// </summary>
			public Union<QueryLoggingConfig, IntrinsicFunction> QueryLoggingConfig { get; set; }

            /// <summary>
            /// VPCs
            /// One or more VPCs that you want to associate with this hosted zone. When you specify this property,
            /// AWS CloudFormation creates a private hosted zone.
            /// Required: No
            /// Type: List of Route 53 HostedZoneVPCs
            /// If this property was specified previously and you're modifying values, updates require no
            /// interruption. If this property wasn't specified and you add values, updates require replacement.
            /// Also, if this property was specified and you remove all values, updates require replacement.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html#cfn-route53-hostedzone-vpcs
            /// </summary>
			public Union<List<VPC>, IntrinsicFunction> VPCs { get; set; }

        }
    
        public string Type { get; } = "AWS::Route53::HostedZone";
        
        public HostedZoneProperties Properties { get; } = new HostedZoneProperties();
    }

	public static class HostedZoneAttributes
	{
        public static readonly ResourceAttribute<List<string>> NameServers = new ResourceAttribute<List<string>>("NameServers");
	}
}
