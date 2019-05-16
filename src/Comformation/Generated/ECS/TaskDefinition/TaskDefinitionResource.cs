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
            /// A list of container definitions in JSON format that describe the different containers that make up
            /// your task. For more information about container definition parameters and defaults, see Amazon ECS
            /// Task Definitions in the Amazon Elastic Container Service Developer Guide.
            /// Required: No
            /// Type: List of ContainerDefinition
            /// Update requires: Replacement
            /// </summary>
			public List<ContainerDefinition> ContainerDefinitions { get; set; }

            /// <summary>
            /// Cpu
            /// The number of cpu units used by the task. If you are using the EC2 launch type, this field is
            /// optional and any value can be used. If you are using the Fargate launch type, this field is required
            /// and you must use one of the following values, which determines your range of valid values for the
            /// memory parameter:
            /// 256 (. 25 vCPU) - Available memory values: 512 (0. 5 GB), 1024 (1 GB), 2048 (2 GB) 512 (. 5 vCPU) -
            /// Available memory values: 1024 (1 GB), 2048 (2 GB), 3072 (3 GB), 4096 (4 GB) 1024 (1 vCPU) -
            /// Available memory values: 2048 (2 GB), 3072 (3 GB), 4096 (4 GB), 5120 (5 GB), 6144 (6 GB), 7168 (7
            /// GB), 8192 (8 GB) 2048 (2 vCPU) - Available memory values: Between 4096 (4 GB) and 16384 (16 GB) in
            /// increments of 1024 (1 GB) 4096 (4 vCPU) - Available memory values: Between 8192 (8 GB) and 30720 (30
            /// GB) in increments of 1024 (1 GB)
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
            /// and any value can be used. If using the Fargate launch type, this field is required and you must use
            /// one of the following values, which determines your range of valid values for the cpu parameter:
            /// 512 (0. 5 GB), 1024 (1 GB), 2048 (2 GB) - Available cpu values: 256 (. 25 vCPU) 1024 (1 GB), 2048 (2
            /// GB), 3072 (3 GB), 4096 (4 GB) - Available cpu values: 512 (. 5 vCPU) 2048 (2 GB), 3072 (3 GB), 4096
            /// (4 GB), 5120 (5 GB), 6144 (6 GB), 7168 (7 GB), 8192 (8 GB) - Available cpu values: 1024 (1 vCPU)
            /// Between 4096 (4 GB) and 16384 (16 GB) in increments of 1024 (1 GB) - Available cpu values: 2048 (2
            /// vCPU) Between 8192 (8 GB) and 30720 (30 GB) in increments of 1024 (1 GB) - Available cpu values:
            /// 4096 (4 vCPU)
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Memory { get; set; }

            /// <summary>
            /// NetworkMode
            /// The Docker networking mode to use for the containers in the task. The valid values are none, bridge,
            /// awsvpc, and host. The default Docker network mode is bridge. If you are using the Fargate launch
            /// type, the awsvpc network mode is required. If you are using the EC2 launch type, any network mode
            /// can be used. If the network mode is set to none, you cannot specify port mappings in your container
            /// definitions, and the tasks containers do not have external connectivity. The host and awsvpc network
            /// modes offer the highest networking performance for containers because they use the EC2 network stack
            /// instead of the virtualized network stack provided by the bridge mode.
            /// With the host and awsvpc network modes, exposed container ports are mapped directly to the
            /// corresponding host port (for the host network mode) or the attached elastic network interface port
            /// (for the awsvpc network mode), so you cannot take advantage of dynamic host port mappings.
            /// If the network mode is awsvpc, the task is allocated an elastic network interface, and you must
            /// specify a NetworkConfiguration value when you create a service or run a task with the task
            /// definition. For more information, see Task Networking in the Amazon Elastic Container Service
            /// Developer Guide.
            /// Note Currently, only Amazon ECS-optimized AMIs, other Amazon Linux variants with the ecs-init
            /// package, or AWS Fargate infrastructure support the awsvpc network mode.
            /// If the network mode is host, you cannot run multiple instantiations of the same task on a single
            /// container instance when port mappings are used.
            /// Docker for Windows uses different network modes than Docker for Linux. When you register a task
            /// definition with Windows containers, you must not specify a network mode. If you use the console to
            /// register a task definition with Windows containers, you must choose the &amp;lt;default&amp;gt; network mode
            /// object.
            /// For more information, see Network settings in the Docker run reference.
            /// Required: No
            /// Type: String
            /// Allowed Values: awsvpc | bridge | host | none
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkMode { get; set; }

            /// <summary>
            /// PlacementConstraints
            /// An array of placement constraint objects to use for tasks. This field is not valid if you are using
            /// the Fargate launch type for your task.
            /// Required: No
            /// Type: List of TaskDefinitionPlacementConstraint
            /// Update requires: Replacement
            /// </summary>
			public List<TaskDefinitionPlacementConstraint> PlacementConstraints { get; set; }

            /// <summary>
            /// RequiresCompatibilities
            /// The launch type the task requires. If no value is specified, it will default to EC2. Valid values
            /// include EC2 and FARGATE.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> RequiresCompatibilities { get; set; }

            /// <summary>
            /// TaskRoleArn
            /// The Amazon Resource Name (ARN) of an AWS Identity and Access Management (IAM) role that grants
            /// containers in the task permission to call AWS APIs on your behalf. For more information, see Amazon
            /// ECS Task Role in the Amazon Elastic Container Service Developer Guide.
            /// IAM roles for tasks on Windows require that the -EnableTaskIAMRole option is set when you launch the
            /// Amazon ECS-optimized Windows AMI. Your containers must also run some configuration code in order to
            /// take advantage of the feature. For more information, see Windows IAM Roles for Tasks in the Amazon
            /// Elastic Container Service Developer Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TaskRoleArn { get; set; }

            /// <summary>
            /// Volumes
            /// The list of volume definitions for the task.
            /// If your tasks are using the Fargate launch type, the host and sourcePath parameters are not
            /// supported.
            /// For more information about volume definition parameters and defaults, see Amazon ECS Task
            /// Definitions in the Amazon Elastic Container Service Developer Guide.
            /// Required: No
            /// Type: List of Volume
            /// Update requires: No interruption
            /// </summary>
			public List<Volume> Volumes { get; set; }

        }

        public string Type { get; } = "AWS::ECS::TaskDefinition";

        public TaskDefinitionProperties Properties { get; } = new TaskDefinitionProperties();

    }
}
