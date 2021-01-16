using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup TextTransformation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-texttransformation.html
    /// </summary>
    public class TextTransformation
    {

        /// <summary>
        /// Priority
        /// Sets the relative processing order for multiple transformations that are defined for a rule
        /// statement. AWS WAF processes all transformations, from lowest priority to highest, before inspecting
        /// the transformed content. The priorities don&#39;t need to be consecutive, but they must all be
        /// different.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Priority")]
        public Union<int, IntrinsicFunction> Priority { get; set; }

        /// <summary>
        /// Type
        /// You can specify the following transformation types:
        /// CMD_LINE
        /// When you&#39;re concerned that attackers are injecting an operating system command line command and
        /// using unusual formatting to disguise some or all of the command, use this option to perform the
        /// following transformations:
        /// Delete the following characters: \ &quot; &#39; ^ Delete spaces before the following characters: / ( Replace
        /// the following characters with a space: , ; Replace multiple spaces with one space Convert uppercase
        /// letters (A-Z) to lowercase (a-z)
        /// COMPRESS_WHITE_SPACE
        /// Use this option to replace the following characters with a space character (decimal 32):
        /// \f, formfeed, decimal 12 \t, tab, decimal 9 \n, newline, decimal 10 \r, carriage return, decimal 13
        /// \v, vertical tab, decimal 11 non-breaking space, decimal 160
        /// COMPRESS_WHITE_SPACE also replaces multiple spaces with one space.
        /// HTML_ENTITY_DECODE
        /// Use this option to replace HTML-encoded characters with unencoded characters. HTML_ENTITY_DECODE
        /// performs the following operations:
        /// Replaces (ampersand)quot; with &quot; Replaces (ampersand)nbsp; with a non-breaking space, decimal 160
        /// Replaces (ampersand)lt; with a &quot;less than&quot; symbol Replaces (ampersand)gt; with &amp;gt; Replaces
        /// characters that are represented in hexadecimal format, (ampersand)#xhhhh;, with the corresponding
        /// characters Replaces characters that are represented in decimal format, (ampersand)#nnnn;, with the
        /// corresponding characters
        /// LOWERCASE
        /// Use this option to convert uppercase letters (A-Z) to lowercase (a-z).
        /// URL_DECODE
        /// Use this option to decode a URL-encoded value.
        /// NONE
        /// Specify NONE if you don&#39;t want any text transformations.
        /// Required: Yes
        /// Type: String
        /// Allowed values: CMD_LINE | COMPRESS_WHITE_SPACE | HTML_ENTITY_DECODE | LOWERCASE | NONE | URL_DECODE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
