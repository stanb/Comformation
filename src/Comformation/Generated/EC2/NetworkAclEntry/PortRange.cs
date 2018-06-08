using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkAclEntry
{
    /// <summary>
    /// EC2 NetworkAclEntry PortRange
    /// The PortRange property is an embedded property of the AWS::EC2::NetworkAclEntry type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkaclentry-portrange.html
    /// </summary>
    public class PortRange
    {

        /// <summary>
        /// From
        /// The first port in the range.
        /// Required: Conditional. Required if you specify 6 (TCP) or 17 (UDP) for the protocol parameter.
        /// Type: Integer
        /// </summary>
        [JsonProperty("From")]
        public Union<int, IntrinsicFunction> From { get; set; }

        /// <summary>
        /// To
        /// The last port in the range.
        /// Required: Conditional. Required if you specify 6 (TCP) or 17 (UDP) for the protocol parameter.
        /// Type: Integer
        /// </summary>
        [JsonProperty("To")]
        public Union<int, IntrinsicFunction> To { get; set; }

    }
}
