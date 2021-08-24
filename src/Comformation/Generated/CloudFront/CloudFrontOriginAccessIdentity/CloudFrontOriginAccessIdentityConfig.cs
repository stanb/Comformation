using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.CloudFrontOriginAccessIdentity
{
    /// <summary>
    /// AWS::CloudFront::CloudFrontOriginAccessIdentity CloudFrontOriginAccessIdentityConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cloudfrontoriginaccessidentity-cloudfrontoriginaccessidentityconfig.html
    /// </summary>
    public class CloudFrontOriginAccessIdentityConfig
    {

        /// <summary>
        /// Comment
        /// 		
        /// A comment to describe the origin access identity. The comment cannot be longer 			than 128
        /// characters.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

    }
}
