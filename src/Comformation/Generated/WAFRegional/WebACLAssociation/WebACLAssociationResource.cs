using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.WebACLAssociation
{
    /// <summary>
    /// AWS::WAFRegional::WebACLAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webaclassociation.html
    /// </summary>
    public class WebACLAssociationResource : ResourceBase
    {
        public class WebACLAssociationProperties
        {
            /// <summary>
            /// ResourceArn
            /// The Amazon Resource Name (ARN) of the resource to protect with the web ACL.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceArn { get; set; }

            /// <summary>
            /// WebACLId
            /// A unique identifier (ID) for the web ACL.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> WebACLId { get; set; }

        }

        public string Type { get; } = "AWS::WAFRegional::WebACLAssociation";

        public WebACLAssociationProperties Properties { get; } = new WebACLAssociationProperties();

    }
}
