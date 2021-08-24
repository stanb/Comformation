using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL NotStatement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-notstatement.html
    /// </summary>
    public class NotStatement
    {

        /// <summary>
        /// Statement
        /// The statement to negate. You can use any statement that can be nested.
        /// Required: Yes
        /// Type: Statement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statement")]
        public Statement Statement { get; set; }

    }
}
