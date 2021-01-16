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
        /// Provide a JSON list of 2 subnet IDs by name. These must be private subnets, in the same VPC, in two
        /// different availability zones.
        /// Required: No
        /// Type: SubnetList
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SubnetIds")]
        public SubnetList SubnetIds { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// A JSON list of 1 or more security group IDs, by name, that are in the same VPC as the subnets.
        /// Required: No
        /// Type: SecurityGroupList
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public SecurityGroupList SecurityGroupIds { get; set; }

    }
}
