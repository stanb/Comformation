using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup OrStatementTwo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-orstatementtwo.html
    /// </summary>
    public class OrStatementTwo
    {

        /// <summary>
        /// Statements
        /// Logical OR statements used in statement nesting.
        /// Required: Yes
        /// Type: List of StatementThree
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statements")]
        public List<StatementThree> Statements { get; set; }

    }
}
