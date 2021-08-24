using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.IPSet
{
    /// <summary>
    /// AWS::WAFv2::IPSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-ipset.html
    /// </summary>
    public class IPSetResource : ResourceBase
    {
        public class IPSetProperties
        {
            /// <summary>
            /// Description
            /// A description of the IP set that helps with identification.
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
            /// The descriptive name of the IP set. You cannot change the name of an IPSet after you create it.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: ^[\w\-]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Scope
            /// Specifies whether this is for an Amazon CloudFront distribution or for a regional application. A
            /// regional application can be an Application Load Balancer (ALB), an Amazon API Gateway REST API, or
            /// an AWS AppSync GraphQL API. Valid Values are CLOUDFRONT and REGIONAL.
            /// Note For CLOUDFRONT, you must create your WAFv2 resources in the US East (N. Virginia) Region,
            /// us-east-1.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Scope { get; set; }

            /// <summary>
            /// IPAddressVersion
            /// Specify IPV4 or IPV6.
            /// Required: Yes
            /// Type: String
            /// Allowed values: IPV4 | IPV6
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> IPAddressVersion { get; set; }

            /// <summary>
            /// Addresses
            /// Contains an array of strings that specify one or more IP addresses or blocks of IP addresses in
            /// Classless Inter-Domain Routing (CIDR) notation. AWS WAF supports all IPv4 and IPv6 CIDR ranges
            /// except for /0.
            /// Examples:
            /// To configure AWS WAF to allow, block, or count requests that originated from the IP address 192. 0.
            /// 2. 44, specify 192. 0. 2. 44/32. To configure AWS WAF to allow, block, or count requests that
            /// originated from IP addresses from 192. 0. 2. 0 to 192. 0. 2. 255, specify 192. 0. 2. 0/24. To
            /// configure AWS WAF to allow, block, or count requests that originated from the IP address
            /// 1111:0000:0000:0000:0000:0000:0000:0111, specify 1111:0000:0000:0000:0000:0000:0000:0111/128. To
            /// configure AWS WAF to allow, block, or count requests that originated from IP addresses
            /// 1111:0000:0000:0000:0000:0000:0000:0000 to 1111:0000:0000:0000:ffff:ffff:ffff:ffff, specify
            /// 1111:0000:0000:0000:0000:0000:0000:0000/64.
            /// For more information about CIDR notation, see the Wikipedia entry Classless Inter-Domain Routing.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Addresses { get; set; }

            /// <summary>
            /// Tags
            /// Key:value pairs associated with an AWS resource. The key:value pair can be anything you define.
            /// Typically, the tag key represents a category (such as &quot;environment&quot;) and the tag value represents a
            /// specific value within that category (such as &quot;test,&quot; &quot;development,&quot; or &quot;production&quot;). You can add up
            /// to 50 tags to each AWS resource.
            /// Note To modify tags on existing resources, use the AWS WAF APIs or command line interface. With AWS
            /// CloudFormation, you can only add tags to AWS WAF resources during resource creation.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::WAFv2::IPSet";

        public IPSetProperties Properties { get; } = new IPSetProperties();

    }

    public static class IPSetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
