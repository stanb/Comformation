using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// Amazon EC2 LaunchTemplate PrivateIpAdd
    /// The PrivateIpAdd property type describes a private IPv4 address for a network interface in an Amazon EC2
    /// launch template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-privateipadd.html
    /// </summary>
    public class PrivateIpAdd
    {

        /// <summary>
        /// PrivateIpAddress
        /// The private IPv4 address.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public Union<string, IntrinsicFunction> PrivateIpAddress { get; set; }

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

    }
}
