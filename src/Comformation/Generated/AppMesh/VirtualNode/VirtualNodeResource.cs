using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode
    /// Creates a virtual node within a service mesh.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualnode.html
    /// </summary>
    public class VirtualNodeResource : ResourceBase
    {
        public class VirtualNodeProperties
        {
            /// <summary>
            /// MeshName
            /// The name of the service mesh to create the virtual node in.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MeshName { get; set; }

            /// <summary>
            /// Spec
            /// The virtual node specification to apply.
            /// Required: Yes
            /// Type: VirtualNodeSpec
            /// Update requires: No interruption
            /// </summary>
			public VirtualNodeSpec Spec { get; set; }

            /// <summary>
            /// VirtualNodeName
            /// The name to use for the virtual node.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VirtualNodeName { get; set; }

            /// <summary>
            /// Tags
            /// Optional metadata that you can apply to the virtual node to assist with categorization and
            /// organization. Each tag consists of a key and an optional value, both of which you define. Tag keys
            /// can have a maximum character length of 128 characters, and tag values can have a maximum length of
            /// 256 characters.
            /// Required: No
            /// Type: List of TagRef
            /// Update requires: No interruption
            /// </summary>
			public List<TagRef> Tags { get; set; }

        }

        public string Type { get; } = "AWS::AppMesh::VirtualNode";

        public VirtualNodeProperties Properties { get; } = new VirtualNodeProperties();

    }

	public static class VirtualNodeAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Uid = new ResourceAttribute<Union<string, IntrinsicFunction>>("Uid");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MeshName = new ResourceAttribute<Union<string, IntrinsicFunction>>("MeshName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> VirtualNodeName = new ResourceAttribute<Union<string, IntrinsicFunction>>("VirtualNodeName");
	}
}
