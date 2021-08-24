using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup OrStatement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-orstatement.html
    /// </summary>
    public class OrStatement
    {

        /// <summary>
        /// Statements
        /// The statements to combine with OR logic. You can use any statements that can be nested.
        /// Required: Yes
        /// Type: List of Statement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statements")]
        public List<Statement> Statements { get; set; }

    }
}
