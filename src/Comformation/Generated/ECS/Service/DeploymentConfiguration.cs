using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// Amazon Elastic Container Service Service DeploymentConfiguration
    /// DeploymentConfiguration is a property of the AWS::ECS::Service resource that configures how many tasks run
    /// when you update a running Amazon Elastic Container Service (Amazon ECS) service.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentconfiguration.html
    /// </summary>
    public class DeploymentConfiguration
    {

        /// <summary>
        /// MaximumPercent
        /// The maximum number of tasks, specified as a percentage of the Amazon ECS service&#39;s DesiredCount
        /// value, that can run in a service during a deployment. To calculate the maximum number of tasks,
        /// Amazon ECS uses this formula: the value of DesiredCount * (the value of the MaximumPercent/100),
        /// rounded down to the nearest integer value.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("MaximumPercent")]
        public Union<int, IntrinsicFunction> MaximumPercent { get; set; }

        /// <summary>
        /// MinimumHealthyPercent
        /// The minimum number of tasks, specified as a percentage of the Amazon ECS service&#39;s DesiredCount
        /// value, that must continue to run and remain healthy during a deployment. To calculate the minimum
        /// number of tasks, Amazon ECS uses this formula: the value of DesiredCount * (the value of the
        /// MinimumHealthyPercent/100), rounded up to the nearest integer value.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("MinimumHealthyPercent")]
        public Union<int, IntrinsicFunction> MinimumHealthyPercent { get; set; }

    }
}
