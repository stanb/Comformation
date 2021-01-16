using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL SizeConstraintStatement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-sizeconstraintstatement.html
    /// </summary>
    public class SizeConstraintStatement
    {

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
        /// ComparisonOperator
        /// The operator to use to compare the request part to the size setting.
        /// Required: Yes
        /// Type: String
        /// Allowed values: EQ | GE | GT | LE | LT | NE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComparisonOperator")]
        public Union<string, IntrinsicFunction> ComparisonOperator { get; set; }

        /// <summary>
        /// Size
        /// The size, in byte, to compare to the request part, after any transformations.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Size")]
        public Union<int, IntrinsicFunction> Size { get; set; }

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
