using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.CloudFrontOriginAccessIdentity
{
    /// <summary>
    /// Amazon CloudFront CloudFrontOriginAccessIdentity CloudFrontOriginAccessIdentityConfig
    /// The CloudFrontOriginAccessIdentityConfig property type configures the CloudFront origin access identity to
    /// associate with the origin of a CloudFront distribution.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cloudfrontoriginaccessidentity-cloudfrontoriginaccessidentityconfig.html
    /// </summary>
    public class CloudFrontOriginAccessIdentityConfig
    {

        /// <summary>
        /// Comment
        /// A comment to associate with this CloudFront origin access identity.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

    }
}
