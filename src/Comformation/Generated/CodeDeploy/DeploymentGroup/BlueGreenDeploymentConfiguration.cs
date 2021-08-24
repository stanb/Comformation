using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup BlueGreenDeploymentConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-bluegreendeploymentconfiguration.html
    /// </summary>
    public class BlueGreenDeploymentConfiguration
    {

        /// <summary>
        /// DeploymentReadyOption
        /// Information about the action to take when newly provisioned instances are ready to receive traffic
        /// in a blue/green deployment.
        /// Required: No
        /// Type: DeploymentReadyOption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeploymentReadyOption")]
        public DeploymentReadyOption DeploymentReadyOption { get; set; }

        /// <summary>
        /// GreenFleetProvisioningOption
        /// Information about how instances are provisioned for a replacement environment in a blue/green
        /// deployment.
        /// Required: No
        /// Type: GreenFleetProvisioningOption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GreenFleetProvisioningOption")]
        public GreenFleetProvisioningOption GreenFleetProvisioningOption { get; set; }

        /// <summary>
        /// TerminateBlueInstancesOnDeploymentSuccess
        /// Information about whether to terminate instances in the original fleet during a blue/green
        /// deployment.
        /// Required: No
        /// Type: BlueInstanceTerminationOption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TerminateBlueInstancesOnDeploymentSuccess")]
        public BlueInstanceTerminationOption TerminateBlueInstancesOnDeploymentSuccess { get; set; }

    }
}
