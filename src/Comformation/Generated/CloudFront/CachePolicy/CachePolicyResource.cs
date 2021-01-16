using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.CachePolicy
{
    /// <summary>
    /// AWS::CloudFront::CachePolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-cachepolicy.html
    /// </summary>
    public class CachePolicyResource : ResourceBase
    {
        public class CachePolicyProperties
        {
            /// <summary>
            /// CachePolicyConfig
            /// The cache policy configuration.
            /// Required: Yes
            /// Type: CachePolicyConfig
            /// Update requires: No interruption
            /// </summary>
            public CachePolicyConfig CachePolicyConfig { get; set; }

        }

        public string Type { get; } = "AWS::CloudFront::CachePolicy";

        public CachePolicyProperties Properties { get; } = new CachePolicyProperties();

    }

    public static class CachePolicyAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastModifiedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastModifiedTime");
    }
}
