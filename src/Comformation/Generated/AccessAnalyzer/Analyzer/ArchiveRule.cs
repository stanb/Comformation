using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AccessAnalyzer.Analyzer
{
    /// <summary>
    /// AWS::AccessAnalyzer::Analyzer ArchiveRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-archiverule.html
    /// </summary>
    public class ArchiveRule
    {

        /// <summary>
        /// Filter
        /// The criteria for the rule.
        /// Required: Yes
        /// Type: List of Filter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Filter")]
        public List<Filter> Filter { get; set; }

        /// <summary>
        /// RuleName
        /// The name of the archive rule.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleName")]
        public Union<string, IntrinsicFunction> RuleName { get; set; }

    }
}
