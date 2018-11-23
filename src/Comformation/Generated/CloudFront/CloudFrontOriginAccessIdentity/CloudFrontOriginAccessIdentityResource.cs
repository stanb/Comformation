using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.CloudFrontOriginAccessIdentity
{
    /// <summary>
    /// AWS::CloudFront::CloudFrontOriginAccessIdentity
    /// The AWS::CloudFront::CloudFrontOriginAccessIdentity resource specifies the CloudFront origin access identity
    /// to associate with the origin of a CloudFront distribution. For more information, see OriginAccessIdentity in
    /// the Amazon CloudFront API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-cloudfrontoriginaccessidentity.html
    /// </summary>
    public class CloudFrontOriginAccessIdentityResource : ResourceBase
    {
        public class CloudFrontOriginAccessIdentityProperties
        {
            /// <summary>
            /// CloudFrontOriginAccessIdentityConfig
            /// The configuration of the CloudFront origin access identity.
            /// Required: Yes
            /// Type: CloudFrontOriginAccessIdentityConfig
            /// Update requires: No interruption
            /// </summary>
			public CloudFrontOriginAccessIdentityConfig CloudFrontOriginAccessIdentityConfig { get; set; }

        }

        public string Type { get; } = "AWS::CloudFront::CloudFrontOriginAccessIdentity";

        public CloudFrontOriginAccessIdentityProperties Properties { get; } = new CloudFrontOriginAccessIdentityProperties();

    }

	public static class CloudFrontOriginAccessIdentityAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> S3CanonicalUserId = new ResourceAttribute<Union<string, IntrinsicFunction>>("S3CanonicalUserId");
	}
}
