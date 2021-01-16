using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL OrStatementOne
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-orstatementone.html
    /// </summary>
    public class OrStatementOne
    {

        /// <summary>
        /// Statements
        /// Logical OR statement used in statement nesting.
        /// Required: Yes
        /// Type: List of StatementTwo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statements")]
        public List<StatementTwo> Statements { get; set; }

    }
}
