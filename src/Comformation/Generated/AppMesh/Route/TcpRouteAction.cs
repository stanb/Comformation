using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS AppMesh Route TcpRouteAction
    /// An object representing the traffic distribution requirements for matched TCP requests.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcprouteaction.html
    /// </summary>
    public class TcpRouteAction
    {

        /// <summary>
        /// WeightedTargets
        /// The targets that traffic is routed to when a request matches the route. You can specify one or more
        /// targets and their relative weights to distribute traffic with.
        /// Required: Yes
        /// Type: List of WeightedTarget
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WeightedTargets")]
        public List<WeightedTarget> WeightedTargets { get; set; }

    }
}
