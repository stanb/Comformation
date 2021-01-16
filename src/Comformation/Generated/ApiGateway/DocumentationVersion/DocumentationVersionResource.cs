using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.DocumentationVersion
{
    /// <summary>
    /// AWS::ApiGateway::DocumentationVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html
    /// </summary>
    public class DocumentationVersionResource : ResourceBase
    {
        public class DocumentationVersionProperties
        {
            /// <summary>
            /// Description
            /// The description of the API documentation snapshot.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DocumentationVersion
            /// The version identifier of the API documentation snapshot.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DocumentationVersion { get; set; }

            /// <summary>
            /// RestApiId
            /// The identifier of the API.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RestApiId { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::DocumentationVersion";

        public DocumentationVersionProperties Properties { get; } = new DocumentationVersionProperties();

    }
}
