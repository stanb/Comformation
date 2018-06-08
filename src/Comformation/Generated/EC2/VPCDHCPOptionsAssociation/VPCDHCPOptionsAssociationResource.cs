using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPCDHCPOptionsAssociation
{
    /// <summary>
    /// AWS::EC2::VPCDHCPOptionsAssociation
    /// Associates a set of DHCP options (that you've previously created) with the specified VPC.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-dhcp-options-assoc.html
    /// </summary>
    public class VPCDHCPOptionsAssociationResource : ResourceBase
    {
        public class VPCDHCPOptionsAssociationProperties
        {
            /// <summary>
            /// DhcpOptionsId
            /// The ID of the DHCP options you want to associate with the VPC. Specify default if you want the VPC
            /// to use no DHCP options.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DhcpOptionsId { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the VPC to associate with this DHCP options set.
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
