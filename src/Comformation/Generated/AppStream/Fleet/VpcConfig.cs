using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.Fleet
{
    /// <summary>
    /// Amazon AppStream 2. 0 Fleet VpcConfig
    /// The VpcConfig property type specifies the VPC configuration information for an Amazon AppStream 2. 0 fleet.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-fleet-vpcconfig.html
    /// </summary>
    public class VpcConfig
    {

        /// <summary>
        /// SubnetIds
        /// The identifiers of the subnets to which a network interface is attached from the fleet instance.
        /// Fleet instances can use one or two subnets.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// The identifiers of the security groups for the fleet.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

    }
}
