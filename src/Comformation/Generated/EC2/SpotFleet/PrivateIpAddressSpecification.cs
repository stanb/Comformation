using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon Elastic Compute Cloud SpotFleet NetworkInterfaces PrivateIpAddresses
    /// PrivateIpAddresses is a property of the Amazon Elastic Compute Cloud SpotFleet NetworkInterfaces property that
    /// specifies the private IP address that you want to assign to the network interface.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces-privateipaddresses.html
    /// </summary>
    public class PrivateIpAddressSpecification
    {

        /// <summary>
        /// Primary
        /// Indicates whether the private IP address is the primary private IP address. You can designate only
        /// one IP address as primary.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Primary")]
        public Union<bool, IntrinsicFunction> Primary { get; set; }

        /// <summary>
        /// PrivateIpAddress
        /// The private IP address.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public Union<string, IntrinsicFunction> PrivateIpAddress { get; set; }

    }
}
