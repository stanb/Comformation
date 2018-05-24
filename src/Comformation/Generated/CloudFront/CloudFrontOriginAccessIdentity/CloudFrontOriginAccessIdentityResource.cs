using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.CloudFrontOriginAccessIdentity
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-cloudfrontoriginaccessidentity.html
    /// </summary>
    public class CloudFrontOriginAccessIdentityResource : ResourceBase
    {
        public class CloudFrontOriginAccessIdentityProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-cloudfrontoriginaccessidentity.html#cfn-cloudfront-cloudfrontoriginaccessidentity-cloudfrontoriginaccessidentityconfig
            /// </summary>
			public Union<CloudFrontOriginAccessIdentityConfig, IntrinsicFunction> CloudFrontOriginAccessIdentityConfig { get; set; }

        }
    
        public string Type { get; } = "AWS::CloudFront::CloudFrontOriginAccessIdentity";
        
        public CloudFrontOriginAccessIdentityProperties Properties { get; } = new CloudFrontOriginAccessIdentityProperties();
    }

	public static class CloudFrontOriginAccessIdentityAttributes
	{
        public static readonly ResourceAttribute<string> S3CanonicalUserId = new ResourceAttribute<string>("S3CanonicalUserId");
	}
}
