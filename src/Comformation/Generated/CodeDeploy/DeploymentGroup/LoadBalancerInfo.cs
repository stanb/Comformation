using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup LoadBalancerInfo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-loadbalancerinfo.html
    /// </summary>
    public class LoadBalancerInfo
    {

        /// <summary>
        /// ElbInfoList
        /// An array that contains information about the load balancer to use for load balancing in a
        /// deployment. In Elastic Load Balancing, load balancers are used with Classic Load Balancers.
        /// Note Adding more than one load balancer to the array is not supported.
        /// Required: No
        /// Type: List of ELBInfo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ElbInfoList")]
        public List<ELBInfo> ElbInfoList { get; set; }

        /// <summary>
        /// TargetGroupInfoList
        /// An array that contains information about the target group to use for load balancing in a deployment.
        /// In Elastic Load Balancing, target groups are used with Application Load Balancers.
        /// Note Adding more than one target group to the array is not supported.
        /// Required: Conditional
        /// Type: List of TargetGroupInfo
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetGroupInfoList")]
        public List<TargetGroupInfo> TargetGroupInfoList { get; set; }

    }
}
