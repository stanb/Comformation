using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.DataflowEndpointGroup
{
    /// <summary>
    /// AWS::GroundStation::DataflowEndpointGroup SecurityDetails
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-securitydetails.html
    /// </summary>
    public class SecurityDetails
    {

        /// <summary>
        /// SubnetIds
        /// The subnet Ids of the security details, such as subnet-12345678.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// The security group Ids of the security role, such as sg-1234567890abcdef0.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of a role which Ground Station has permission to assume, such as
        /// arn:aws:iam::1234567890:role/DataDeliveryServiceRole.
        /// Ground Station will assume this role and create an ENI in your VPC on the specified subnet upon
        /// creation of a dataflow endpoint group. This ENI is used as the ingress/egress point for data
        /// streamed during a satellite contact.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
