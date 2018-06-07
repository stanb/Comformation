using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TrunkInterfaceAssociation
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trunkinterfaceassociation.html
    /// </summary>
    public class TrunkInterfaceAssociationResource : ResourceBase
    {
        public class TrunkInterfaceAssociationProperties
        {
            /// <summary>
            /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trunkinterfaceassociation.html#cfn-ec2-trunkinterfaceassociation-branchinterfaceid
            /// </summary>
			public Union<string, IntrinsicFunction> BranchInterfaceId { get; set; }

            /// <summary>
            /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trunkinterfaceassociation.html#cfn-ec2-trunkinterfaceassociation-grekey
            /// </summary>
			public Union<int, IntrinsicFunction> GREKey { get; set; }

            /// <summary>
            /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trunkinterfaceassociation.html#cfn-ec2-trunkinterfaceassociation-trunkinterfaceid
            /// </summary>
			public Union<string, IntrinsicFunction> TrunkInterfaceId { get; set; }

            /// <summary>
            /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trunkinterfaceassociation.html#cfn-ec2-trunkinterfaceassociation-vlanid
            /// </summary>
			public Union<int, IntrinsicFunction> VLANId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::TrunkInterfaceAssociation";
        
        public TrunkInterfaceAssociationProperties Properties { get; } = new TrunkInterfaceAssociationProperties();
    }
}
