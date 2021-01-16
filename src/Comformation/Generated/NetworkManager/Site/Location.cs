using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkManager.Site
{
    /// <summary>
    /// AWS::NetworkManager::Site Location
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-site-location.html
    /// </summary>
    public class Location
    {

        /// <summary>
        /// Address
        /// The physical address.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Address")]
        public Union<string, IntrinsicFunction> Address { get; set; }

        /// <summary>
        /// Latitude
        /// The latitude.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Latitude")]
        public Union<string, IntrinsicFunction> Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// The longitude.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Longitude")]
        public Union<string, IntrinsicFunction> Longitude { get; set; }

    }
}
