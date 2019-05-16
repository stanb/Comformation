using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet PrivateIpAddressSpecification
    /// Describes a secondary private IPv4 address for a network interface.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces-privateipaddresses.html
    /// </summary>
    public class PrivateIpAddressSpecification
    {

        /// <summary>
        /// Primary
        /// Indicates whether the private IPv4 address is the primary private IPv4 address. Only one IPv4
        /// address can be designated as primary.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Primary")]
        public Union<bool, IntrinsicFunction> Primary { get; set; }

        /// <summary>
        /// PrivateIpAddress
        /// The private IPv4 addresses.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public Union<string, IntrinsicFunction> PrivateIpAddress { get; set; }

    }
}
