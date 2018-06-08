using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.DocumentationVersion
{
    /// <summary>
    /// AWS::ApiGateway::DocumentationVersion
    /// The AWS::ApiGateway::DocumentationVersion resource creates a snapshot of the documentation for an Amazon API
    /// Gateway API entity. For more information, see Representation of API Documentation in API Gateway in the API
    /// Gateway Developer Guide.
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
            /// The identifier of the targeted API entity.
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
