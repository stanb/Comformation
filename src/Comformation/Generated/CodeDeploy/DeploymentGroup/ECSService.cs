using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup ECSService
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-ecsservice.html
    /// </summary>
    public class ECSService
    {

        /// <summary>
        /// ClusterName
        /// The name of the cluster that the Amazon ECS service is associated with.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClusterName")]
        public Union<string, IntrinsicFunction> ClusterName { get; set; }

        /// <summary>
        /// ServiceName
        /// The name of the target Amazon ECS service.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceName")]
        public Union<string, IntrinsicFunction> ServiceName { get; set; }

    }
}
