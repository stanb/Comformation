using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Integration
{
    /// <summary>
    /// AWS::ApiGatewayV2::Integration ResponseParameterList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-integration-responseparameterlist.html
    /// </summary>
    public class ResponseParameterList
    {

        /// <summary>
        /// ResponseParameters
        /// Supported only for HTTP APIs. You use response parameters to transform the HTTP response from a
        /// backend integration before returning the response to clients. Specify a key-value map from a
        /// selection key to response parameters. The selection key must be a valid HTTP status code within the
        /// range of 200-599. Response parameters are a key-value map. The key must match the pattern
        /// &amp;lt;action&amp;gt;:&amp;lt;header&amp;gt;. &amp;lt;location&amp;gt; or overwrite. statuscode. The action can be append,
        /// overwrite or remove. The value can be a static value, or map to response data, stage variables, or
        /// context variables that are evaluated at runtime. To learn more, see Transforming API requests and
        /// responses.
        /// Required: No
        /// Type: List of ResponseParameter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResponseParameters")]
        public List<ResponseParameter> ResponseParameters { get; set; }

    }
}
