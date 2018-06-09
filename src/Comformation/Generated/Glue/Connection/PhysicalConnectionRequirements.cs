using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Connection
{
    /// <summary>
    /// AWS Glue Connection PhysicalConnectionRequirements
    /// The PhysicalConnectionRequirements property type specifies the physical connection requirements that are
    /// needed to make an AWS Glue connection, such as VPC and SecurityGroup.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-physicalconnectionrequirements.html
    /// </summary>
    public class PhysicalConnectionRequirements
    {

        /// <summary>
        /// AvailabilityZone
        /// The connection&#39;s Availability Zone. It must match the single-line string pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

        /// <summary>
        /// SecurityGroupIdList
        /// A list of UTF-8 strings that specify the security group IDs that are used by the connection.
        /// Required: Yes
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIdList")]
        public Union<List<string>, IntrinsicFunction> SecurityGroupIdList { get; set; }

        /// <summary>
        /// SubnetId
        /// The subnet ID that&#39;s used by the connection. It must match the single-line string pattern:
        /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\t]*
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetId")]
        public Union<string, IntrinsicFunction> SubnetId { get; set; }

    }
}
