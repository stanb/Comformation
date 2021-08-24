using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup BlueInstanceTerminationOption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-blueinstanceterminationoption.html
    /// </summary>
    public class BlueInstanceTerminationOption
    {

        /// <summary>
        /// Action
        /// The action to take on instances in the original environment after a successful blue/green
        /// deployment.
        /// TERMINATE: Instances are terminated after a specified wait time. KEEP_ALIVE: Instances are left
        /// running after they are deregistered from the load balancer and removed from the deployment group.
        /// Required: No
        /// Type: String
        /// Allowed values: KEEP_ALIVE | TERMINATE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public Union<string, IntrinsicFunction> Action { get; set; }

        /// <summary>
        /// TerminationWaitTimeInMinutes
        /// For an Amazon EC2 deployment, the number of minutes to wait after a successful blue/green deployment
        /// before terminating instances from the original environment.
        /// For an Amazon ECS deployment, the number of minutes before deleting the original (blue) task set.
        /// During an Amazon ECS deployment, CodeDeploy shifts traffic from the original (blue) task set to a
        /// replacement (green) task set.
        /// The maximum setting is 2880 minutes (2 days).
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TerminationWaitTimeInMinutes")]
        public Union<int, IntrinsicFunction> TerminationWaitTimeInMinutes { get; set; }

    }
}
