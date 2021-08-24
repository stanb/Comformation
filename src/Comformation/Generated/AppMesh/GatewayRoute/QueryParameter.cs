using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.GatewayRoute
{
    /// <summary>
    /// AWS::AppMesh::GatewayRoute QueryParameter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-queryparameter.html
    /// </summary>
    public class QueryParameter
    {

        /// <summary>
        /// Name
        /// A name for the query parameter that will be matched on.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Match
        /// The query parameter to match on.
        /// Required: No
        /// Type: HttpQueryParameterMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Match")]
        public HttpQueryParameterMatch Match { get; set; }

    }
}
