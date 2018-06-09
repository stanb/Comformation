using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Fleet
{
    /// <summary>
    /// Amazon GameLift Fleet EC2InboundPermission
    /// EC2InboundPermission is a property of the AWS::GameLift::Fleet resource that specifies the traffic that is
    /// permitted to access your game servers in an Amazon GameLift (GameLift) fleet.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-ec2inboundpermission.html
    /// </summary>
    public class IpPermission
    {

        /// <summary>
        /// FromPort
        /// The starting value for a range of allowed port numbers. This value must be lower than the ToPort
        /// value.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("FromPort")]
        public Union<int, IntrinsicFunction> FromPort { get; set; }

        /// <summary>
        /// IpRange
        /// The range of allowed IP addresses in CIDR notation.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("IpRange")]
        public Union<string, IntrinsicFunction> IpRange { get; set; }

        /// <summary>
        /// Protocol
        /// The network communication protocol that is used by the fleet. For valid values, see the IpPermission
        /// data type in the Amazon GameLift API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// ToPort
        /// The ending value for a range of allowed port numbers. This value must be higher than the FromPort
        /// value.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("ToPort")]
        public Union<int, IntrinsicFunction> ToPort { get; set; }

    }
}
