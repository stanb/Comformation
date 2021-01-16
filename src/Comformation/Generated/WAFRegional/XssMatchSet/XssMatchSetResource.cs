using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.XssMatchSet
{
    /// <summary>
    /// AWS::WAFRegional::XssMatchSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-xssmatchset.html
    /// </summary>
    public class XssMatchSetResource : ResourceBase
    {
        public class XssMatchSetProperties
        {
            /// <summary>
            /// XssMatchTuples
            /// 		
            /// Specifies the parts of web requests that you want to inspect for cross-site scripting attacks.
            /// 	
            /// Required: No
            /// Type: List of XssMatchTuple
            /// Update requires: No interruption
            /// </summary>
            public List<XssMatchTuple> XssMatchTuples { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// The name, if any, of the XssMatchSet.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: . *\S. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::WAFRegional::XssMatchSet";

        public XssMatchSetProperties Properties { get; } = new XssMatchSetProperties();

    }
}
