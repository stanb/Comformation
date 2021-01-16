using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html
    /// </summary>
    public class GatewayRouteResource : ResourceBase
    {
        public class GatewayRouteProperties
        {
            /// <summary>
            /// MeshName
            /// The name of the service mesh that the resource resides in.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MeshName { get; set; }

            /// <summary>
            /// VirtualGatewayName
            /// The virtual gateway that the gateway route is associated with.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VirtualGatewayName { get; set; }

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
            /// GatewayRouteName
            /// The name of the gateway route.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> GatewayRouteName { get; set; }

            /// <summary>
            /// Spec
            /// The specifications of the gateway route.
            /// Required: Yes
            /// Type: GatewayRouteSpec
            /// Update requires: No interruption
            /// </summary>
            public GatewayRouteSpec Spec { get; set; }

            /// <summary>
            /// Tags
            /// Optional metadata that you can apply to the gateway route to assist with categorization and
            /// organization. Each tag consists of a key and an optional value, both of which you define. Tag keys
            /// can have a maximum character length of 128 characters, and tag values can have a maximum length of
            /// 256 characters.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::AppMesh::GatewayRoute";

        public GatewayRouteProperties Properties { get; } = new GatewayRouteProperties();

    }

    public static class GatewayRouteAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Uid = new ResourceAttribute<Union<string, IntrinsicFunction>>("Uid");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MeshName = new ResourceAttribute<Union<string, IntrinsicFunction>>("MeshName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> VirtualGatewayName = new ResourceAttribute<Union<string, IntrinsicFunction>>("VirtualGatewayName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MeshOwner = new ResourceAttribute<Union<string, IntrinsicFunction>>("MeshOwner");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResourceOwner = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResourceOwner");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> GatewayRouteName = new ResourceAttribute<Union<string, IntrinsicFunction>>("GatewayRouteName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
