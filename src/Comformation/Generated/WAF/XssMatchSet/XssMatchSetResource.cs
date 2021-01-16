using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.XssMatchSet
{
    /// <summary>
    /// AWS::WAF::XssMatchSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-xssmatchset.html
    /// </summary>
    public class XssMatchSetResource : ResourceBase
    {
        public class XssMatchSetProperties
        {
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

            /// <summary>
            /// XssMatchTuples
            /// 		
            /// Specifies the parts of web requests that you want to inspect for cross-site scripting attacks.
            /// 	
            /// Required: Yes
            /// Type: List of XssMatchTuple
            /// Update requires: No interruption
            /// </summary>
            public List<XssMatchTuple> XssMatchTuples { get; set; }

        }

        public string Type { get; } = "AWS::WAF::XssMatchSet";

        public XssMatchSetProperties Properties { get; } = new XssMatchSetProperties();

    }
}
