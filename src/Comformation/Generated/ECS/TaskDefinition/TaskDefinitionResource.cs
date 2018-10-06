using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition
    /// The AWS::ECS::TaskDefinition resource describes the container and volume definitions of an Amazon Elastic
    /// Container Service (Amazon ECS) task. You can specify which Docker images to use, the required resources, and
    /// other configurations related to launching the task definition through an Amazon ECS service or task.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html
    /// </summary>
    public class TaskDefinitionResource : ResourceBase
    {
        public class TaskDefinitionProperties
        {
            /// <summary>
            /// ContainerDefinitions
            /// A list of container definitions in JSON format that describes the containers that make up your task.
            /// Required: Yes
            /// Type: List of Amazon Elastic Container Service TaskDefinition ContainerDefinition
            /// Update requires: Replacement
            /// </summary>
			public List<ContainerDefinition> ContainerDefinitions { get; set; }

            /// <summary>
            /// Cpu
            /// The number of cpu units used by the task. If using the EC2 launch type, this field is optional.
            /// Supported values are between 128 CPU units (0. 125 vCPUs) and 10240 CPU units (10 vCPUs). If you are
            /// using the Fargate launch type, this field is required and you must use one of the following values,
            /// which determines your range of valid values for the memory parameter:
            /// 256 (. 25 vCPU) - Available memory values: 0. 5GB, 1GB, 2GB 512 (. 5 vCPU) - Available memory
            /// values: 1GB, 2GB, 3GB, 4GB 1024 (1 vCPU) - Available memory values: 2GB, 3GB, 4GB, 5GB, 6GB, 7GB,
            /// 8GB 2048 (2 vCPU) - Available memory values: Between 4GB and 16GB in 1GB increments 4096 (4 vCPU) -
            /// Available memory values: Between 8GB and 30GB in 1GB increments
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Cpu { get; set; }

            /// <summary>
            /// ExecutionRoleArn
            /// The Amazon Resource Name (ARN) of the task execution role that containers in this task can assume.
            /// All containers in this task are granted the permissions that are specified in this role.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

            /// <summary>
            /// Family
            /// The name of a family that this task definition is registered to. A family groups multiple versions
            /// of a task definition. Amazon ECS gives the first task definition that you registered to a family a
            /// revision number of 1. Amazon ECS gives sequential revision numbers to each task definition that you
            /// add.
            /// Note To use revision numbers when you update a task definition, specify this property. If you don&#39;t
            /// specify a value, AWS CloudFormation generates a new task definition each time that you update it.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Family { get; set; }

            /// <summary>
            /// Memory
            /// The amount (in MiB) of memory used by the task. If using the EC2 launch type, this field is optional
            /// and any value can be used. If you are using the Fargate launch type, this field is required and you
            /// must use one of the following values, which determines your range of valid values for the cpu
            /// parameter:
            /// 0. 5GB, 1GB, 2GB - Available cpu values: 256 (. 25 vCPU) 1GB, 2GB, 3GB, 4GB - Available cpu values:
            /// 512 (. 5 vCPU) 2GB, 3GB, 4GB, 5GB, 6GB, 7GB, 8GB - Available cpu values: 1024 (1 vCPU) Between 4GB
            /// and 16GB in 1GB increments - Available cpu values: 2048 (2 vCPU) Between 8GB and 30GB in 1GB
            /// increments - Available cpu values: 4096 (4 vCPU)
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Memory { get; set; }

            /// <summary>
            /// NetworkMode
            /// The Docker networking mode to use for the containers in the task, such as none, bridge, or host. For
            /// information about network modes, see NetworkMode in the Task Definition Parameters topic in the
            /// Amazon Elastic Container Service Developer Guide.
            /// For Fargate launch types, you can specify awsvpc only. The none, bridge, or host option won&#39;t work
            /// for Fargate launch types.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkMode { get; set; }

            /// <summary>
            /// PlacementConstraints
            /// The placement constraints for the tasks in the service.
            /// Required: No
            /// Type: Amazon Elastic Container Service Service PlacementConstraint
            /// Update requires: Replacement
            /// </summary>
			public List<TaskDefinitionPlacementConstraint> PlacementConstraints { get; set; }

            /// <summary>
            /// RequiresCompatibilities
            /// The launch type the task requires. If no value is specified, it will default to EC2. Valid values
            /// include EC2 and FARGATE.
            /// Required: No
            /// Type: List of Strings
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> RequiresCompatibilities { get; set; }

            /// <summary>
            /// TaskRoleArn
            /// The Amazon Resource Name (ARN) of an AWS Identity and Access Management (IAM) role that grants
            /// containers in the task permission to call AWS APIs on your behalf. For more information, see IAM
            /// Roles for Tasks in the Amazon Elastic Container Service Developer Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TaskRoleArn { get; set; }

            /// <summary>
            /// Volumes
            /// A list of volume definitions in JSON format for the volumes that you can use in your container
            /// definitions.
            /// Required: No
            /// Type: List of Amazon Elastic Container Service TaskDefinition Volumes
            /// Update requires: Replacement
            /// </summary>
			public List<Volume> Volumes { get; set; }

        }
    
        public string Type { get; } = "AWS::ECS::TaskDefinition";
        
        public TaskDefinitionProperties Properties { get; } = new TaskDefinitionProperties();

    }
}
