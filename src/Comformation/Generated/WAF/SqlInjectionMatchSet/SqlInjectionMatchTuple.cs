using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.SqlInjectionMatchSet
{
    /// <summary>
    /// AWS WAF SqlInjectionMatchSet SqlInjectionMatchTuples
    /// SqlInjectionMatchTuples is a property of the AWS::WAF::SqlInjectionMatchSet resource that specifies the parts
    /// of web requests that AWS WAF inspects for SQL code.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sqlinjectionmatchset-sqlinjectionmatchtuples.html
    /// </summary>
    public class SqlInjectionMatchTuple
    {

        /// <summary>
        /// FieldToMatch
        /// The part of a web request that you want AWS WAF to search, such as a specific header or a query
        /// string.
        /// Required: Yes
        /// Type: AWS WAF ByteMatchSet ByteMatchTuples FieldToMatch
        /// </summary>
        [JsonProperty("FieldToMatch")]
        public Union<FieldToMatch, IntrinsicFunction> FieldToMatch { get; set; }

        /// <summary>
        /// TextTransformation
        /// Text transformations eliminate some of the unusual formatting that attackers use in web requests in
        /// an effort to bypass AWS WAF. If you specify a transformation, AWS WAF transforms the target string
        /// value before inspecting a web request for a match. For valid values, see the TextTransformation
        /// content for the SqlInjectionMatchTuple data type in the AWS WAF API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("TextTransformation")]
        public Union<string, IntrinsicFunction> TextTransformation { get; set; }

    }
}
