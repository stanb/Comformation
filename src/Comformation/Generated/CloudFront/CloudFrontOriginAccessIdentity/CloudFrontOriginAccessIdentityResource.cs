using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.CloudFrontOriginAccessIdentity
{
    /// <summary>
    /// AWS::CloudFront::CloudFrontOriginAccessIdentity
    /// The request to create a new origin access identity (OAI). An origin access identity is a 			special CloudFront
    /// user that you can associate with Amazon S3 origins, so that you can secure all or 			just some of your Amazon
    /// S3 content. For more information, see 			Restricting Access to Amazon S3 Content by Using an Origin Access
    /// Identity in the 			Amazon CloudFront Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-cloudfrontoriginaccessidentity.html
    /// </summary>
    public class CloudFrontOriginAccessIdentityResource : ResourceBase
    {
        public class CloudFrontOriginAccessIdentityProperties
        {
            /// <summary>
            /// CloudFrontOriginAccessIdentityConfig
            /// 		
            /// The current configuration information for the identity.
            /// 	
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
