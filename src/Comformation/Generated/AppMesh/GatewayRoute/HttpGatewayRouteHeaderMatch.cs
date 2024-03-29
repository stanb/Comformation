using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute HttpGatewayRouteHeaderMatch
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteheadermatch.html
    /// </summary>
    public class HttpGatewayRouteHeaderMatch
    {

        /// <summary>
        /// Suffix
        /// The value sent by the client must end with the specified characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Suffix")]
        public Union<string, IntrinsicFunction> Suffix { get; set; }

        /// <summary>
        /// Regex
        /// The value sent by the client must include the specified characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Regex")]
        public Union<string, IntrinsicFunction> Regex { get; set; }

        /// <summary>
        /// Exact
        /// The value sent by the client must match the specified value exactly.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Exact")]
        public Union<string, IntrinsicFunction> Exact { get; set; }

        /// <summary>
        /// Prefix
        /// The value sent by the client must begin with the specified characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// Range
        /// An object that represents the range of values to match on.
        /// Required: No
        /// Type: GatewayRouteRangeMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Range")]
        public GatewayRouteRangeMatch Range { get; set; }

    }
}
