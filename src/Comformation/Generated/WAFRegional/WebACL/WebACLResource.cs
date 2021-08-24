using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.WebACL
{
    /// <summary>
    /// AWS::WAFRegional::WebACL
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webacl.html
    /// </summary>
    public class WebACLResource : ResourceBase
    {
        public class WebACLProperties
        {
            /// <summary>
            /// MetricName
            /// Not currently supported by AWS CloudFormation.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MetricName { get; set; }

            /// <summary>
            /// DefaultAction
            /// The action to perform if none of the Rules contained in the WebACL match. The action is specified by
            /// the WafAction object.
            /// Required: Yes
            /// Type: Action
            /// Update requires: No interruption
            /// </summary>
            public Action DefaultAction { get; set; }

            /// <summary>
            /// Rules
            /// 		
            /// An array that contains the action for each Rule in a WebACL, the priority of the Rule, 			and the ID
            /// of the Rule.
            /// 	
            /// Required: No
            /// Type: List of Rule
            /// Update requires: No interruption
            /// </summary>
            public List<Rule> Rules { get; set; }

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
            /// Pattern: . *\S. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::WAFRegional::WebACL";

        public WebACLProperties Properties { get; } = new WebACLProperties();

    }
}
