using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.RecordSetGroup
{
    /// <summary>
    /// Route&#160;53 Record Set GeoLocation Property
    /// The GeoLocation property is part of the AWS::Route53::RecordSet resource that describes how Route&#160;53 responds
    /// to DNS queries based on the geographic location of the query. This property is not compatible with the
    /// Regionproperty.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-recordset-geolocation.html
    /// </summary>
    public class GeoLocation
    {

        /// <summary>
        /// ContinentCode
        /// All DNS queries from the continent that you specified are routed to this resource record set. If you
        /// specify this property, omit the CountryCode and SubdivisionCode properties.
        /// For valid values, see the ContinentCode element in the Amazon Route&#160;53 API Reference.
        /// Type: String
        /// Required: Conditional. You must specify this or the CountryCode property.
        /// </summary>
        [JsonProperty("ContinentCode")]
        public Union<string, IntrinsicFunction> ContinentCode { get; set; }

        /// <summary>
        /// CountryCode
        /// All DNS queries from the country that you specified are routed to this resource record set. If you
        /// specify this property, omit the ContinentCode property.
        /// For valid values, see the CountryCode element in the Amazon Route&#160;53 API Reference.
        /// Type: String
        /// Required: Conditional. You must specify this or the ContinentCode property.
        /// </summary>
        [JsonProperty("CountryCode")]
        public Union<string, IntrinsicFunction> CountryCode { get; set; }

        /// <summary>
        /// SubdivisionCode
        /// If you specified US for the country code, you can specify a state in the United States. All DNS
        /// queries from the state that you specified are routed to this resource record set. If you specify
        /// this property, you must specify US for the CountryCode and omit the ContinentCode property.
        /// For valid values, see the SubdivisionCode element in the Amazon Route&#160;53 API Reference.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("SubdivisionCode")]
        public Union<string, IntrinsicFunction> SubdivisionCode { get; set; }

    }
}
