using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.StackSet
{
    /// <summary>
    /// AWS::CloudFormation::StackSet StackInstances
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-stackinstances.html
    /// </summary>
    public class StackInstances
    {

        /// <summary>
        /// DeploymentTargets
        /// The AWS OrganizationalUnitIds or Accounts for which to create stack instances in the specified
        /// Regions.
        /// Required: Yes
        /// Type: DeploymentTargets
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeploymentTargets")]
        public DeploymentTargets DeploymentTargets { get; set; }

        /// <summary>
        /// Regions
        /// The names of one or more Regions where you want to create stack instances using the specified AWS
        /// accounts.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Regions")]
        public List<Union<string, IntrinsicFunction>> Regions { get; set; }

        /// <summary>
        /// ParameterOverrides
        /// A list of stack set parameters whose values you want to override in the selected stack instances.
        /// Required: No
        /// Type: List of Parameter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParameterOverrides")]
        public List<Parameter> ParameterOverrides { get; set; }

    }
}
