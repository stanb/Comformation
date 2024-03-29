using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Function
{
    /// <summary>
    /// AWS::Lambda::Function VpcConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-vpcconfig.html
    /// </summary>
    public class VpcConfig
    {

        /// <summary>
        /// SecurityGroupIds
        /// A list of VPC security groups IDs.
        /// Required: No
        /// Type: List of String
        /// Maximum: 5
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

        /// <summary>
        /// SubnetIds
        /// A list of VPC subnet IDs.
        /// Required: No
        /// Type: List of String
        /// Maximum: 16
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetIds")]
        public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

    }
}
