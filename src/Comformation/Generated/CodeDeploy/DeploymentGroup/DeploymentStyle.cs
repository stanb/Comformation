using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS CodeDeploy DeploymentGroup DeploymentStyle
    /// The DeploymentStyle property type specifies the type of AWS CodeDeploy deployment that you want to run and
    /// whether to route deployment traffic behind a load balancer.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deploymentstyle.html
    /// </summary>
    public class DeploymentStyle
    {

        /// <summary>
        /// DeploymentOption
        /// Indicates whether to route deployment traffic behind a load balancer.
        /// Required: No
        /// Type: String
        /// Valid values: WITH_TRAFFIC_CONTROL or WITHOUT_TRAFFIC_CONTROL
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeploymentOption")]
        public Union<string, IntrinsicFunction> DeploymentOption { get; set; }

        /// <summary>
        /// DeploymentType
        /// Indicates whether to run an in-place or blue/green deployment.
        /// 				
        /// AWS CloudFormation supports blue/green deployments on AWS Lambda compute platforms only. For more
        /// information about deploying on a AWS Lambda compute platform, see Deployments on an AWS Lambda
        /// Compute Platform in the AWS CodeDeploy User Guide.
        /// Required: No
        /// Type: String
        /// Valid values: IN_PLACE or BLUE_GREEN
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeploymentType")]
        public Union<string, IntrinsicFunction> DeploymentType { get; set; }

    }
}
