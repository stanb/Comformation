using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGateway
{
    /// <summary>
    /// AWS::EC2::TransitGateway
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html
    /// </summary>
    public class TransitGatewayResource : ResourceBase
    {
        public class TransitGatewayProperties
        {
            /// <summary>
            /// DefaultRouteTablePropagation
            /// Enable or disable automatic propagation of routes to the default propagation route table. Enabled by
            /// default.
            /// Required: No
            /// Type: String
            /// Allowed values: disable | enable
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DefaultRouteTablePropagation { get; set; }

            /// <summary>
            /// Description
            /// The description of the transit gateway.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AutoAcceptSharedAttachments
            /// Enable or disable automatic acceptance of attachment requests. Disabled by default.
            /// Required: No
            /// Type: String
            /// Allowed values: disable | enable
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AutoAcceptSharedAttachments { get; set; }

            /// <summary>
            /// DefaultRouteTableAssociation
            /// Enable or disable automatic association with the default association route table. Enabled by
            /// default.
            /// Required: No
            /// Type: String
            /// Allowed values: disable | enable
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DefaultRouteTableAssociation { get; set; }

            /// <summary>
            /// VpnEcmpSupport
            /// Enable or disable Equal Cost Multipath Protocol support. Enabled by default.
            /// Required: No
            /// Type: String
            /// Allowed values: disable | enable
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> VpnEcmpSupport { get; set; }

            /// <summary>
            /// DnsSupport
            /// Enable or disable DNS support. Enabled by default.
            /// Required: No
            /// Type: String
            /// Allowed values: disable | enable
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DnsSupport { get; set; }

            /// <summary>
            /// MulticastSupport
            /// Indicates whether multicast is enabled on the transit gateway
            /// Required: No
            /// Type: String
            /// Allowed values: disable | enable
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MulticastSupport { get; set; }

            /// <summary>
            /// AmazonSideAsn
            /// A private Autonomous System Number (ASN) for the Amazon side of a BGP session. The range is 64512 to
            /// 65534 for 16-bit ASNs. The default is 64512.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
            public Union<int, IntrinsicFunction> AmazonSideAsn { get; set; }

            /// <summary>
            /// TransitGatewayCidrBlocks
            /// The transit gateway CIDR blocks.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> TransitGatewayCidrBlocks { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the transit gateway.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// AssociationDefaultRouteTableId
            /// The ID of the default association route table.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AssociationDefaultRouteTableId { get; set; }

            /// <summary>
            /// PropagationDefaultRouteTableId
            /// The ID of the default propagation route table.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PropagationDefaultRouteTableId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TransitGateway";

        public TransitGatewayProperties Properties { get; } = new TransitGatewayProperties();

    }

    public static class TransitGatewayAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
