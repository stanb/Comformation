using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.SizeConstraintSet
{
    /// <summary>
    /// AWS WAF SizeConstraintSet SizeConstraint
    /// SizeConstraint is a property of the AWS::WAF::SizeConstraintSet resource that specifies a size constraint and
    /// which part of a web request that you want AWS WAF to constrain.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sizeconstraintset-sizeconstraint.html
    /// </summary>
    public class SizeConstraint
    {

        /// <summary>
        /// ComparisonOperator
        /// The type of comparison that you want AWS WAF to perform. AWS WAF uses this value in combination with
        /// the Size and FieldToMatch property values to check if the size constraint is a match. For more
        /// information and valid values, see the ComparisonOperator content for the SizeConstraint data type in
        /// the AWS WAF API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("ComparisonOperator")]
        public Union<string, IntrinsicFunction> ComparisonOperator { get; set; }

        /// <summary>
        /// FieldToMatch
        /// The part of a web request that you want AWS WAF to search, such as a specific header or a query
        /// string.
        /// Required: Yes
        /// Type: AWS WAF SizeConstraintSet SizeConstraint FieldToMatch
        /// </summary>
        [JsonProperty("FieldToMatch")]
        public Union<FieldToMatch, IntrinsicFunction> FieldToMatch { get; set; }

        /// <summary>
        /// Size
        /// The size in bytes that you want AWS WAF to compare against the size of the specified FieldToMatch.
        /// AWS WAF uses Size in combination with the ComparisonOperator and FieldToMatch property values to
        /// check if the size constraint of a web request is a match. For more information and valid values, see
        /// the Size content for the SizeConstraint data type in the AWS WAF API Reference.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("Size")]
        public Union<int, IntrinsicFunction> Size { get; set; }

        /// <summary>
        /// TextTransformation
        /// Specifies how AWS WAF processes the FieldToMatch property before inspecting a request for a match.
        /// Text transformations eliminate some of the unusual formatting that attackers use in web requests in
        /// an effort to bypass AWS WAF. If you specify a transformation, AWS WAF transforms the FieldToMatch
        /// before inspecting a web request for a match.
        /// For example, AWS WAF can replace white space characters (such as \t and \n) with a single space. For
        /// valid values, see the TextTransformation content for the SizeConstraint data type in the AWS WAF API
        /// Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("TextTransformation")]
        public Union<string, IntrinsicFunction> TextTransformation { get; set; }

    }
}
