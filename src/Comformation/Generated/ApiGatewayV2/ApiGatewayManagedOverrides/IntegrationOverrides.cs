using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.ApiGatewayManagedOverrides
{
    /// <summary>
    /// AWS::ApiGatewayV2::ApiGatewayManagedOverrides IntegrationOverrides
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-apigatewaymanagedoverrides-integrationoverrides.html
    /// </summary>
    public class IntegrationOverrides
    {

        /// <summary>
        /// Description
        /// The description of the integration.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// PayloadFormatVersion
        /// Specifies the format of the payload sent to an integration. Required for HTTP APIs. For HTTP APIs,
        /// supported values for Lambda proxy integrations are 1. 0 and 2. 0. For all other integrations, 1. 0
        /// is the only supported value. To learn more, see Working with AWS Lambda proxy integrations for HTTP
        /// APIs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PayloadFormatVersion")]
        public Union<string, IntrinsicFunction> PayloadFormatVersion { get; set; }

        /// <summary>
        /// TimeoutInMillis
        /// Custom timeout between 50 and 29,000 milliseconds for WebSocket APIs and between 50 and 30,000
        /// milliseconds for HTTP APIs. The default timeout is 29 seconds for WebSocket APIs and 30 seconds for
        /// HTTP APIs.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeoutInMillis")]
        public Union<int, IntrinsicFunction> TimeoutInMillis { get; set; }

        /// <summary>
        /// IntegrationMethod
        /// Specifies the integration&#39;s HTTP method type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IntegrationMethod")]
        public Union<string, IntrinsicFunction> IntegrationMethod { get; set; }

    }
}
