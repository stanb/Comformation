using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.WebACLAssociation
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webaclassociation.html
    /// </summary>
    public class WebACLAssociationResource : ResourceBase
    {
        public class WebACLAssociationProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webaclassociation.html#cfn-wafregional-webaclassociation-resourcearn
            /// </summary>
			public Union<string, IntrinsicFunction> ResourceArn { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webaclassociation.html#cfn-wafregional-webaclassociation-webaclid
            /// </summary>
			public Union<string, IntrinsicFunction> WebACLId { get; set; }

        }
    
        public string Type { get; } = "AWS::WAFRegional::WebACLAssociation";
        
        public WebACLAssociationProperties Properties { get; } = new WebACLAssociationProperties();
    }
}
