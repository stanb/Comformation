using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Resource
{
    /// <summary>
    /// AWS::ApiGateway::Resource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-resource.html
    /// </summary>
    public class ResourceResource : ResourceBase
    {
        public class ResourceProperties
        {
            /// <summary>
            /// RestApiId
            /// The ID of the RestApi resource in which you want to create this resource.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RestApiId { get; set; }

            /// <summary>
            /// ParentId
            /// If you want to create a child resource, the ID of the parent resource. For resources without a
            /// parent, specify the RestApi root resource ID, such as { &quot;Fn::GetAtt&quot;: [&quot;MyRestApi&quot;,
            /// &quot;RootResourceId&quot;] }.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ParentId { get; set; }

            /// <summary>
            /// PathPart
            /// A path name for the resource.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PathPart { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::Resource";

        public ResourceProperties Properties { get; } = new ResourceProperties();

    }

    public static class ResourceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResourceId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResourceId");
    }
}
