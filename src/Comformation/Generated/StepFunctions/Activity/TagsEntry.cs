using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.StepFunctions.Activity
{
    /// <summary>
    /// AWS::StepFunctions::Activity TagsEntry
    /// The TagsEntry property specifies tags to identify an activity.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-activity-tagsentry.html
    /// </summary>
    public class TagsEntry
    {

        /// <summary>
        /// Value
        /// The value for a key-value pair in a tag entry.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Key
        /// The key for a key-value pair in a tag entry.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
