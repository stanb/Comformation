using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution Restrictions
    /// A complex type that identifies ways in which you want to restrict distribution of your 			content.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-restrictions.html
    /// </summary>
    public class Restrictions
    {

        /// <summary>
        /// GeoRestriction
        /// 		
        /// A complex type that controls the countries in which your content is distributed. CloudFront
        /// 			determines the location of your users using MaxMind GeoIP databases.
        /// 	
        /// Required: Yes
        /// Type: GeoRestriction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GeoRestriction")]
        public GeoRestriction GeoRestriction { get; set; }

    }
}
