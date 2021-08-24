using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute HttpGatewayRoutePrefixRewrite
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteprefixrewrite.html
    /// </summary>
    public class HttpGatewayRoutePrefixRewrite
    {

        /// <summary>
        /// Value
        /// The value used to replace the incoming route prefix when rewritten.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// DefaultPrefix
        /// The default prefix used to replace the incoming route prefix when rewritten.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultPrefix")]
        public Union<string, IntrinsicFunction> DefaultPrefix { get; set; }

    }
}
