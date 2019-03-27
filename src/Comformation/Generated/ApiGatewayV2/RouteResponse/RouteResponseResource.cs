using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.RouteResponse
{
    /// <summary>
    /// AWS::ApiGatewayV2::RouteResponse
    /// The AWS::ApiGatewayV2::RouteResponse resource defines the route response for a WebSocket API route. For more
    /// information, see CreateRouteResponse in the Amazon API Gateway V2 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-routeresponse.html
    /// </summary>
    public class RouteResponseResource : ResourceBase
    {
        public class RouteResponseProperties
        {
            /// <summary>
            /// RouteResponseKey
            /// The route response key.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RouteResponseKey { get; set; }

            /// <summary>
            /// ResponseParameters
            /// The route response parameters.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ResponseParameters { get; set; }

            /// <summary>
            /// RouteId
            /// The route ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RouteId { get; set; }

            /// <summary>
            /// ModelSelectionExpression
            /// The model selection expression for the route response.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ModelSelectionExpression { get; set; }

            /// <summary>
            /// ApiId
            /// The API ID
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// ResponseModels
            /// The response models for the route response.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ResponseModels { get; set; }

        }

        public string Type { get; } = "AWS::ApiGatewayV2::RouteResponse";

        public RouteResponseProperties Properties { get; } = new RouteResponseProperties();

    }
}
