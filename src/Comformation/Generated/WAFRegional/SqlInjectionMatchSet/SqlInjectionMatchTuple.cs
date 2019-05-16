using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.SqlInjectionMatchSet
{
    /// <summary>
    /// AWS::WAFRegional::SqlInjectionMatchSet SqlInjectionMatchTuple
    /// Specifies the part of a web request that you want AWS WAF to inspect for snippets of malicious SQL code and,
    /// if you want AWS WAF to inspect a header, the name of the header.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-sqlinjectionmatchtuple.html
    /// </summary>
    public class SqlInjectionMatchTuple
    {

        /// <summary>
        /// TextTransformation
        /// 		
        /// Text transformations eliminate some of the unusual formatting that attackers use in web requests in
        /// an effort to bypass AWS WAF. 			If you specify a transformation, AWS WAF performs the transformation
        /// on FieldToMatch before inspecting a request for a match.
        /// You can only specify a single type of TextTransformation.
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
        /// NONE
        /// 		
        /// Specify NONE if you don&#39;t want to perform any text transformations.
        /// 		 	
        /// Required: Yes
        /// Type: String
        /// Allowed Values: CMD_LINE | COMPRESS_WHITE_SPACE | HTML_ENTITY_DECODE | LOWERCASE | NONE | URL_DECODE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TextTransformation")]
        public Union<string, IntrinsicFunction> TextTransformation { get; set; }

        /// <summary>
        /// FieldToMatch
        /// Specifies where in a web request to look for snippets of malicious SQL code.
        /// Required: Yes
        /// Type: FieldToMatch
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldToMatch")]
        public FieldToMatch FieldToMatch { get; set; }

    }
}
