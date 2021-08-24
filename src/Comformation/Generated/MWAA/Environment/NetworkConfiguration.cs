using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MWAA.Environment
{
    /// <summary>
    /// AWS::MWAA::Environment NetworkConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-networkconfiguration.html
    /// </summary>
    public class NetworkConfiguration
    {

        /// <summary>
        /// SubnetIds
        /// A list of subnet IDs. Required to create an environment. Must be private subnets in two different
        /// availability zones. A subnet must be attached to the same VPC as the security group. To learn more,
        /// see About networking on Amazon MWAA.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// A list of one or more security group IDs. Accepts up to 5 security group IDs. A security group must
        /// be attached to the same VPC as the subnets. To learn more, see Security in your VPC on Amazon MWAA.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

    }
}
