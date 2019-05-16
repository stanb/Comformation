using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.DocumentationPart
{
    /// <summary>
    /// AWS::ApiGateway::DocumentationPart
    /// The AWS::ApiGateway::DocumentationPart resource creates a documentation part for an API. For more information,
    /// see Representation of API Documentation in API Gateway in the API Gateway Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationpart.html
    /// </summary>
    public class DocumentationPartResource : ResourceBase
    {
        public class DocumentationPartProperties
        {
            /// <summary>
            /// Location
            /// The location of the API entity that the documentation applies to.
            /// Required: Yes
            /// Type: Location
            /// Update requires: Replacement
            /// </summary>
			public Location Location { get; set; }

            /// <summary>
            /// Properties
            /// The documentation content map of the targeted API entity.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Properties { get; set; }

            /// <summary>
            /// RestApiId
            /// The identifier of the targeted API entity.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RestApiId { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::DocumentationPart";

        public DocumentationPartProperties Properties { get; } = new DocumentationPartProperties();

    }
}
