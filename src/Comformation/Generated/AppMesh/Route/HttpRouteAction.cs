using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route HttpRouteAction
    /// An object that represents the action to take if a match is determined.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httprouteaction.html
    /// </summary>
    public class HttpRouteAction
    {

        /// <summary>
        /// WeightedTargets
        /// An object that represents the targets that traffic is routed to when a request matches the route.
        /// Required: Yes
        /// Type: List of WeightedTarget
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WeightedTargets")]
        public List<WeightedTarget> WeightedTargets { get; set; }

    }
}
