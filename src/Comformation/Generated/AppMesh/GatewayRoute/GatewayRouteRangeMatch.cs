using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute GatewayRouteRangeMatch
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayrouterangematch.html
    /// </summary>
    public class GatewayRouteRangeMatch
    {

        /// <summary>
        /// Start
        /// The start of the range.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Start")]
        public Union<int, IntrinsicFunction> Start { get; set; }

        /// <summary>
        /// End
        /// The end of the range.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("End")]
        public Union<int, IntrinsicFunction> End { get; set; }

    }
}
