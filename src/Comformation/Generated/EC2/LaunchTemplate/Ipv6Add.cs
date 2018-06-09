using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// Amazon EC2 LaunchTemplate Ipv6Add
    /// The Ipv6Add property type describes an IPv6 address in an Amazon EC2 launch template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ipv6add.html
    /// </summary>
    public class Ipv6Add
    {

        /// <summary>
        /// Ipv6Address
        /// The IPv6 address.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ipv6Address")]
        public Union<string, IntrinsicFunction> Ipv6Address { get; set; }

    }
}
