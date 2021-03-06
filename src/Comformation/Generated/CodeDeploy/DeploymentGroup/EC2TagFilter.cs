using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup EC2TagFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-ec2tagfilter.html
    /// </summary>
    public class EC2TagFilter
    {

        /// <summary>
        /// Key
        /// The tag filter key.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Type
        /// The tag filter type:
        /// KEY_ONLY: Key only. VALUE_ONLY: Value only. KEY_AND_VALUE: Key and value.
        /// Required: No
        /// Type: String
        /// Allowed values: KEY_AND_VALUE | KEY_ONLY | VALUE_ONLY
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// The tag filter value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
