using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.Instance
{
    /// <summary>
    /// AWS::EC2::NetworkInterface PrivateIpAddressSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-network-interface-privateipspec.html
    /// </summary>
    public class PrivateIpAddressSpecification
    {

        /// <summary>
        /// Primary
        /// Sets the private IP address as the primary private address. You can set only one primary private IP
        /// address. If you don&#39;t specify a primary private IP address, Amazon EC2 automatically assigns a
        /// primary private IP address.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Primary")]
        public Union<bool, IntrinsicFunction> Primary { get; set; }

        /// <summary>
        /// PrivateIpAddress
        /// The private IP address of the network interface.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public Union<string, IntrinsicFunction> PrivateIpAddress { get; set; }

    }
}
