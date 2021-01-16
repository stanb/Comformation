using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.OriginRequestPolicy
{
    /// <summary>
    /// AWS::CloudFront::OriginRequestPolicy HeadersConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-headersconfig.html
    /// </summary>
    public class HeadersConfig
    {

        /// <summary>
        /// HeaderBehavior
        /// 		
        /// Determines whether any HTTP headers are included in requests that CloudFront sends to the origin.
        /// 			Valid values are:
        /// 		
        /// 			 			 			 			 		 				 none – HTTP headers are not included in requests that CloudFront sends to
        /// the 					origin. Even when this field is set to none, any headers that are 					listed in a
        /// CachePolicy are included in origin 					requests. 			 				 whitelist – The HTTP headers that are
        /// listed in the Headers type 					are included in requests that CloudFront sends to the origin. 			
        /// 				 allViewer – All HTTP headers in viewer requests are included in requests that 					CloudFront
        /// sends to the origin. 			 				 allViewerAndWhitelistCloudFront – All HTTP headers in viewer requests
        /// and the 					additional CloudFront headers that are listed in the Headers type are 					included in
        /// requests that CloudFront sends to the origin. The additional headers are 					added by CloudFront.
        /// 			
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: allViewer | allViewerAndWhitelistCloudFront | none | whitelist
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeaderBehavior")]
        public Union<string, IntrinsicFunction> HeaderBehavior { get; set; }

        /// <summary>
        /// Headers
        /// 		
        /// Contains a list of HTTP header names.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Headers")]
        public List<Union<string, IntrinsicFunction>> Headers { get; set; }

    }
}
