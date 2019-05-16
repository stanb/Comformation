using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.GatewayResponse
{
    /// <summary>
    /// AWS::ApiGateway::GatewayResponse
    /// The AWS::ApiGateway::GatewayResponse resource creates a gateway response for your API. For more information,
    /// see API Gateway Responses in the API Gateway Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-gatewayresponse.html
    /// </summary>
    public class GatewayResponseResource : ResourceBase
    {
        public class GatewayResponseProperties
        {
            /// <summary>
            /// ResponseParameters
            /// The response parameters (paths, query strings, and headers) for the response. Duplicates not
            /// allowed.
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
			public Dictionary<string, Union<string, IntrinsicFunction>> ResponseParameters { get; set; }

            /// <summary>
            /// ResponseTemplates
            /// The response templates for the response. Duplicates not allowed.
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
			public Dictionary<string, Union<string, IntrinsicFunction>> ResponseTemplates { get; set; }

            /// <summary>
            /// ResponseType
            /// The response type. For valid values, see GatewayResponse in the API Gateway API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ResponseType { get; set; }

            /// <summary>
            /// RestApiId
            /// The identifier of the API.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RestApiId { get; set; }

            /// <summary>
            /// StatusCode
            /// The HTTP status code for the response.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> StatusCode { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::GatewayResponse";

        public GatewayResponseProperties Properties { get; } = new GatewayResponseProperties();

    }
}
