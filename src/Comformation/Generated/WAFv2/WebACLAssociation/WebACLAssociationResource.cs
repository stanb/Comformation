using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACLAssociation
{
    /// <summary>
    /// AWS::WAFv2::WebACLAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webaclassociation.html
    /// </summary>
    public class WebACLAssociationResource : ResourceBase
    {
        public class WebACLAssociationProperties
        {
            /// <summary>
            /// ResourceArn
            /// The Amazon Resource Name (ARN) of the resource to associate with the web ACL.
            /// The ARN must be in one of the following formats:
            /// For an Application Load Balancer:
            /// arn:aws:elasticloadbalancing:region:account-id:loadbalancer/app/load-balancer-name/load-balancer-id
            /// For an Amazon API Gateway REST API: arn:aws:apigateway:region::/restapis/api-id/stages/stage-name
            /// For an AWS AppSync GraphQL API: arn:aws:appsync:region:account-id:apis/ GraphQLApiId
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: . *\S. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceArn { get; set; }

            /// <summary>
            /// WebACLArn
            /// The Amazon Resource Name (ARN) of the web ACL that you want to associate with the resource.
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: . *\S. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> WebACLArn { get; set; }

        }

        public string Type { get; } = "AWS::WAFv2::WebACLAssociation";

        public WebACLAssociationProperties Properties { get; } = new WebACLAssociationProperties();

    }
}
