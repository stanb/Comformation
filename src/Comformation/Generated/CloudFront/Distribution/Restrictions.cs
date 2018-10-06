using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// CloudFront Distribution Restrictions
    /// Restrictions is a property of the CloudFront Distribution DistributionConfig property type that lets you limit
    /// which viewers can access your content.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-restrictions.html
    /// </summary>
    public class Restrictions
    {

        /// <summary>
        /// GeoRestriction
        /// The countries in which viewers are able to access your content.
        /// Required: Yes
        /// Type: CloudFront Distribution GeoRestriction
        /// </summary>
        [JsonProperty("GeoRestriction")]
        public GeoRestriction GeoRestriction { get; set; }

    }
}
