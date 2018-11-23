using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS Batch JobDefinition NodeProperties
    /// The NodeProperties property type specifies various properties specific to multi-node parallel jobs in a job
    /// definition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-nodeproperties.html
    /// </summary>
    public class NodeProperties
    {

        /// <summary>
        /// MainNode
        /// Specifies the node index for the main node of a multi-node parallel job.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MainNode")]
        public Union<int, IntrinsicFunction> MainNode { get; set; }

        /// <summary>
        /// NodeRangeProperties
        /// A list of node ranges and their properties associated with a multi-node parallel job.
        /// Required: Yes
        /// Type: List of NodeRangeProperty property types
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NodeRangeProperties")]
        public List<NodeRangeProperty> NodeRangeProperties { get; set; }

        /// <summary>
        /// NumNodes
        /// The number of nodes associated with a multi-node parallel job.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NumNodes")]
        public Union<int, IntrinsicFunction> NumNodes { get; set; }

    }
}
