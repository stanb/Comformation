using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup TagFilter
    /// TagFilter is a property type of the AWS::CodeDeploy::DeploymentGroup resource that specifies which on-premises
    /// instances to associate with the deployment group. To register on-premise instances with AWS CodeDeploy, see
    /// Configure Existing On-Premises Instances by Using AWS CodeDeploy in the AWS CodeDeploy User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-tagfilter.html
    /// </summary>
    public class TagFilter
    {

        /// <summary>
        /// Key
        /// The on-premises instance tag filter key.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Type
        /// The on-premises instance tag filter type:
        /// KEY_ONLY: Key only. VALUE_ONLY: Value only. KEY_AND_VALUE: Key and value.
        /// Required: No
        /// Type: String
        /// Allowed Values: KEY_AND_VALUE | KEY_ONLY | VALUE_ONLY
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// The on-premises instance tag filter value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
