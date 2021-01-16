using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.InputSecurityGroup
{
    /// <summary>
    /// AWS::MediaLive::InputSecurityGroup InputWhitelistRuleCidr
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-inputsecuritygroup-inputwhitelistrulecidr.html
    /// </summary>
    public class InputWhitelistRuleCidr
    {

        /// <summary>
        /// Cidr
        /// An IPv4 CIDR range to include in this input security group.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Cidr")]
        public Union<string, IntrinsicFunction> Cidr { get; set; }

    }
}
