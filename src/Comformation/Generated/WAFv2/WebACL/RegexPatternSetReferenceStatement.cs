using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL RegexPatternSetReferenceStatement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-regexpatternsetreferencestatement.html
    /// </summary>
    public class RegexPatternSetReferenceStatement
    {

        /// <summary>
        /// Arn
        /// The Amazon Resource Name (ARN) of the regular expression pattern set that this statement references.
        /// Required: Yes
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: . *\S. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// FieldToMatch
        /// The part of a web request that you want AWS WAF to inspect.
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

    }
}
