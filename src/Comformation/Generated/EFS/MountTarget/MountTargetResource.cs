using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EFS.MountTarget
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-mounttarget.html
    /// </summary>
    public class MountTargetResource : ResourceBase
    {
        public class MountTargetProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-mounttarget.html#cfn-efs-mounttarget-filesystemid
            /// </summary>
			public Union<string, IntrinsicFunction> FileSystemId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-mounttarget.html#cfn-efs-mounttarget-ipaddress
            /// </summary>
			public Union<string, IntrinsicFunction> IpAddress { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-mounttarget.html#cfn-efs-mounttarget-securitygroups
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroups { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-mounttarget.html#cfn-efs-mounttarget-subnetid
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

        }
    
        public string Type { get; } = "AWS::EFS::MountTarget";
        
        public MountTargetProperties Properties { get; } = new MountTargetProperties();
    }
}
