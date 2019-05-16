using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution GeoRestriction
    /// A complex type that controls the countries in which your content is distributed. CloudFront 			determines the
    /// location of your users using MaxMind GeoIP databases.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-georestriction.html
    /// </summary>
    public class GeoRestriction
    {

        /// <summary>
        /// Locations
        /// 		
        /// A complex type that contains a Location element for each country in which 			you want CloudFront
        /// either to distribute your content (whitelist) or not distribute 			your content (blacklist).
        /// 		
        /// The Location element is a two-letter, uppercase country code for a country 			that you want to
        /// include in your blacklist or whitelist. Include one 				Location element for each country.
        /// 		
        /// CloudFront and MaxMind both use ISO 3166 country codes. For the 			current list of countries and the
        /// corresponding codes, see ISO 3166-1-alpha-2 			code on the International Organization for
        /// Standardization website. You 			can also refer to the country list on the CloudFront console, which
        /// includes both country names and 			codes.
        /// 	
        /// Required: Conditional
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Locations")]
        public List<Union<string, IntrinsicFunction>> Locations { get; set; }

        /// <summary>
        /// RestrictionType
        /// 		
        /// The method that you want to use to restrict distribution of your content by 			country:
        /// 		
        /// 			 			 			 		 				 none: No geo restriction is enabled, meaning access to content is not
        /// 					restricted by client geo location. 			 				 blacklist: The Location elements specify the
        /// countries in 					which you don&#39;t want CloudFront to distribute your content. 			 				 whitelist:
        /// The Location elements specify the countries in 					which you want CloudFront to distribute your
        /// content. 			
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed Values: blacklist | none | whitelist
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RestrictionType")]
        public Union<string, IntrinsicFunction> RestrictionType { get; set; }

    }
}
