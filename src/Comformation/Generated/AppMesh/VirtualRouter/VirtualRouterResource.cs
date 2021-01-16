using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualRouter
{
    /// <summary>
    /// AWS::AppMesh::VirtualRouter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualrouter.html
    /// </summary>
    public class VirtualRouterResource : ResourceBase
    {
        public class VirtualRouterProperties
        {
            /// <summary>
            /// MeshName
            /// The name of the service mesh to create the virtual router in.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MeshName { get; set; }

            /// <summary>
            /// VirtualRouterName
            /// The name to use for the virtual router.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VirtualRouterName { get; set; }

            /// <summary>
            /// MeshOwner
            /// The AWS IAM account ID of the service mesh owner. If the account ID is not your own, then the
            /// account that you specify must share the mesh with your account before you can create the resource in
            /// the service mesh. For more information about mesh sharing, see Working with shared meshes.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MeshOwner { get; set; }

            /// <summary>
            /// Spec
            /// The virtual router specification to apply.
            /// Required: Yes
            /// Type: VirtualRouterSpec
            /// Update requires: No interruption
            /// </summary>
            public VirtualRouterSpec Spec { get; set; }

            /// <summary>
            /// Tags
            /// Optional metadata that you can apply to the virtual router to assist with categorization and
            /// organization. Each tag consists of a key and an optional value, both of which you define. Tag keys
            /// can have a maximum character length of 128 characters, and tag values can have a maximum length of
            /// 256 characters.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::AppMesh::VirtualRouter";

        public VirtualRouterProperties Properties { get; } = new VirtualRouterProperties();

    }

    public static class VirtualRouterAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Uid = new ResourceAttribute<Union<string, IntrinsicFunction>>("Uid");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MeshName = new ResourceAttribute<Union<string, IntrinsicFunction>>("MeshName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> VirtualRouterName = new ResourceAttribute<Union<string, IntrinsicFunction>>("VirtualRouterName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MeshOwner = new ResourceAttribute<Union<string, IntrinsicFunction>>("MeshOwner");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResourceOwner = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResourceOwner");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
