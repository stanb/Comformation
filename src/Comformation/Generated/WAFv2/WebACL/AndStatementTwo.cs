using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL AndStatementTwo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-andstatementtwo.html
    /// </summary>
    public class AndStatementTwo
    {

        /// <summary>
        /// Statements
        /// Logical AND statements used in statement nesting.
        /// Required: Yes
        /// Type: List of StatementThree
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statements")]
        public List<StatementThree> Statements { get; set; }

    }
}
