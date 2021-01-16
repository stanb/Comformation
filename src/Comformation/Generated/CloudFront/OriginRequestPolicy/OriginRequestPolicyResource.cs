using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.OriginRequestPolicy
{
    /// <summary>
    /// AWS::CloudFront::OriginRequestPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-originrequestpolicy.html
    /// </summary>
    public class OriginRequestPolicyResource : ResourceBase
    {
        public class OriginRequestPolicyProperties
        {
            /// <summary>
            /// OriginRequestPolicyConfig
            /// 		
            /// The origin request policy configuration.
            /// Required: Yes
            /// Type: OriginRequestPolicyConfig
            /// Update requires: No interruption
            /// </summary>
            public OriginRequestPolicyConfig OriginRequestPolicyConfig { get; set; }

        }

        public string Type { get; } = "AWS::CloudFront::OriginRequestPolicy";

        public OriginRequestPolicyProperties Properties { get; } = new OriginRequestPolicyProperties();

    }

    public static class OriginRequestPolicyAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastModifiedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastModifiedTime");
    }
}
