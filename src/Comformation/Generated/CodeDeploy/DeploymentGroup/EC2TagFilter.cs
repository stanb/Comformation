using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// CodeDeploy DeploymentGroup Ec2TagFilters
    /// Ec2TagFilters is a property of the AWS::CodeDeploy::DeploymentGroup resource that specifies which EC2
    /// instances to associate with the deployment group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-ec2tagfilters.html
    /// </summary>
    public class EC2TagFilter
    {

        /// <summary>
        /// Key
        /// Filter instances with this key.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Type
        /// The filter type. For example, you can filter instances by the key, tag value, or both. For valid
        /// values, see EC2TagFilter in the AWS CodeDeploy API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// Filter instances with this tag value.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
