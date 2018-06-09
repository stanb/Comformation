using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.SqlInjectionMatchSet
{
    /// <summary>
    /// AWS WAF Regional SqlInjectionMatchSet SqlInjectionMatchTuples FieldToMatch
    /// FieldToMatch is a property of the AWS WAF Regional ByteMatchSet ByteMatchTuples property that specifies the
    /// part of a web request that you want AWS WAF to search, such as a specific header or a query string.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-sqlinjectionmatchtuples-fieldtomatch.html
    /// </summary>
    public class FieldToMatch
    {

        /// <summary>
        /// Type
        /// The part of the web request in which AWS WAF searches for the target string. For valid values, see
        /// FieldToMatch in the AWS WAF Regional API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Data
        /// If you specify HEADER for the Type property, the name of the header that AWS WAF searches for, such
        /// as User-Agent or Referer. If you specify any other value for the Type property, do not specify this
        /// property.
        /// Required: Conditional
        /// Type: String
        /// </summary>
        [JsonProperty("Data")]
        public Union<string, IntrinsicFunction> Data { get; set; }

    }
}
