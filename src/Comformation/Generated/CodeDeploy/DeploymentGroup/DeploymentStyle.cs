using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup DeploymentStyle
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deploymentstyle.html
    /// </summary>
    public class DeploymentStyle
    {

        /// <summary>
        /// DeploymentOption
        /// Indicates whether to route deployment traffic behind a load balancer.
        /// Note An EC2 Application Load Balancer or Network Load Balancer is required for an Amazon ECS
        /// deployment.
        /// Required: No
        /// Type: String
        /// Allowed values: WITH_TRAFFIC_CONTROL | WITHOUT_TRAFFIC_CONTROL
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeploymentOption")]
        public Union<string, IntrinsicFunction> DeploymentOption { get; set; }

        /// <summary>
        /// DeploymentType
        /// Indicates whether to run an in-place or blue/green deployment.
        /// Required: No
        /// Type: String
        /// Allowed values: BLUE_GREEN | IN_PLACE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeploymentType")]
        public Union<string, IntrinsicFunction> DeploymentType { get; set; }

    }
}
