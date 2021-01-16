using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html
    /// </summary>
    public class WebACLResource : ResourceBase
    {
        public class WebACLProperties
        {
            /// <summary>
            /// DefaultAction
            /// The action to perform if none of the Rules contained in the WebACL match.
            /// Required: Yes
            /// Type: DefaultAction
            /// Update requires: No interruption
            /// </summary>
            public DefaultAction DefaultAction { get; set; }

            /// <summary>
            /// Description
            /// A friendly description of the Web ACL. You cannot change the description of a Web ACL after you
            /// create it.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: ^[\w+=:#@/\-,\. ][\w+=:#@/\-,\. \s]+[\w+=:#@/\-,\. ]$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Name
            /// A friendly name of the Web ACL. You cannot change the name of a Web ACL after you create it.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^[\w\-]+$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Scope
            /// Specifies whether this is for an AWS CloudFront distribution or for a regional application. A
            /// regional application can be an Application Load Balancer (ALB), an Amazon API Gateway REST API, or
            /// an AWS AppSync GraphQL API. Valid Values are CLOUDFRONT and REGIONAL.
            /// Note For CLOUDFRONT, you must create your WAFv2 resources in the US East (N. Virginia) Region,
            /// us-east-1.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Scope { get; set; }

            /// <summary>
            /// Rules
            /// The Rule statements used to identify the web requests that you want to allow, block, or count. Each
            /// rule includes one top-level statement that AWS WAF uses to identify matching web requests, and
            /// parameters that govern how AWS WAF handles them.
            /// Required: No
            /// Type: List of Rule
            /// Update requires: No interruption
            /// </summary>
            public List<Rule> Rules { get; set; }

            /// <summary>
            /// VisibilityConfig
            /// Defines and enables Amazon CloudWatch metrics and web request sample collection.
            /// Required: Yes
            /// Type: VisibilityConfig
            /// Update requires: No interruption
            /// </summary>
            public VisibilityConfig VisibilityConfig { get; set; }

            /// <summary>
            /// Tags
            /// Key:value pairs associated with an AWS resource. The key:value pair can be anything you define.
            /// Typically, the tag key represents a category (such as &quot;environment&quot;) and the tag value represents a
            /// specific value within that category (such as &quot;test,&quot; &quot;development,&quot; or &quot;production&quot;). You can add up
            /// to 50 tags to each AWS resource.
            /// Note To modify tags on existing resources, use the AWS WAF console or the APIs. With AWS
            /// CloudFormation, you can only add tags to AWS WAF resources during resource creation.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::WAFv2::WebACL";

        public WebACLProperties Properties { get; } = new WebACLProperties();

    }

    public static class WebACLAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> Capacity = new ResourceAttribute<Union<int, IntrinsicFunction>>("Capacity");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
