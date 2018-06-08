using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.XssMatchSet
{
    /// <summary>
    /// AWS WAF XssMatchSet XssMatchTuple
    /// XssMatchTuple is a property of the AWS::WAF::XssMatchSet resource that specifies the part of a web request
    /// that you want AWS WAF to inspect for cross-site scripting attacks.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-xssmatchset-xssmatchtuple.html
    /// </summary>
    public class XssMatchTuple
    {

        /// <summary>
        /// FieldToMatch
        /// The part of a web request that you want AWS WAF to search, such as a specific header or a query
        /// string.
        /// Required: Yes
        /// Type: AWS WAF XssMatchSet XssMatchTuple FieldToMatch
        /// </summary>
        [JsonProperty("FieldToMatch")]
        public Union<FieldToMatch, IntrinsicFunction> FieldToMatch { get; set; }

        /// <summary>
        /// TextTransformation
        /// Specifies how AWS WAF processes the FieldToMatch property before inspecting a request for a match.
        /// Text transformations eliminate some of the unusual formatting that attackers use in web requests in
        /// an effort to bypass AWS WAF. If you specify a transformation, AWS WAF transforms the FieldToMatch
        /// parameter before inspecting a web request for a match.
        /// For example, AWS WAF can replace white space characters (such as \t and \n) with a single space. For
        /// valid values, see the TextTransformation content for the XssMatchTuple data type in the AWS WAF API
        /// Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("TextTransformation")]
        public Union<string, IntrinsicFunction> TextTransformation { get; set; }

    }
}
