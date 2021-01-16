using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup OrStatementOne
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-orstatementone.html
    /// </summary>
    public class OrStatementOne
    {

        /// <summary>
        /// Statements
        /// Logical OR statements.
        /// Required: Yes
        /// Type: List of StatementTwo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statements")]
        public List<StatementTwo> Statements { get; set; }

    }
}
