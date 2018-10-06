using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.SqlInjectionMatchSet
{
    /// <summary>
    /// AWS WAF Regional SqlInjectionMatchSet SqlInjectionMatchTuples
    /// SqlInjectionMatchTuples is a property of the AWS::WAFRegional::SqlInjectionMatchSet resource that specifies
    /// the parts of web requests that AWS WAF inspects for SQL code.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-sqlinjectionmatchtuples.html
    /// </summary>
    public class SqlInjectionMatchTuple
    {

        /// <summary>
        /// TextTransformation
        /// Specifies how AWS WAF processes the FieldToMatch property before inspecting a request for a match.
        /// Note Text transformations eliminate some of the unusual formatting that attackers use in web
        /// requests in an effort to bypass AWS WAF. If you specify a transformation, AWS WAF transforms the
        /// target string value before inspecting a web request for a match. For valid values, see the
        /// TextTransformation content for the SqlInjectionMatchTuple data type in the AWS WAF Regional API
        /// Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("TextTransformation")]
        public Union<string, IntrinsicFunction> TextTransformation { get; set; }

        /// <summary>
        /// FieldToMatch
        /// The part of a web request that you want AWS WAF to search, such as a specific header or a query
        /// string.
        /// Required: Yes
        /// Type: AWS WAF Regional ByteMatchSet ByteMatchTuples FieldToMatch
        /// </summary>
        [JsonProperty("FieldToMatch")]
        public FieldToMatch FieldToMatch { get; set; }

    }
}
