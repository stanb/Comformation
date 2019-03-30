using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Mesh
{
    /// <summary>
    /// AWS::AppMesh::Mesh
    /// Creates a service mesh. A service mesh is a logical boundary for network traffic between the services that
    /// reside within it.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-mesh.html
    /// </summary>
    public class MeshResource : ResourceBase
    {
        public class MeshProperties
        {
            /// <summary>
            /// MeshName
            /// The name to use for the service mesh.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MeshName { get; set; }

            /// <summary>
            /// Spec
            /// The service mesh specification to apply.
            /// Required: No
            /// Type: MeshSpec
            /// Update requires: No interruption
            /// </summary>
			public MeshSpec Spec { get; set; }

            /// <summary>
            /// Tags
            /// Optional metadata that you can apply to the service mesh to assist with categorization and
            /// organization. Each tag consists of a key and an optional value, both of which you define. Tag keys
            /// can have a maximum character length of 128 characters, and tag values can have a maximum length of
            /// 256 characters.
            /// Required: No
            /// Type: List of TagRef
            /// Update requires: No interruption
            /// </summary>
			public List<TagRef> Tags { get; set; }

        }

        public string Type { get; } = "AWS::AppMesh::Mesh";

        public MeshProperties Properties { get; } = new MeshProperties();

    }

	public static class MeshAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Uid = new ResourceAttribute<Union<string, IntrinsicFunction>>("Uid");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MeshName = new ResourceAttribute<Union<string, IntrinsicFunction>>("MeshName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
