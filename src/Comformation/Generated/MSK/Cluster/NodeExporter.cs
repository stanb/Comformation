using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster NodeExporter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-nodeexporter.html
    /// </summary>
    public class NodeExporter
    {

        /// <summary>
        /// EnabledInBroker
        /// Indicates whether you want to enable or disable the Node Exporter.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnabledInBroker")]
        public Union<bool, IntrinsicFunction> EnabledInBroker { get; set; }

    }
}
