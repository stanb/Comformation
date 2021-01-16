using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPCDHCPOptionsAssociation
{
    /// <summary>
    /// AWS::EC2::VPCDHCPOptionsAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-dhcp-options-assoc.html
    /// </summary>
    public class VPCDHCPOptionsAssociationResource : ResourceBase
    {
        public class VPCDHCPOptionsAssociationProperties
        {
            /// <summary>
            /// DhcpOptionsId
            /// The ID of the DHCP options set, or default to associate no DHCP options with the VPC.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DhcpOptionsId { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VpcId { get; set; }

        }

        public string Type { get; } = "AWS::EC2::VPCDHCPOptionsAssociation";

        public VPCDHCPOptionsAssociationProperties Properties { get; } = new VPCDHCPOptionsAssociationProperties();

    }
}
