using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TransitGateway
{
    /// <summary>
    /// AWS::EC2::TransitGateway
    /// Creates a transit gateway. For more information, see Amazon VPC Transit Gateways.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html
    /// </summary>
    public class TransitGatewayResource : ResourceBase
    {
        public class TransitGatewayProperties
        {
            /// <summary>
            /// DefaultRouteTablePropagation
            /// Enable or disable automatic propagation of routes to the default propagation route table. The
            /// default is enable.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultRouteTablePropagation { get; set; }

            /// <summary>
            /// Description
            /// A description of the transit gateway.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AutoAcceptSharedAttachments
            /// Indicates whether attachment requests are automatically accepted. The default is disable.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AutoAcceptSharedAttachments { get; set; }

            /// <summary>
            /// DefaultRouteTableAssociation
            /// Enable or disable automatic association with the default association route table. The default is
            /// enable.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DefaultRouteTableAssociation { get; set; }

            /// <summary>
            /// VpnEcmpSupport
            /// Enable or disable Equal Cost Multipath Protocol. The default is enable.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VpnEcmpSupport { get; set; }

            /// <summary>
            /// DnsSupport
            /// Enable or disable DNS support. The default is enable.
            /// Required: No
            /// Type: String
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
            /// The tags to apply to the transit gateway.
            /// Required: No
            /// Type: List of Resource Tag property types
            /// Update requires: Replacement
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::TransitGateway";

        public TransitGatewayProperties Properties { get; } = new TransitGatewayProperties();

    }
}
