using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL ByteMatchStatement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-bytematchstatement.html
    /// </summary>
    public class ByteMatchStatement
    {

        /// <summary>
        /// SearchString
        /// A string value that you want AWS WAF to search for. AWS WAF searches only in the part of web
        /// requests that you designate for inspection in FieldToMatch. The maximum length of the value is 50
        /// bytes. For alphabetic characters A-Z and a-z, the value is case sensitive.
        /// Don&#39;t encode this string. Provide the value that you want AWS WAF to search for. AWS CloudFormation
        /// automatically base64 encodes the value for you.
        /// For example, suppose the value of Type is HEADER and the value of Data is User-Agent. If you want to
        /// search the User-Agent header for the value BadBot, you provide the string BadBot in the value of
        /// SearchString.
        /// You must specify either SearchString or SearchStringBase64 in a ByteMatchStatement.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SearchString")]
        public Union<string, IntrinsicFunction> SearchString { get; set; }

        /// <summary>
        /// SearchStringBase64
        /// String to search for in a web request component, base64-encoded. If you don&#39;t want to encode the
        /// string, specify the unencoded value in SearchString instead.
        /// You must specify either SearchString or SearchStringBase64 in a ByteMatchStatement.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SearchStringBase64")]
        public Union<string, IntrinsicFunction> SearchStringBase64 { get; set; }

        /// <summary>
        /// FieldToMatch
        /// The part of a web request that you want AWS WAF to inspect. For more information, see FieldToMatch.
        /// Required: Yes
        /// Type: FieldToMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldToMatch")]
        public FieldToMatch FieldToMatch { get; set; }

        /// <summary>
        /// TextTransformations
        /// Text transformations eliminate some of the unusual formatting that attackers use in web requests in
        /// an effort to bypass detection. If you specify one or more transformations in a rule statement, AWS
        /// WAF performs all transformations on the content identified by FieldToMatch, starting from the lowest
        /// priority setting, before inspecting the content for a match.
        /// Required: Yes
        /// Type: List of TextTransformation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TextTransformations")]
        public List<TextTransformation> TextTransformations { get; set; }

        /// <summary>
        /// PositionalConstraint
        /// The area within the portion of a web request that you want AWS WAF to search for SearchString. Valid
        /// values include the following:
        /// CONTAINS
        /// The specified part of the web request must include the value of SearchString, but the location
        /// doesn&#39;t matter.
        /// CONTAINS_WORD
        /// The specified part of the web request must include the value of SearchString, and SearchString must
        /// contain only alphanumeric characters or underscore (A-Z, a-z, 0-9, or _). In addition, SearchString
        /// must be a word, which means that both of the following are true:
        /// SearchString is at the beginning of the specified part of the web request or is preceded by a
        /// character other than an alphanumeric character or underscore (_). Examples include the value of a
        /// header and ;BadBot. SearchString is at the end of the specified part of the web request or is
        /// followed by a character other than an alphanumeric character or underscore (_), for example, BadBot;
        /// and -BadBot;.
        /// EXACTLY
        /// The value of the specified part of the web request must exactly match the value of SearchString.
        /// STARTS_WITH
        /// The value of SearchString must appear at the beginning of the specified part of the web request.
        /// ENDS_WITH
        /// The value of SearchString must appear at the end of the specified part of the web request.
        /// Required: Yes
        /// Type: String
        /// Allowed values: CONTAINS | CONTAINS_WORD | ENDS_WITH | EXACTLY | STARTS_WITH
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PositionalConstraint")]
        public Union<string, IntrinsicFunction> PositionalConstraint { get; set; }

    }
}
