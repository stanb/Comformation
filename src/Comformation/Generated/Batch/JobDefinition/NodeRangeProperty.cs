using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition NodeRangeProperty
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-noderangeproperty.html
    /// </summary>
    public class NodeRangeProperty
    {

        /// <summary>
        /// Container
        /// The container details for the node range.
        /// Required: No
        /// Type: ContainerProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Container")]
        public ContainerProperties Container { get; set; }

        /// <summary>
        /// TargetNodes
        /// The range of nodes, using node index values. A range of 0:3 indicates nodes with index values of 0
        /// through 3. If the starting range value is omitted (:n), then 0 is used to start the range. If the
        /// ending range value is omitted (n:), then the highest possible node index is used to end the range.
        /// Your accumulative node ranges must account for all nodes (0:n). You can nest node ranges, for
        /// example 0:10 and 4:5, in which case the 4:5 range properties override the 0:10 properties.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetNodes")]
        public Union<string, IntrinsicFunction> TargetNodes { get; set; }

    }
}
