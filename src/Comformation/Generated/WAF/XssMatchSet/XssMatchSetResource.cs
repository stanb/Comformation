using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.XssMatchSet
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-xssmatchset.html
    /// </summary>
    public class XssMatchSetResource : ResourceBase
    {
        public class XssMatchSetProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-xssmatchset.html#cfn-waf-xssmatchset-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-xssmatchset.html#cfn-waf-xssmatchset-xssmatchtuples
            /// </summary>
			public Union<List<XssMatchTuple>, IntrinsicFunction> XssMatchTuples { get; set; }

        }
    
        public string Type { get; } = "AWS::WAF::XssMatchSet";
        
        public XssMatchSetProperties Properties { get; } = new XssMatchSetProperties();
    }
}
