using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Fleet
{
    /// <summary>
    /// AWS::GameLift::Fleet IpPermission
    /// A range of IP addresses and port settings that allow inbound traffic to connect to server processes on Amazon
    /// GameLift. Each game session hosted on a fleet is assigned a unique combination of IP address and port number,
    /// which must fall into the fleet&#39;s allowed ranges. For fleets created with a custom game server, the ranges
    /// reflect the server&#39;s game session assignments. For Realtime Servers fleets, Amazon GameLift automatically
    /// opens two port ranges, one for TCP messaging and one for UDP for use by the Realtime servers.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-ec2inboundpermission.html
    /// </summary>
    public class IpPermission
    {

        /// <summary>
        /// FromPort
        /// Starting value for a range of allowed port numbers.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 60000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FromPort")]
        public Union<int, IntrinsicFunction> FromPort { get; set; }

        /// <summary>
        /// IpRange
        /// Range of allowed IP addresses. This value must be expressed in CIDR notation. Example: &quot;000. 000.
        /// 000. 000/[subnet mask]&quot; or optionally the shortened version &quot;0. 0. 0. 0/[subnet mask]&quot;.
        /// Required: Yes
        /// Type: String
        /// Pattern: [^\s]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IpRange")]
        public Union<string, IntrinsicFunction> IpRange { get; set; }

        /// <summary>
        /// Protocol
        /// Network communication protocol used by the fleet.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: TCP | UDP
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// ToPort
        /// Ending value for a range of allowed port numbers. Port numbers are end-inclusive. This value must be
        /// higher than FromPort.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 60000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ToPort")]
        public Union<int, IntrinsicFunction> ToPort { get; set; }

    }
}
