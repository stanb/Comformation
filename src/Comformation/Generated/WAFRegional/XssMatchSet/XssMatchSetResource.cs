using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.XssMatchSet
{
    /// <summary>
    /// AWS::WAFRegional::XssMatchSet
    /// The AWS::WAFRegional::XssMatchSet resource specifies the parts of web requests that you want AWS WAF to
    /// inspect for cross-site scripting attacks and the name of the header to inspect. For more information, see
    /// XssMatchSet in the AWS WAF Regional API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-xssmatchset.html
    /// </summary>
    public class XssMatchSetResource : ResourceBase
    {
        public class XssMatchSetProperties
        {
            /// <summary>
            /// XssMatchTuples
            /// The parts of web requests that you want to inspect for cross-site scripting attacks.
            /// Required: No
            /// Type: List of AWS WAF Regional XssMatchSet XssMatchTuple
            /// Update requires: No interruption
            /// </summary>
			public List<XssMatchTuple> XssMatchTuples { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description for the XssMatchSet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::WAFRegional::XssMatchSet";

        public XssMatchSetProperties Properties { get; } = new XssMatchSetProperties();

    }
}
