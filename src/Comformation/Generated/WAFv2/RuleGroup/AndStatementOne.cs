using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup AndStatementOne
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-andstatementone.html
    /// </summary>
    public class AndStatementOne
    {

        /// <summary>
        /// Statements
        /// Logical AND statements used in statement nesting.
        /// Required: Yes
        /// Type: List of StatementTwo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statements")]
        public List<StatementTwo> Statements { get; set; }

    }
}
