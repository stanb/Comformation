using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Connection
{
    /// <summary>
    /// AWS::Glue::Connection PhysicalConnectionRequirements
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-physicalconnectionrequirements.html
    /// </summary>
    public class PhysicalConnectionRequirements
    {

        /// <summary>
        /// AvailabilityZone
        /// The connection&#39;s Availability Zone. This field is redundant because the specified subnet implies the
        /// Availability Zone to be used. Currently the field must be populated, but it will be deprecated in
        /// the future.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

        /// <summary>
        /// SecurityGroupIdList
        /// The security group ID list used by the connection.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIdList")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIdList { get; set; }

        /// <summary>
        /// SubnetId
        /// The subnet ID used by the connection.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetId")]
        public Union<string, IntrinsicFunction> SubnetId { get; set; }

    }
}
