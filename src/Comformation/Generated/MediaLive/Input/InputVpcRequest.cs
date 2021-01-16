using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Input
{
    /// <summary>
    /// AWS::MediaLive::Input InputVpcRequest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputvpcrequest.html
    /// </summary>
    public class InputVpcRequest
    {

        /// <summary>
        /// SecurityGroupIds
        /// The list of up to five VPC security group IDs to attach to the input VPC network interfaces. The
        /// security groups require subnet IDs. If none are specified, MediaLive uses the VPC default security
        /// group.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// SubnetIds
        /// The list of two VPC subnet IDs from the same VPC. You must associate subnet IDs to two unique
        /// Availability Zones.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

    }
}
