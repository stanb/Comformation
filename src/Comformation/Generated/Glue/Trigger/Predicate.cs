using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Trigger
{
    /// <summary>
    /// AWS::Glue::Trigger Predicate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-predicate.html
    /// </summary>
    public class Predicate
    {

        /// <summary>
        /// Logical
        /// An optional field if only one condition is listed. If multiple conditions are listed, then this
        /// field is required.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Logical")]
        public Union<string, IntrinsicFunction> Logical { get; set; }

        /// <summary>
        /// Conditions
        /// A list of the conditions that determine when the trigger will fire.
        /// Required: No
        /// Type: List of Condition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Conditions")]
        public List<Condition> Conditions { get; set; }

    }
}
