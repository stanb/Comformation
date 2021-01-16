using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.Route
{
    /// <summary>
    /// AWS::AppMesh::Route TcpTimeout
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcptimeout.html
    /// </summary>
    public class TcpTimeout
    {

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
