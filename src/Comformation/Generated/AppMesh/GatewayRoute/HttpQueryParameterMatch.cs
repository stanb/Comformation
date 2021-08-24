using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute HttpQueryParameterMatch
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpqueryparametermatch.html
    /// </summary>
    public class HttpQueryParameterMatch
    {

        /// <summary>
        /// Exact
        /// The exact query parameter to match on.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Exact")]
        public Union<string, IntrinsicFunction> Exact { get; set; }

    }
}
