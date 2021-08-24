using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup TCPFlagField
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-tcpflagfield.html
    /// </summary>
    public class TCPFlagField
    {

        /// <summary>
        /// Flags
        /// Used in conjunction with the Masks setting to define the flags that must be set and flags that must
        /// not be set in order for the packet to match. This setting can only specify values that are also
        /// specified in the Masks setting.
        /// For the flags that are specified in the masks setting, the following must be true for the packet to
        /// match:
        /// The ones that are set in this flags setting must be set in the packet. The ones that are not set in
        /// this flags setting must also not be set in the packet.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Flags")]
        public List<Union<string, IntrinsicFunction>> Flags { get; set; }

        /// <summary>
        /// Masks
        /// The set of flags to consider in the inspection. To inspect all flags in the valid values list, leave
        /// this with no setting.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Masks")]
        public List<Union<string, IntrinsicFunction>> Masks { get; set; }

    }
}
