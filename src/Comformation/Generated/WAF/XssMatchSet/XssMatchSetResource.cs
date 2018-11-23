using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.XssMatchSet
{
    /// <summary>
    /// AWS::WAF::XssMatchSet
    /// The AWS::WAF::XssMatchSet resource specifies the parts of web requests that you want AWS WAF to inspect for
    /// cross-site scripting attacks and the name of the header to inspect. For more information, see XssMatchSet in
    /// the AWS WAF API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-xssmatchset.html
    /// </summary>
    public class XssMatchSetResource : ResourceBase
    {
        public class XssMatchSetProperties
        {
            /// <summary>
            /// Name
            /// A friendly name or description for the XssMatchSet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// XssMatchTuples
            /// The parts of web requests that you want to inspect for cross-site scripting attacks.
            /// Required: No
            /// Type: List of AWS WAF XssMatchSet XssMatchTuple
            /// Update requires: No interruption
            /// </summary>
			public List<XssMatchTuple> XssMatchTuples { get; set; }

        }

        public string Type { get; } = "AWS::WAF::XssMatchSet";

        public XssMatchSetProperties Properties { get; } = new XssMatchSetProperties();

    }
}
