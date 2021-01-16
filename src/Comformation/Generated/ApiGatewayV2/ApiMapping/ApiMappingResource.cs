using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.ApiMapping
{
    /// <summary>
    /// AWS::ApiGatewayV2::ApiMapping
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-apimapping.html
    /// </summary>
    public class ApiMappingResource : ResourceBase
    {
        public class ApiMappingProperties
        {
            /// <summary>
            /// DomainName
            /// The domain name.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// Stage
            /// The API stage.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Stage { get; set; }

            /// <summary>
            /// ApiMappingKey
            /// The API mapping key.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ApiMappingKey { get; set; }

            /// <summary>
            /// ApiId
            /// The identifier of the API.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApiId { get; set; }

        }

        public string Type { get; } = "AWS::ApiGatewayV2::ApiMapping";

        public ApiMappingProperties Properties { get; } = new ApiMappingProperties();

    }
}
