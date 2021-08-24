using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRuleDestination
{
    /// <summary>
    /// AWS::IoT::TopicRuleDestination VpcDestinationProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-vpcdestinationproperties.html
    /// </summary>
    public class VpcDestinationProperties
    {

        /// <summary>
        /// SubnetIds
        /// The subnet IDs of the VPC destination.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

        /// <summary>
        /// SecurityGroups
        /// The security groups of the VPC destination.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public List<Union<string, IntrinsicFunction>> SecurityGroups { get; set; }

        /// <summary>
        /// VpcId
        /// The ID of the VPC.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VpcId")]
        public Union<string, IntrinsicFunction> VpcId { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of a role that has permission to create and attach to elastic network interfaces (ENIs).
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
