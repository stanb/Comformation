using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HostedZone
{
    /// <summary>
    /// AWS::Route53::HostedZone
    /// The AWS::Route53::HostedZone resource creates a hosted zone, which can contain a collection of record sets for
    /// a domain. You cannot create a hosted zone for a top-level domain (TLD). For more information, see POST
    /// CreateHostedZone or POST CreateHostedZone (Private) in the Amazon Route&#160;53 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53-hostedzone.html
    /// </summary>
    public class HostedZoneResource : ResourceBase
    {
        public class HostedZoneProperties
        {
            /// <summary>
            /// HostedZoneConfig
            /// A complex type that contains an optional comment about your hosted zone.
            /// Required: No
            /// Type: Route&#160;53 HostedZoneConfig Property
            /// Update requires: No interruption
            /// </summary>
			public HostedZoneConfig HostedZoneConfig { get; set; }

            /// <summary>
            /// HostedZoneTags
            /// An arbitrary set of tags (key–value pairs) for this hosted zone.
            /// Required: No
            /// Type: List of Amazon Route&#160;53 HostedZoneTags
            /// Update requires: No interruption
            /// </summary>
			public List<HostedZoneTag> HostedZoneTags { get; set; }

            /// <summary>
            /// Name
            /// The name of the domain. For resource record types that include a domain name, specify a fully
            /// qualified domain name.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// QueryLoggingConfig
            /// The configuration for DNS query logging.
            /// Required: No
            /// Type: Route&#160;53 QueryLoggingConfig
            /// Update requires: No interruption
            /// </summary>
			public QueryLoggingConfig QueryLoggingConfig { get; set; }

            /// <summary>
            /// VPCs
            /// One or more VPCs that you want to associate with this hosted zone. When you specify this property,
            /// AWS CloudFormation creates a private hosted zone.
            /// Required: No
            /// Type: List of Route&#160;53 HostedZoneVPCs
            /// If this property was specified previously and you&#39;re modifying values, updates require no
            /// interruption. If this property wasn&#39;t specified and you add values, updates require replacement.
            /// Also, if this property was specified and you remove all values, updates require replacement.
            /// </summary>
			public List<VPC> VPCs { get; set; }

        }
    
        public string Type { get; } = "AWS::Route53::HostedZone";
        
        public HostedZoneProperties Properties { get; } = new HostedZoneProperties();

    }

	public static class HostedZoneAttributes
	{
        public static readonly ResourceAttribute<List<Union<string, IntrinsicFunction>>> NameServers = new ResourceAttribute<List<Union<string, IntrinsicFunction>>>("NameServers");
	}
}
