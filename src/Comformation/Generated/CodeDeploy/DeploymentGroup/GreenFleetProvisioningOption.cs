using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup GreenFleetProvisioningOption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-greenfleetprovisioningoption.html
    /// </summary>
    public class GreenFleetProvisioningOption
    {

        /// <summary>
        /// Action
        /// The method used to add instances to a replacement environment.
        /// DISCOVER_EXISTING: Use instances that already exist or will be created manually.
        /// COPY_AUTO_SCALING_GROUP: Use settings from a specified Auto Scaling group to define and create
        /// instances in a new Auto Scaling group.
        /// Required: No
        /// Type: String
        /// Allowed values: COPY_AUTO_SCALING_GROUP | DISCOVER_EXISTING
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public Union<string, IntrinsicFunction> Action { get; set; }

    }
}
