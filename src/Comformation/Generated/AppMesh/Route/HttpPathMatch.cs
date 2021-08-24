using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route HttpPathMatch
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httppathmatch.html
    /// </summary>
    public class HttpPathMatch
    {

        /// <summary>
        /// Regex
        /// The regex used to match the path.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Regex")]
        public Union<string, IntrinsicFunction> Regex { get; set; }

        /// <summary>
        /// Exact
        /// The exact path to match on.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Exact")]
        public Union<string, IntrinsicFunction> Exact { get; set; }

    }
}
