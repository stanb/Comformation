using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppMesh.VirtualNode
{
    /// <summary>
    /// AWS::AppMesh::VirtualNode OutlierDetection
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-outlierdetection.html
    /// </summary>
    public class OutlierDetection
    {

        /// <summary>
        /// MaxEjectionPercent
        /// Maximum percentage of hosts in load balancing pool for upstream service that can be ejected. Will
        /// eject at least one host regardless of the value.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxEjectionPercent")]
        public Union<int, IntrinsicFunction> MaxEjectionPercent { get; set; }

        /// <summary>
        /// BaseEjectionDuration
        /// The base amount of time for which a host is ejected.
        /// Required: Yes
        /// Type: Duration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BaseEjectionDuration")]
        public Duration BaseEjectionDuration { get; set; }

        /// <summary>
        /// MaxServerErrors
        /// Number of consecutive 5xx errors required for ejection.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxServerErrors")]
        public Union<int, IntrinsicFunction> MaxServerErrors { get; set; }

        /// <summary>
        /// Interval
        /// The time interval between ejection sweep analysis.
        /// Required: Yes
        /// Type: Duration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Interval")]
        public Duration Interval { get; set; }

    }
}
