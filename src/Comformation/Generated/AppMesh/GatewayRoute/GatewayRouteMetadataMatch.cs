using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute GatewayRouteMetadataMatch
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutemetadatamatch.html
    /// </summary>
    public class GatewayRouteMetadataMatch
    {

        /// <summary>
        /// Suffix
        /// The specified ending characters of the method header to match on.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Suffix")]
        public Union<string, IntrinsicFunction> Suffix { get; set; }

        /// <summary>
        /// Regex
        /// The regex used to match the method header.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Regex")]
        public Union<string, IntrinsicFunction> Regex { get; set; }

        /// <summary>
        /// Exact
        /// The exact method header to be matched on.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Exact")]
        public Union<string, IntrinsicFunction> Exact { get; set; }

        /// <summary>
        /// Prefix
        /// The specified beginning characters of the method header to be matched on.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// Range
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: GatewayRouteRangeMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Range")]
        public GatewayRouteRangeMatch Range { get; set; }

    }
}
