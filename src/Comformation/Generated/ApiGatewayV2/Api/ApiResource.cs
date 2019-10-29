using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Api
{
    /// <summary>
    /// AWS::ApiGatewayV2::Api
    /// The AWS::ApiGatewayV2::Api resource creates an API. Currently only WebSocket APIs are supported. For more
    /// information about WebSocket APIs, see About WebSocket APIs in API Gateway in the API Gateway Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-api.html
    /// </summary>
    public class ApiResource : ResourceBase
    {
        public class ApiProperties
        {
            /// <summary>
            /// RouteSelectionExpression
            /// The route selection expression for the API.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RouteSelectionExpression { get; set; }

            /// <summary>
            /// Description
            /// The description of the API.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Version
            /// A version identifier for the API.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Version { get; set; }

            /// <summary>
            /// ProtocolType
            /// The API protocol: Currently only WEBSOCKET is supported.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ProtocolType { get; set; }

            /// <summary>
            /// DisableSchemaValidation
            /// Avoid validating models when creating a deployment.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> DisableSchemaValidation { get; set; }

            /// <summary>
            /// Tags
            /// The collection of tags. Each tag element is associated with a given resource.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the API.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ApiKeySelectionExpression
            /// An API key selection expression. See API Key Selection Expressions.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ApiKeySelectionExpression { get; set; }

        }

        public string Type { get; } = "AWS::ApiGatewayV2::Api";

        public ApiProperties Properties { get; } = new ApiProperties();

    }
}
