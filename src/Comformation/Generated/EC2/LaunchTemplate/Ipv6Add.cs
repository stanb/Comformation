using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate Ipv6Add
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ipv6add.html
    /// </summary>
    public class Ipv6Add
    {

        /// <summary>
        /// Ipv6Address
        /// One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet. You can&#39;t use
        /// this option if you&#39;re specifying a number of IPv6 addresses.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ipv6Address")]
        public Union<string, IntrinsicFunction> Ipv6Address { get; set; }

    }
}
