using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Api
{
    /// <summary>
    /// AWS::ApiGatewayV2::Api Cors
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-api-cors.html
    /// </summary>
    public class Cors
    {

        /// <summary>
        /// AllowOrigins
        /// Represents a collection of allowed origins. Supported only for HTTP APIs.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowOrigins")]
        public List<Union<string, IntrinsicFunction>> AllowOrigins { get; set; }

        /// <summary>
        /// AllowCredentials
        /// Specifies whether credentials are included in the CORS request. Supported only for HTTP APIs.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowCredentials")]
        public Union<bool, IntrinsicFunction> AllowCredentials { get; set; }

        /// <summary>
        /// ExposeHeaders
        /// Represents a collection of exposed headers. Supported only for HTTP APIs.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExposeHeaders")]
        public List<Union<string, IntrinsicFunction>> ExposeHeaders { get; set; }

        /// <summary>
        /// AllowHeaders
        /// Represents a collection of allowed headers. Supported only for HTTP APIs.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowHeaders")]
        public List<Union<string, IntrinsicFunction>> AllowHeaders { get; set; }

        /// <summary>
        /// MaxAge
        /// The number of seconds that the browser should cache preflight request results. Supported only for
        /// HTTP APIs.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxAge")]
        public Union<int, IntrinsicFunction> MaxAge { get; set; }

        /// <summary>
        /// AllowMethods
        /// Represents a collection of allowed HTTP methods. Supported only for HTTP APIs.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowMethods")]
        public List<Union<string, IntrinsicFunction>> AllowMethods { get; set; }

    }
}
