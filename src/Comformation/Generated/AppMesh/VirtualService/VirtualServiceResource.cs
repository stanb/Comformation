using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualService
{
    /// <summary>
    /// AWS::AppMesh::VirtualService
    /// Creates a virtual service within a service mesh.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualservice.html
    /// </summary>
    public class VirtualServiceResource : ResourceBase
    {
        public class VirtualServiceProperties
        {
            /// <summary>
            /// MeshName
            /// The name of the service mesh to create the virtual service in.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MeshName { get; set; }

            /// <summary>
            /// VirtualServiceName
            /// The name to use for the virtual service.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> VirtualServiceName { get; set; }

            /// <summary>
            /// Spec
            /// The virtual service specification to apply.
            /// Required: Yes
            /// Type: VirtualServiceSpec
            /// Update requires: No interruption
            /// </summary>
			public VirtualServiceSpec Spec { get; set; }

            /// <summary>
            /// Tags
            /// Optional metadata that you can apply to the virtual service to assist with categorization and
            /// organization. Each tag consists of a key and an optional value, both of which you define. Tag keys
            /// can have a maximum character length of 128 characters, and tag values can have a maximum length of
            /// 256 characters.
            /// Required: No
            /// Type: List of TagRef
            /// Update requires: No interruption
            /// </summary>
			public List<TagRef> Tags { get; set; }

        }

        public string Type { get; } = "AWS::AppMesh::VirtualService";

        public VirtualServiceProperties Properties { get; } = new VirtualServiceProperties();

    }

	public static class VirtualServiceAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Uid = new ResourceAttribute<Union<string, IntrinsicFunction>>("Uid");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MeshName = new ResourceAttribute<Union<string, IntrinsicFunction>>("MeshName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> VirtualServiceName = new ResourceAttribute<Union<string, IntrinsicFunction>>("VirtualServiceName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}