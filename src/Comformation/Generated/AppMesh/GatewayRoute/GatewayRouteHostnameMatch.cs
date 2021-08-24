using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute GatewayRouteHostnameMatch
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutehostnamematch.html
    /// </summary>
    public class GatewayRouteHostnameMatch
    {

        /// <summary>
        /// Suffix
        /// The specified ending characters of the host name to match on.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Suffix")]
        public Union<string, IntrinsicFunction> Suffix { get; set; }

        /// <summary>
        /// Exact
        /// The exact host name to match on.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Exact")]
        public Union<string, IntrinsicFunction> Exact { get; set; }

    }
}
