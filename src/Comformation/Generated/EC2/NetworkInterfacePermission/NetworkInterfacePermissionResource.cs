using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkInterfacePermission
{
    /// <summary>
    /// AWS::EC2::NetworkInterfacePermission
    /// Specifies a permission for an Amazon EC2 network interface. For example, you can grant an AWS authorized
    /// partner account permission to attach the specified network interface to an instance in their account.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinterfacepermission.html
    /// </summary>
    public class NetworkInterfacePermissionResource : ResourceBase
    {
        public class NetworkInterfacePermissionProperties
        {
            /// <summary>
            /// AwsAccountId
            /// 		
            /// The AWS account ID.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AwsAccountId { get; set; }

            /// <summary>
            /// NetworkInterfaceId
            /// 		
            /// The ID of the network interface.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkInterfaceId { get; set; }

            /// <summary>
            /// Permission
            /// The type of permission to grant: INSTANCE-ATTACH or EIP-ASSOCIATE.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: EIP-ASSOCIATE | INSTANCE-ATTACH
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Permission { get; set; }

        }

        public string Type { get; } = "AWS::EC2::NetworkInterfacePermission";

        public NetworkInterfacePermissionProperties Properties { get; } = new NetworkInterfacePermissionProperties();

    }
}
