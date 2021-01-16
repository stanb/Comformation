using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster Prometheus
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-prometheus.html
    /// </summary>
    public class Prometheus
    {

        /// <summary>
        /// JmxExporter
        /// Indicates whether you want to enable or disable the JMX Exporter.
        /// Required: No
        /// Type: JmxExporter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JmxExporter")]
        public JmxExporter JmxExporter { get; set; }

        /// <summary>
        /// NodeExporter
        /// Indicates whether you want to enable or disable the Node Exporter.
        /// Required: No
        /// Type: NodeExporter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NodeExporter")]
        public NodeExporter NodeExporter { get; set; }

    }
}
