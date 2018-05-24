using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.RecordSet
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html
    /// </summary>
    public class GeoLocation
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-continentcode
        /// </summary>
        [JsonProperty("ContinentCode")]
        public Union<string, IntrinsicFunction> ContinentCode { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-countrycode
        /// </summary>
        [JsonProperty("CountryCode")]
        public Union<string, IntrinsicFunction> CountryCode { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html#cfn-route53-recordset-geolocation-subdivisioncode
        /// </summary>
        [JsonProperty("SubdivisionCode")]
        public Union<string, IntrinsicFunction> SubdivisionCode { get; set; }

    }
}
