using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule EcsParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html
    /// </summary>
    public class EcsParameters
    {

        /// <summary>
        /// Group
        /// Specifies an ECS task group for the task. The maximum length is 255 characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Group")]
        public Union<string, IntrinsicFunction> Group { get; set; }

        /// <summary>
        /// LaunchType
        /// Specifies the launch type on which your task is running. The launch type that you specify here must
        /// match one of the launch type (compatibilities) of the target task. The FARGATE value is supported
        /// only in the Regions where AWS Fargate witt Amazon ECS is supported. For more information, see AWS
        /// Fargate on Amazon ECS in the Amazon Elastic Container Service Developer Guide.
        /// Required: No
        /// Type: String
        /// Allowed values: EC2 | FARGATE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchType")]
        public Union<string, IntrinsicFunction> LaunchType { get; set; }

        /// <summary>
        /// NetworkConfiguration
        /// Use this structure if the Amazon ECS task uses the awsvpc network mode. This structure specifies the
        /// VPC subnets and security groups associated with the task, and whether a public IP address is to be
        /// used. This structure is required if LaunchType is FARGATE because the awsvpc mode is required for
        /// Fargate tasks.
        /// If you specify NetworkConfiguration when the target ECS task does not use the awsvpc network mode,
        /// the task fails.
        /// Required: No
        /// Type: NetworkConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkConfiguration")]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// PlatformVersion
        /// Specifies the platform version for the task. Specify only the numeric portion of the platform
        /// version, such as 1. 1. 0.
        /// This structure is used only if LaunchType is FARGATE. For more information about valid platform
        /// versions, see AWS Fargate Platform Versions in the Amazon Elastic Container Service Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PlatformVersion")]
        public Union<string, IntrinsicFunction> PlatformVersion { get; set; }

        /// <summary>
        /// TaskCount
        /// The number of tasks to create based on TaskDefinition. The default is 1.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TaskCount")]
        public Union<int, IntrinsicFunction> TaskCount { get; set; }

        /// <summary>
        /// TaskDefinitionArn
        /// The ARN of the task definition to use if the event target is an Amazon ECS task.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1600
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TaskDefinitionArn")]
        public Union<string, IntrinsicFunction> TaskDefinitionArn { get; set; }

    }
}
