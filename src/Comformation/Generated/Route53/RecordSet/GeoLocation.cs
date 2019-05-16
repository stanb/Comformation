using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.RecordSet
{
    /// <summary>
    /// AWS::Route53::RecordSet GeoLocation
    /// A complex type that contains information about a geographic location.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html
    /// </summary>
    public class GeoLocation
    {

        /// <summary>
        /// ContinentCode
        /// 		
        /// The two-letter code for the continent.
        /// 		
        /// Valid values: AF | AN | AS | EU | OC | NA | SA
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
        /// The two-letter code for the country.
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
        /// The code for the subdivision. Route 53 currently supports only states in the United States.
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
