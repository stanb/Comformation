using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route HttpTimeout
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httptimeout.html
    /// </summary>
    public class HttpTimeout
    {

        /// <summary>
        /// PerRequest
        /// An object that represents a per request timeout. The default value is 15 seconds. If you set a
        /// higher timeout, then make sure that the higher value is set for each App Mesh resource in a
        /// conversation. For example, if a virtual node backend uses a virtual router provider to route to
        /// another virtual node, then the timeout should be greater than 15 seconds for the source and
        /// destination virtual node and the route.
        /// Required: No
        /// Type: Duration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PerRequest")]
        public Duration PerRequest { get; set; }

        /// <summary>
        /// Idle
        /// An object that represents an idle timeout. An idle timeout bounds the amount of time that a
        /// connection may be idle. The default value is none.
        /// Required: No
        /// Type: Duration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Idle")]
        public Duration Idle { get; set; }

    }
}
