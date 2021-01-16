using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.Task
{
    /// <summary>
    /// AWS::DataSync::Task FilterRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-filterrule.html
    /// </summary>
    public class FilterRule
    {

        /// <summary>
        /// FilterType
        /// The type of filter rule to apply. AWS DataSync only supports the SIMPLE_PATTERN rule type.
        /// Required: No
        /// Type: String
        /// Allowed values: SIMPLE_PATTERN
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FilterType")]
        public Union<string, IntrinsicFunction> FilterType { get; set; }

        /// <summary>
        /// Value
        /// A single filter string that consists of the patterns to include or exclude. The patterns are
        /// delimited by &quot;|&quot; (that is, a pipe), for example: /folder1|/folder2
        /// Required: No
        /// Type: String
        /// Maximum: 409600
        /// Pattern: ^[^\x00]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
