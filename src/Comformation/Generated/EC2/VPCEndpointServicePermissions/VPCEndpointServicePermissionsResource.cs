using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.VPCEndpointServicePermissions
{
    /// <summary>
    /// AWS::EC2::VPCEndpointServicePermissions
    /// Grant or revoke permissions for service consumers (IAM users, IAM roles, and AWS accounts) to connect to the
    /// VPC endpoint service. For more information, see ModifyVpcEndpointServicePermissions in the Amazon EC2 API
    /// Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservicepermissions.html
    /// </summary>
    public class VPCEndpointServicePermissionsResource : ResourceBase
    {
        public class VPCEndpointServicePermissionsProperties
        {
            /// <summary>
            /// AllowedPrincipals
            /// The Amazon Resource Names (ARN) of one or more principals (IAM users, IAM roles, and AWS accounts).
            /// Permissions are granted to the principals in this list. To grant permissions to all principals,
            /// specify an asterisk (*). Permissions are revoked for principals not in this list. If the list is
            /// empty, then all permissions are revoked.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> AllowedPrincipals { get; set; }

            /// <summary>
            /// ServiceId
            /// The ID of the VPC endpoint service.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceId { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::VPCEndpointServicePermissions";
        
        public VPCEndpointServicePermissionsProperties Properties { get; } = new VPCEndpointServicePermissionsProperties();
    }
}
