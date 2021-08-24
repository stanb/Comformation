using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// AWS::ECS::Service DeploymentController
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentcontroller.html
    /// </summary>
    public class DeploymentController
    {

        /// <summary>
        /// Type
        /// The deployment controller type to use. There are three deployment controller types available:
        /// ECS The rolling update (ECS) deployment type involves replacing the current running version of the
        /// container with the latest version. The number of containers Amazon ECS adds or removes from the
        /// service during a rolling update is controlled by adjusting the minimum and maximum number of healthy
        /// tasks allowed during a service deployment, as specified in the DeploymentConfiguration. CODE_DEPLOY
        /// The blue/green (CODE_DEPLOY) deployment type uses the blue/green deployment model powered by AWS
        /// CodeDeploy, which allows you to verify a new deployment of a service before sending production
        /// traffic to it. EXTERNAL The external (EXTERNAL) deployment type enables you to use any third-party
        /// deployment controller for full control over the deployment process for an Amazon ECS service.
        /// Required: No
        /// Type: String
        /// Allowed values: CODE_DEPLOY | ECS | EXTERNAL
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
