using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.StackSet
{
    /// <summary>
    /// AWS::CloudFormation::StackSet AutoDeployment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-autodeployment.html
    /// </summary>
    public class AutoDeployment
    {

        /// <summary>
        /// Enabled
        /// If set to true, StackSets automatically deploys additional stack instances to AWS Organizations
        /// accounts that are added to a target organization or organizational unit (OU) in the specified
        /// Regions. If an account is removed from a target organization or OU, StackSets deletes stack
        /// instances from the account in the specified Regions.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// RetainStacksOnAccountRemoval
        /// If set to true, stack resources are retained when an account is removed from a target organization
        /// or OU. If set to false, stack resources are deleted. Specify only if Enabled is set to True.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetainStacksOnAccountRemoval")]
        public Union<bool, IntrinsicFunction> RetainStacksOnAccountRemoval { get; set; }

    }
}
