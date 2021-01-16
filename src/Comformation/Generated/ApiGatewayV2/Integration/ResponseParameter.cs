using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Integration
{
    /// <summary>
    /// AWS::ApiGatewayV2::Integration ResponseParameter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-integration-responseparameter.html
    /// </summary>
    public class ResponseParameter
    {

        /// <summary>
        /// Destination
        /// Specifies the location of the response to modify, and how to modify it. To learn more, see
        /// Transforming API requests and responses.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public Union<string, IntrinsicFunction> Destination { get; set; }

        /// <summary>
        /// Source
        /// Specifies the data to update the parameter with. To learn more, see Transforming API requests and
        /// responses.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Source")]
        public Union<string, IntrinsicFunction> Source { get; set; }

    }
}
