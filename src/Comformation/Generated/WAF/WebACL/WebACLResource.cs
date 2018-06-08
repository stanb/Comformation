using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.WebACL
{
    /// <summary>
    /// AWS::WAF::WebACL
    /// The AWS::WAF::WebACL resource creates an AWS WAF web access control group (ACL) containing the rules that
    /// identify the Amazon CloudFront (CloudFront) web requests that you want to allow, block, or count. For more
    /// information, see CreateWebACL in the AWS WAF API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-webacl.html
    /// </summary>
    public class WebACLResource : ResourceBase
    {
        public class WebACLProperties
        {
            /// <summary>
            /// DefaultAction
            /// The action that you want AWS WAF to take when a request doesn't match the criteria in any of the
            /// rules that are associated with the web ACL.
            /// Required: Yes
            /// Type: AWS WAF WebACL Action
            /// Update requires: No interruption
            /// </summary>
			public Union<WafAction, IntrinsicFunction> DefaultAction { get; set; }

            /// <summary>
            /// MetricName
            /// A friendly name or description for the Amazon CloudWatch metric of this web ACL. For valid values,
            /// see the MetricName parameter of the CreateWebACL action in the AWS WAF API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MetricName { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description of the web ACL.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Rules
            /// The rules to associate with the web ACL and the settings for each rule.
            /// Required: No
            /// Type: List of AWS WAF WebACL Rules
            /// Update requires: No interruption
            /// </summary>
			public Union<List<ActivatedRule>, IntrinsicFunction> Rules { get; set; }

        }
    
        public string Type { get; } = "AWS::WAF::WebACL";
        
        public WebACLProperties Properties { get; } = new WebACLProperties();
    }
}
