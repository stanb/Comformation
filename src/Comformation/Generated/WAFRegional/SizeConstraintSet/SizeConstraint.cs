using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.SizeConstraintSet
{
    /// <summary>
    /// AWS::WAFRegional::SizeConstraintSet SizeConstraint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html
    /// </summary>
    public class SizeConstraint
    {

        /// <summary>
        /// ComparisonOperator
        /// The type of comparison you want AWS WAF to perform. AWS WAF uses this in combination with the
        /// provided Size and FieldToMatch 			to build an expression in the form of &quot;Size ComparisonOperator
        /// size in bytes of FieldToMatch&quot;. If that expression 			is true, the SizeConstraint is considered to
        /// match.
        /// 		
        /// EQ: Used to test if the Size is equal to the size of the FieldToMatch
        /// 		
        /// NE: Used to test if the Size is not equal to the size of the FieldToMatch
        /// 		
        /// LE: Used to test if the Size is less than or equal to the size of the FieldToMatch
        /// 		
        /// LT: Used to test if the Size is strictly less than the size of the FieldToMatch
        /// 		
        /// GE: Used to test if the Size is greater than or equal to the size of the FieldToMatch
        /// 		
        /// GT: Used to test if the Size is strictly greater than the size of the FieldToMatch
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: EQ | GE | GT | LE | LT | NE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComparisonOperator")]
        public Union<string, IntrinsicFunction> ComparisonOperator { get; set; }

        /// <summary>
        /// Size
        /// The size in bytes that you want AWS WAF to compare against the size of the specified FieldToMatch.
        /// AWS WAF uses this in combination 			with ComparisonOperator and FieldToMatch to build an expression
        /// in the form of &quot;Size ComparisonOperator size 			in bytes of FieldToMatch&quot;. If that expression is
        /// true, the SizeConstraint is considered to match.
        /// 		
        /// Valid values for size are 0 - 21474836480 bytes (0 - 20 GB).
        /// 		
        /// If you specify URI for the value of Type, the / in the URI path that you specify counts as one
        /// character. 			For example, the URI /logo. jpg is nine characters long.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Size")]
        public Union<int, IntrinsicFunction> Size { get; set; }

        /// <summary>
        /// TextTransformation
        /// Text transformations eliminate some of the unusual formatting that attackers use in web requests in
        /// an effort to bypass AWS WAF. If you specify a transformation, AWS WAF performs the transformation on
        /// FieldToMatch before inspecting a request for a match.
        /// You can only specify a single type of TextTransformation.
        /// 			 		
        /// Note that if you choose BODY for the value of Type, you must choose NONE for TextTransformation
        /// 			because the API Gateway API or Application Load Balancer forward only the first 8192 bytes for
        /// inspection.
        /// 		 		
        /// NONE
        /// 		
        /// Specify NONE if you don&#39;t want to perform any text transformations.
        /// 		 		
        /// CMD_LINE
        /// 		
        /// When you&#39;re concerned that attackers are injecting an operating system command line command and
        /// using unusual formatting to disguise some or all of the command, use this option to perform the
        /// following transformations:
        /// 		
        /// 			 			 			 			 			 		 Delete the following characters: \ &quot; &#39; ^ Delete spaces before the following
        /// characters: / ( Replace the following characters with a space: , ; Replace multiple spaces with one
        /// space Convert uppercase letters (A-Z) to lowercase (a-z)
        /// 		 		
        /// COMPRESS_WHITE_SPACE
        /// 		
        /// Use this option to replace the following characters with a space character (decimal 32):
        /// 		
        /// 			 			 			 			 			 			 		 \f, formfeed, decimal 12 \t, tab, decimal 9 \n, newline, decimal 10 \r,
        /// carriage return, decimal 13 \v, vertical tab, decimal 11 non-breaking space, decimal 160
        /// 		
        /// COMPRESS_WHITE_SPACE also replaces multiple spaces with one space.
        /// 		 		
        /// HTML_ENTITY_DECODE
        /// 		
        /// Use this option to replace HTML-encoded characters with unencoded characters. HTML_ENTITY_DECODE
        /// performs 			the following operations:
        /// 		
        /// 			 			 			 			 			 			 		 Replaces (ampersand)quot; with &quot; Replaces (ampersand)nbsp; with a
        /// non-breaking space, decimal 160 Replaces (ampersand)lt; with a &quot;less than&quot; symbol Replaces
        /// (ampersand)gt; with &amp;gt; Replaces characters that are represented in hexadecimal format,
        /// (ampersand)#xhhhh;, with the corresponding 				characters Replaces characters that are represented
        /// in decimal format, (ampersand)#nnnn;, with the corresponding 				characters
        /// 		 		
        /// LOWERCASE
        /// 		
        /// Use this option to convert uppercase letters (A-Z) to lowercase (a-z).
        /// 		 		
        /// URL_DECODE
        /// 		
        /// Use this option to decode a URL-encoded value.
        /// 		 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: CMD_LINE | COMPRESS_WHITE_SPACE | HTML_ENTITY_DECODE | LOWERCASE | NONE | URL_DECODE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TextTransformation")]
        public Union<string, IntrinsicFunction> TextTransformation { get; set; }

        /// <summary>
        /// FieldToMatch
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: FieldToMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldToMatch")]
        public FieldToMatch FieldToMatch { get; set; }

    }
}
