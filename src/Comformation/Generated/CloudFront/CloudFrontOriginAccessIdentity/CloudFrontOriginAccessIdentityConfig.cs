using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.CloudFrontOriginAccessIdentity
{
    /// <summary>
    /// AWS::CloudFront::CloudFrontOriginAccessIdentity CloudFrontOriginAccessIdentityConfig
    /// Origin access identity configuration. Send a GET request to the 					/CloudFront API
    /// version/CloudFront/identity ID/config resource. 		
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cloudfrontoriginaccessidentity-cloudfrontoriginaccessidentityconfig.html
    /// </summary>
    public class CloudFrontOriginAccessIdentityConfig
    {

        /// <summary>
        /// Comment
        /// 		
        /// Any comments you want to include about the origin access identity.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

    }
}
