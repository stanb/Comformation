using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.RegexPatternSet
{
    /// <summary>
    /// AWS::WAFRegional::RegexPatternSet
    /// The RegexPatternSet specifies the regular expression (regex) pattern that you want AWS WAF to search for, such
    /// as B[a@]dB[o0]t. You can then configure AWS WAF to reject those requests.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-regexpatternset.html
    /// </summary>
    public class RegexPatternSetResource : ResourceBase
    {
        public class RegexPatternSetProperties
        {
            /// <summary>
            /// RegexPatternStrings
            /// Specifies the regular expression (regex) patterns that you want AWS WAF to search for, such as
            /// B[a@]dB[o0]t.
            /// Required: Yes
            /// Type: List of String
            /// Maximum: 10
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> RegexPatternStrings { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description of the AWS::WAFRegional::RegexPatternSet. You can&#39;t change Name after
            /// you create a RegexPatternSet.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::WAFRegional::RegexPatternSet";

        public RegexPatternSetProperties Properties { get; } = new RegexPatternSetProperties();

    }
}
