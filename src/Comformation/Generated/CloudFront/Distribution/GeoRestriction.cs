using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// CloudFront Distribution GeoRestriction
    /// GeoRestriction is a property of the CloudFront Distribution Restrictions property that describes the countries
    /// in which Amazon CloudFront allows viewers to access your content.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-georestriction.html
    /// </summary>
    public class GeoRestriction
    {

        /// <summary>
        /// Locations
        /// The two-letter, uppercase country code for a country that you want to include in your blacklist or
        /// whitelist.
        /// Required: Conditional. Required if you specified blacklist or whitelist for the RestrictionType
        /// property.
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Locations")]
        public Union<List<string>, IntrinsicFunction> Locations { get; set; }

        /// <summary>
        /// RestrictionType
        /// The method to restrict distribution of your content:
        /// blacklist Prevents viewers in the countries that you specified from accessing your content.
        /// whitelist Allows viewers in the countries that you specified to access your content. none No
        /// distribution restrictions by country.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RestrictionType")]
        public Union<string, IntrinsicFunction> RestrictionType { get; set; }

    }
}
