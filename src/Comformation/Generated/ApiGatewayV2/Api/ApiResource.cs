using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Api
{
    /// <summary>
    /// AWS::ApiGatewayV2::Api
    /// The AWS::ApiGatewayV2::Api resource contains an Amazon API Gateway API. For more information, see CreateApi in
    /// the Amazon API Gateway V2 API Reference.
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
            /// The API protocol.
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
            /// Name
            /// The name of the API.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ApiKeySelectionExpression
            /// An API key selection expression.
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
