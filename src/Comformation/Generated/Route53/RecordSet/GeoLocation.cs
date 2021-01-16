using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.RecordSet
{
    /// <summary>
    /// AWS::Route53::RecordSetGroup GeoLocation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html
    /// </summary>
    public class GeoLocation
    {

        /// <summary>
        /// ContinentCode
        /// 		
        /// For geolocation resource record sets, a two-letter abbreviation that identifies a continent. Route
        /// 53 supports the following continent codes:
        /// 		
        /// 			 			 			 			 			 			 			 		 AF: Africa AN: Antarctica AS: Asia EU: Europe OC: Oceania NA: North
        /// America SA: South America
        /// 		
        /// Constraint: Specifying ContinentCode with either CountryCode or SubdivisionCode returns an
        /// 			InvalidInput error.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 2
        /// Maximum: 2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContinentCode")]
        public Union<string, IntrinsicFunction> ContinentCode { get; set; }

        /// <summary>
        /// CountryCode
        /// 		
        /// For geolocation resource record sets, the two-letter code for a country.
        /// 		
        /// Route 53 uses the two-letter country codes that are specified in 			ISO standard 3166-1 alpha-2.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CountryCode")]
        public Union<string, IntrinsicFunction> CountryCode { get; set; }

        /// <summary>
        /// SubdivisionCode
        /// 		
        /// For geolocation resource record sets, the two-letter code for a state of the United States. 			Route
        /// 53 doesn&#39;t support any other values for SubdivisionCode. For a list of state abbreviations, see
        /// 			Appendix B: Two–Letter State and Possession Abbreviations 			on the United States Postal Service
        /// website.
        /// 		
        /// If you specify subdivisioncode, you must also specify US for CountryCode.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubdivisionCode")]
        public Union<string, IntrinsicFunction> SubdivisionCode { get; set; }

    }
}
