using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualGateway
{
    /// <summary>
    /// AWS::AppMesh::VirtualGateway
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualgateway.html
    /// </summary>
    public class VirtualGatewayResource : ResourceBase
    {
        public class VirtualGatewayProperties
        {
            /// <summary>
            /// VirtualGatewayName
            /// The name of the virtual gateway.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VirtualGatewayName { get; set; }

            /// <summary>
            /// MeshName
            /// The name of the service mesh that the virtual gateway resides in.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MeshName { get; set; }

            /// <summary>
            /// MeshOwner
            /// The AWS IAM account ID of the service mesh owner. If the account ID is not your own, then it&#39;s the
            /// ID of the account that shared the mesh with your account. For more information about mesh sharing,
            /// see Working with shared meshes.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MeshOwner { get; set; }

            /// <summary>
            /// Spec
            /// The specifications of the virtual gateway.
            /// Required: Yes
            /// Type: VirtualGatewaySpec
            /// Update requires: No interruption
            /// </summary>
            public VirtualGatewaySpec Spec { get; set; }

            /// <summary>
            /// Tags
            /// Optional metadata that you can apply to the virtual gateway to assist with categorization and
            /// organization. Each tag consists of a key and an optional value, both of which you define. Tag keys
            /// can have a maximum character length of 128 characters, and tag values can have a maximum length of
            /// 256 characters.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::AppMesh::VirtualGateway";

        public VirtualGatewayProperties Properties { get; } = new VirtualGatewayProperties();

    }

    public static class VirtualGatewayAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Uid = new ResourceAttribute<Union<string, IntrinsicFunction>>("Uid");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> VirtualGatewayName = new ResourceAttribute<Union<string, IntrinsicFunction>>("VirtualGatewayName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MeshName = new ResourceAttribute<Union<string, IntrinsicFunction>>("MeshName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MeshOwner = new ResourceAttribute<Union<string, IntrinsicFunction>>("MeshOwner");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResourceOwner = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResourceOwner");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
