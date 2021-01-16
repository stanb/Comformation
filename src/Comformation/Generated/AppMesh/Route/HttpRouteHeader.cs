using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route HttpRouteHeader
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httprouteheader.html
    /// </summary>
    public class HttpRouteHeader
    {

        /// <summary>
        /// Invert
        /// Specify True to match anything except the match criteria. The default value is False.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Invert")]
        public Union<bool, IntrinsicFunction> Invert { get; set; }

        /// <summary>
        /// Name
        /// A name for the HTTP header in the client request that will be matched on.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Match
        /// The HeaderMatchMethod object.
        /// Required: No
        /// Type: HeaderMatchMethod
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Match")]
        public HeaderMatchMethod Match { get; set; }

    }
}
