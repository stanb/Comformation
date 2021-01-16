using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route TcpRoute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcproute.html
    /// </summary>
    public class TcpRoute
    {

        /// <summary>
        /// Action
        /// The action to take if a match is determined.
        /// Required: Yes
        /// Type: TcpRouteAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public TcpRouteAction Action { get; set; }

        /// <summary>
        /// Timeout
        /// An object that represents types of timeouts.
        /// Required: No
        /// Type: TcpTimeout
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Timeout")]
        public TcpTimeout Timeout { get; set; }

    }
}
