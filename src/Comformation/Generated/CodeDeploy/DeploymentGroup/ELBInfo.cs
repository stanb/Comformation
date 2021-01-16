using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup ELBInfo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-elbinfo.html
    /// </summary>
    public class ELBInfo
    {

        /// <summary>
        /// Name
        /// For blue/green deployments, the name of the load balancer that is used to route traffic from
        /// original instances to replacement instances in a blue/green deployment. For in-place deployments,
        /// the name of the load balancer that instances are deregistered from so they are not serving traffic
        /// during a deployment, and then re-registered with after the deployment is complete.
        /// Note AWS CloudFormation supports blue/green deployments on AWS Lambda compute platforms only.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
