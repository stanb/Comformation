using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInterfacePermission
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterfacepermission.html
    /// </summary>
    public class NetworkInterfacePermissionResource : ResourceBase
    {
        public class NetworkInterfacePermissionProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterfacepermission.html#cfn-ec2-networkinterfacepermission-awsaccountid
            /// </summary>
			public Union<string, IntrinsicFunction> AwsAccountId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterfacepermission.html#cfn-ec2-networkinterfacepermission-networkinterfaceid
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterfacepermission.html#cfn-ec2-networkinterfacepermission-permission
            /// </summary>
			public Union<string, IntrinsicFunction> Permission { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::NetworkInterfacePermission";
        
        public NetworkInterfacePermissionProperties Properties { get; } = new NetworkInterfacePermissionProperties();
    }
}
