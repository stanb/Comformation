using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RegexPatternSet
{
    /// <summary>
    /// AWS::WAFv2::RegexPatternSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-regexpatternset.html
    /// </summary>
    public class RegexPatternSetResource : ResourceBase
    {
        public class RegexPatternSetProperties
        {
            /// <summary>
            /// Description
            /// A friendly description of the set. You cannot change the description of a set after you create it.
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
            /// A friendly name of the set. You cannot change the name after you create the set.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^[\w\-]+$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RegularExpressionList
            /// The regular expression patterns in the set.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> RegularExpressionList { get; set; }

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

        public string Type { get; } = "AWS::WAFv2::RegexPatternSet";

        public RegexPatternSetProperties Properties { get; } = new RegexPatternSetProperties();

    }

    public static class RegexPatternSetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
