using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Trigger
{
    /// <summary>
    /// AWS Glue Trigger Condition
    /// The Condition property type specifies a condition for an AWS Glue job trigger predicate.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-condition.html
    /// </summary>
    public class Condition
    {

        /// <summary>
        /// State
        /// The state of the condition.
        /// Valid values: SUCCEEDED
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("State")]
        public Union<string, IntrinsicFunction> State { get; set; }

        /// <summary>
        /// LogicalOperator
        /// The logical operator for the condition.
        /// Valid values: EQUALS
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogicalOperator")]
        public Union<string, IntrinsicFunction> LogicalOperator { get; set; }

        /// <summary>
        /// JobName
        /// The name of the associated job. It must match the single-line string pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JobName")]
        public Union<string, IntrinsicFunction> JobName { get; set; }

    }
}
