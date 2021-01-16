using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Integration
{
    /// <summary>
    /// AWS::ApiGatewayV2::Integration TlsConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-integration-tlsconfig.html
    /// </summary>
    public class TlsConfig
    {

        /// <summary>
        /// ServerNameToVerify
        /// If you specify a server name, API Gateway uses it to verify the hostname on the integration&#39;s
        /// certificate. The server name is also included in the TLS handshake to support Server Name Indication
        /// (SNI) or virtual hosting.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServerNameToVerify")]
        public Union<string, IntrinsicFunction> ServerNameToVerify { get; set; }

    }
}
