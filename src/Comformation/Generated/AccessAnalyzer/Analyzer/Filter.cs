using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AccessAnalyzer.Analyzer
{
    /// <summary>
    /// AWS::AccessAnalyzer::Analyzer Filter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html
    /// </summary>
    public class Filter
    {

        /// <summary>
        /// Contains
        /// A &quot;contains&quot; condition to match for the rule.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Contains")]
        public List<Union<string, IntrinsicFunction>> Contains { get; set; }

        /// <summary>
        /// Eq
        /// An &quot;equals&quot; condition to match for the rule.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Eq")]
        public List<Union<string, IntrinsicFunction>> Eq { get; set; }

        /// <summary>
        /// Exists
        /// An &quot;exists&quot; condition to match for the rule.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Exists")]
        public Union<bool, IntrinsicFunction> Exists { get; set; }

        /// <summary>
        /// Property
        /// The property used to define the criteria in the filter for the rule.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Property")]
        public Union<string, IntrinsicFunction> Property { get; set; }

        /// <summary>
        /// Neq
        /// A &quot;not equal&quot; condition to match for the rule.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Neq")]
        public List<Union<string, IntrinsicFunction>> Neq { get; set; }

    }
}
