using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS CodeDeploy DeploymentGroup TargetGroupInfo
    /// The TargetGroupInfo property type specifies information about a target group in Elastic Load Balancing to use
    /// in a deployment. Instances are registered as targets in a target group, and traffic is routed to the target
    /// group. For more information, see TargetGroupInfo in the AWS CodeDeploy API Reference
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-targetgroupinfo.html
    /// </summary>
    public class TargetGroupInfo
    {

        /// <summary>
        /// Name
        /// For blue/green deployments, the name of the target group that instances in the original environment
        /// are deregistered from, and instances in the replacement environment registered with. For in-place
        /// deployments, the name of the target group that instances are deregistered from, so they are not
        /// serving traffic during a deployment, and then re-registered with after the deployment completes. No
        /// duplicates allowed.
        /// Note AWS CloudFormation supports blue/green deployments on AWS Lambda compute platforms only.
        /// This value can't exceed 32 characters, so you should use the Name property of the target group, or
        /// the TargetGroupName attribute with the Fn::GetAtt intrinsic function, as shown in the following
        /// example. Don't use the group's Amazon Resource Name (ARN) or TargetGroupFullName attribute.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
