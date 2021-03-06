using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL NotStatementOne
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-notstatementone.html
    /// </summary>
    public class NotStatementOne
    {

        /// <summary>
        /// Statement
        /// Logical NOT statement used to negate the match results of a nested statement.
        /// Required: Yes
        /// Type: StatementTwo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statement")]
        public StatementTwo Statement { get; set; }

    }
}
