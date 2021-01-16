using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Fleet
{
    /// <summary>
    /// AWS::GameLift::Fleet IpPermission
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-ec2inboundpermission.html
    /// </summary>
    public class IpPermission
    {

        /// <summary>
        /// FromPort
        /// A starting value for a range of allowed port numbers.
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
        /// A range of allowed IP addresses. This value must be expressed in CIDR notation. Example: &quot;000. 000.
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
        /// The network communication protocol used by the fleet.
        /// Required: Yes
        /// Type: String
        /// Allowed values: TCP | UDP
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// ToPort
        /// An ending value for a range of allowed port numbers. Port numbers are end-inclusive. This value must
        /// be higher than FromPort.
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
