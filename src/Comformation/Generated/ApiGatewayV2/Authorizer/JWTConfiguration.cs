using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Authorizer
{
    /// <summary>
    /// AWS::ApiGatewayV2::Authorizer JWTConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-authorizer-jwtconfiguration.html
    /// </summary>
    public class JWTConfiguration
    {

        /// <summary>
        /// Issuer
        /// The base domain of the identity provider that issues JSON Web Tokens. For example, an Amazon Cognito
        /// user pool has the following format: https://cognito-idp. {region}. amazonaws. com/{userPoolId} .
        /// Required for the JWT authorizer type. Supported only for HTTP APIs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Issuer")]
        public Union<string, IntrinsicFunction> Issuer { get; set; }

        /// <summary>
        /// Audience
        /// A list of the intended recipients of the JWT. A valid JWT must provide an aud that matches at least
        /// one entry in this list. See RFC 7519. Required for the JWT authorizer type. Supported only for HTTP
        /// APIs.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Audience")]
        public List<Union<string, IntrinsicFunction>> Audience { get; set; }

    }
}
