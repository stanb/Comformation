using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.LakeFormation.Permissions
{
    /// <summary>
    /// AWS::LakeFormation::Permissions
    /// The AWS::LakeFormation::Permissions resource is an AWS Lake Formation resource type that grants or revokes AWS
    /// Lake Formation permissions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html
    /// </summary>
    public class PermissionsResource : ResourceBase
    {
        public class PermissionsProperties
        {
            /// <summary>
            /// DataLakePrincipal
            /// 	
            /// The AWS Lake Formation principal.
            /// Required: Yes
            /// Type: DataLakePrincipal
            /// Update requires: No interruption
            /// </summary>
			public DataLakePrincipal DataLakePrincipal { get; set; }

            /// <summary>
            /// Resource
            /// 	
            /// A structure for the resource.
            /// Required: Yes
            /// Type: Resource
            /// Update requires: No interruption
            /// </summary>
			public Resource Resource { get; set; }

            /// <summary>
            /// Permissions
            /// 	
            /// The permissions granted or revoked.
            /// 	
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> Permissions { get; set; }

            /// <summary>
            /// PermissionsWithGrantOption
            /// 	
            /// Indicates whether to grant the ability to grant permissions (as a subset of permissions granted).
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> PermissionsWithGrantOption { get; set; }

        }

        public string Type { get; } = "AWS::LakeFormation::Permissions";

        public PermissionsProperties Properties { get; } = new PermissionsProperties();

    }
}
