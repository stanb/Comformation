using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster OpenMonitoring
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-openmonitoring.html
    /// </summary>
    public class OpenMonitoring
    {

        /// <summary>
        /// Prometheus
        /// Prometheus exporter settings.
        /// Required: Yes
        /// Type: Prometheus
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prometheus")]
        public Prometheus Prometheus { get; set; }

    }
}
