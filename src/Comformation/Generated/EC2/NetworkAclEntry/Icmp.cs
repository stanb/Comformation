using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkAclEntry
{
    /// <summary>
    /// EC2 NetworkAclEntry Icmp
    /// The Icmp property is an embedded property of the AWS::EC2::NetworkAclEntry type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkaclentry-icmp.html
    /// </summary>
    public class Icmp
    {

        /// <summary>
        /// Code
        /// The Internet Control Message Protocol (ICMP) code. You can use -1 to specify all ICMP codes for the
        /// given ICMP type.
        /// Required: Conditional. Required if you specify 1 (ICMP) for the CreateNetworkAclEntry protocol
        /// parameter.
        /// Type: Integer
        /// </summary>
        [JsonProperty("Code")]
        public Union<int, IntrinsicFunction> Code { get; set; }

        /// <summary>
        /// Type
        /// The Internet Control Message Protocol (ICMP) type. You can use -1 to specify all ICMP types.
        /// Required: Conditional. Required if you specify 1 (ICMP) for the CreateNetworkAclEntry protocol
        /// parameter.
        /// Type: Integer
        /// </summary>
        [JsonProperty("Type")]
        public Union<int, IntrinsicFunction> Type { get; set; }

    }
}
