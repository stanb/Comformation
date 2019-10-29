using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.TrafficMirrorFilterRule
{
    /// <summary>
    /// AWS::EC2::TrafficMirrorFilterRule TrafficMirrorPortRange
    /// Describes the Traffic Mirror port range.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-trafficmirrorfilterrule-trafficmirrorportrange.html
    /// </summary>
    public class TrafficMirrorPortRange
    {

        /// <summary>
        /// FromPort
        /// The start of the Traffic Mirror port range. This applies to the TCP and UDP protocols.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FromPort")]
        public Union<int, IntrinsicFunction> FromPort { get; set; }

        /// <summary>
        /// ToPort
        /// The end of the Traffic Mirror port range. This applies to the TCP and UDP protocols.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ToPort")]
        public Union<int, IntrinsicFunction> ToPort { get; set; }

    }
}
