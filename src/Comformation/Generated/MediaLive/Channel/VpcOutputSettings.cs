using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel VpcOutputSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-vpcoutputsettings.html
    /// </summary>
    public class VpcOutputSettings
    {

        /// <summary>
        /// PublicAddressAllocationIds
        /// List of public address allocation IDs to associate with ENIs that will be created in Output VPC.
        /// Must specify one for SINGLE_PIPELINE, two for STANDARD channels
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PublicAddressAllocationIds")]
        public List<Union<string, IntrinsicFunction>> PublicAddressAllocationIds { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// A list of up to 5 EC2 VPC security group IDs to attach to the Output VPC network interfaces. If none
        /// are specified then the VPC default security group will be used
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// SubnetIds
        /// A list of VPC subnet IDs from the same VPC. If STANDARD channel, subnet IDs must be mapped to two
        /// unique availability zones (AZ).
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

    }
}
