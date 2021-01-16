using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL NotStatementTwo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-notstatementtwo.html
    /// </summary>
    public class NotStatementTwo
    {

        /// <summary>
        /// Statement
        /// Logical NOT statement used to negate the match results of a nested statement.
        /// Required: Yes
        /// Type: StatementThree
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statement")]
        public StatementThree Statement { get; set; }

    }
}
