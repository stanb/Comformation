using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.WebACL
{
    /// <summary>
    /// AWS::WAFRegional::WebACL
    /// The AWS::WAFRegional::WebACL resource creates an AWS WAF Regional web access control group (ACL) containing
    /// the rules that identify the Amazon CloudFront (CloudFront) web requests that you want to allow, block, or
    /// count. For more information, see CreateWebACL in the AWS WAF Regional API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webacl.html
    /// </summary>
    public class WebACLResource : ResourceBase
    {
        public class WebACLProperties
        {
            /// <summary>
            /// MetricName
            /// A friendly name or description for the Amazon CloudWatch metric of this web ACL. For valid values,
            /// see the MetricName parameter of the CreateWebACL action in the AWS WAF Regional API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MetricName { get; set; }

            /// <summary>
            /// DefaultAction
            /// The action that you want AWS WAF to take when a request doesn&#39;t match the criteria in any of the
            /// rules that are associated with the web ACL.
            /// Required: Yes
            /// Type: AWS WAF Regional WebACL Action
            /// Update requires: No interruption
            /// </summary>
			public Action DefaultAction { get; set; }

            /// <summary>
            /// Rules
            /// The rules to associate with the web ACL and the settings for each rule.
            /// Required: No
            /// Type: List of AWS WAF Regional WebACL Rules
            /// Update requires: No interruption
            /// </summary>
			public List<Rule> Rules { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description of the web ACL.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::WAFRegional::WebACL";

        public WebACLProperties Properties { get; } = new WebACLProperties();

    }
}
