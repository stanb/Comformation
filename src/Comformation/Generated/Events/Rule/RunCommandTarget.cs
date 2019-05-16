using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule RunCommandTarget
    /// The RunCommandTarget property type specifies information about the Amazon EC2 instances that the Run Command
    /// is sent to. A RunCommandTarget block can include only one key, but the key can specify multiple values.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-runcommandtarget.html
    /// </summary>
    public class RunCommandTarget
    {

        /// <summary>
        /// Key
        /// Can be either tag: tag-key or InstanceIds.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[\p{L}\p{Z}\p{N}_. :/=+\-@]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Values
        /// If Key is tag: tag-key, Values is a list of tag values. If Key is InstanceIds, Values is a list of
        /// Amazon EC2 instance IDs.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
