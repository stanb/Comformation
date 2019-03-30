using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// CodeDeploy DeploymentGroup TagFilters
    /// TagFilter is a property type of the AWS::CodeDeploy::DeploymentGroup resource that specifies which on-premises
    /// instances to associate with the deployment group. To register on-premise instances with CodeDeploy, see
    /// Configure Existing On-Premises Instances by Using AWS CodeDeploy in the AWS CodeDeploy User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-onpremisesinstancetagfilters.html
    /// </summary>
    public class TagFilter
    {

        /// <summary>
        /// Key
        /// Filter on-premises instances with this key.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Type
        /// The filter type. For example, you can filter on-premises instances by the key, tag value, or both.
        /// For valid values, see EC2TagFilter in the AWS CodeDeploy API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// Filter on-premises instances with this tag value.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
