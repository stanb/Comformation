using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// Amazon CloudWatch Events Rule RunCommandTarget
    /// The RunCommandTarget property type specifies information about the Amazon EC2 instances that the Run Command
    /// is sent to. A RunCommandTarget block can include only one key, but the key can specify multiple values.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-runcommandtarget.html
    /// </summary>
    public class RunCommandTarget
    {

        /// <summary>
        /// Key
        /// The key, either tag: tag-key or InstanceIds.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Values
        /// A list of tag values or EC2 instance IDs.
        /// Required: Yes
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

    }
}
