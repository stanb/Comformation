using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentConfig
{
    /// <summary>
    /// AWS CodeDeploy DeploymentConfig MinimumHealthyHosts
    /// MinimumHealthyHosts is a property of the AWS::CodeDeploy::DeploymentConfig resource that defines how many
    /// instances must remain healthy during an AWS CodeDeploy deployment.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentconfig-minimumhealthyhosts.html
    /// </summary>
    public class MinimumHealthyHosts
    {

        /// <summary>
        /// Type
        /// The type of count to use, such as an absolute value or a percentage of the total number of instances
        /// in the deployment. For valid values, see MinimumHealthyHosts in the AWS CodeDeploy API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// The minimum number of healthy instances.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("Value")]
        public Union<int, IntrinsicFunction> Value { get; set; }

    }
}
