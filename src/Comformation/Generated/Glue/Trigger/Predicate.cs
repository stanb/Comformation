using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Trigger
{
    /// <summary>
    /// AWS Glue Trigger Predicate
    /// The Predicate property type specifies the predicate of an AWS Glue job trigger, which determines when it
    /// fires.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-predicate.html
    /// </summary>
    public class Predicate
    {

        /// <summary>
        /// Logical
        /// The logical operator for the predicate.
        /// Valid values: AND
        /// Required: Optional field if only one condition is listed. If multiple conditions are listed, then
        /// this field is required.
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Logical")]
        public Union<string, IntrinsicFunction> Logical { get; set; }

        /// <summary>
        /// Conditions
        /// The conditions that determine when the trigger fires.
        /// Required: No
        /// Type: List of AWS Glue Trigger Condition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Conditions")]
        public Union<List<Condition>, IntrinsicFunction> Conditions { get; set; }

    }
}
