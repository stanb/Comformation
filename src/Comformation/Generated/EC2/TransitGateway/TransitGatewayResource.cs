using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGateway
{
    /// <summary>
    /// AWS::EC2::TransitGateway
    /// Specifies a transit gateway.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html
    /// </summary>
    public class TransitGatewayResource : ResourceBase
    {
        public class TransitGatewayProperties
        {
            /// <summary>
            /// DefaultRouteTablePropagation
            /// Indicates whether resource attachments automatically propagate routes to the default propagation
            /// route table.
            /// Required: No
            /// Type: String
            /// Allowed Values: disable | enable
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultRouteTablePropagation { get; set; }

            /// <summary>
            /// Description
            /// The description of the transit gateway.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AutoAcceptSharedAttachments
            /// Indicates whether attachment requests are automatically accepted.
            /// Required: No
            /// Type: String
            /// Allowed Values: disable | enable
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AutoAcceptSharedAttachments { get; set; }

            /// <summary>
            /// DefaultRouteTableAssociation
            /// Indicates whether resource attachments are automatically associated with the default association
            /// route table.
            /// Required: No
            /// Type: String
            /// Allowed Values: disable | enable
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultRouteTableAssociation { get; set; }

            /// <summary>
            /// VpnEcmpSupport
            /// Indicates whether Equal Cost Multipath Protocol support is enabled.
            /// Required: No
            /// Type: String
            /// Allowed Values: disable | enable
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VpnEcmpSupport { get; set; }

            /// <summary>
            /// DnsSupport
            /// Indicates whether DNS support is enabled.
            /// Required: No
            /// Type: String
            /// Allowed Values: disable | enable
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DnsSupport { get; set; }

            /// <summary>
            /// AmazonSideAsn
            /// A private Autonomous System Number (ASN) for the Amazon side of a BGP session. The range is 64512 to
            /// 65534 for 16-bit ASNs and 4200000000 to 4294967294 for 32-bit ASNs.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> AmazonSideAsn { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the transit gateway.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TransitGateway";

        public TransitGatewayProperties Properties { get; } = new TransitGatewayProperties();

    }
}
