using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS CodeDeploy DeploymentGroup LoadBalancerInfo
    /// The LoadBalancerInfo property type specifies information about the load balancer or target group used for an
    /// AWS CodeDeploy deployment group. For more information, see Integrating AWS CodeDeploy with Elastic Load
    /// Balancing in the AWS CodeDeploy User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-loadbalancerinfo.html
    /// </summary>
    public class LoadBalancerInfo
    {

        /// <summary>
        /// ElbInfoList
        /// Information about the Elastic Load Balancing load balancer to use in the deployment.
        /// Conditional: You must specify either ElbInfoList or TargetGroupInfoList, but not both.
        /// Required: No
        /// Type: List of AWS CodeDeploy DeploymentGroup ELBInfo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ElbInfoList")]
        public List<ELBInfo> ElbInfoList { get; set; }

        /// <summary>
        /// TargetGroupInfoList
        /// information about the target groups to use in the deployment. Instances are registered as targets in
        /// a target group, and traffic is routed to the target group.
        /// Conditional: You must specify either ElbInfoList or TargetGroupInfoList, but not both.
        /// Required: No
        /// Type: List of AWS CodeDeploy DeploymentGroup TargetGroupInfo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetGroupInfoList")]
        public List<TargetGroupInfo> TargetGroupInfoList { get; set; }

    }
}
