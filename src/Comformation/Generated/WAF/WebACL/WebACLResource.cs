using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.WebACL
{
    /// <summary>
    /// AWS::WAF::WebACL
    /// Contains the Rules that identify the requests that you want to allow, block, or count. In a WebACL, you also
    /// specify a 			default action (ALLOW or BLOCK), and the action for each Rule that you add to a 			WebACL, for
    /// example, block requests from specified IP addresses or block requests from specified referrers. 			You also
    /// associate the WebACL with a CloudFront distribution to identify the requests that you want AWS WAF to filter.
    /// 			If you add more than one Rule to a WebACL, a request needs to match only one of the specifications 			to be
    /// allowed, blocked, or counted.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-webacl.html
    /// </summary>
    public class WebACLResource : ResourceBase
    {
        public class WebACLProperties
        {
            /// <summary>
            /// DefaultAction
            /// 		
            /// The action to perform if none of the Rules contained in the WebACL match. The action is specified by
            /// the 		 WafAction object.
            /// 	
            /// Required: Yes
            /// Type: WafAction
            /// Update requires: No interruption
            /// </summary>
			public WafAction DefaultAction { get; set; }

            /// <summary>
            /// MetricName
            /// A friendly name or description for the metrics for this WebACL. The name can contain only
            /// alphanumeric characters (A-Z, a-z, 0-9), with maximum length 128 and minimum length one. It can&#39;t
            /// contain whitespace or metric names reserved for AWS WAF, including &quot;All&quot; and &quot;Default_Action. &quot; You
            /// can&#39;t change MetricName after you create the WebACL.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> MetricName { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// A friendly name or description of the WebACL. You can&#39;t change the name of a WebACL after you create
            /// it.
            /// 	 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Rules
            /// 		
            /// An array that contains the action for each Rule in a WebACL, the priority of the Rule, 			and the ID
            /// of the Rule.
            /// 	
            /// Required: No
            /// Type: List of ActivatedRule
            /// Update requires: No interruption
            /// </summary>
			public List<ActivatedRule> Rules { get; set; }

        }

        public string Type { get; } = "AWS::WAF::WebACL";

        public WebACLProperties Properties { get; } = new WebACLProperties();

    }
}
