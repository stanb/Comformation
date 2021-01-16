using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html
    /// </summary>
    public class TaskDefinitionResource : ResourceBase
    {
        public class TaskDefinitionProperties
        {
            /// <summary>
            /// Family
            /// The name of a family that this task definition is registered to. Up to 255 letters (uppercase and
            /// lowercase), numbers, hyphens, and underscores are allowed.
            /// A family groups multiple versions of a task definition. Amazon ECS gives the first task definition
            /// that you registered to a family a revision number of 1. Amazon ECS gives sequential revision numbers
            /// to each task definition that you add.
            /// Note To use revision numbers when you update a task definition, specify this property. If you don&#39;t
            /// specify a value, AWS CloudFormation generates a new task definition each time that you update it.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Family { get; set; }

            /// <summary>
            /// ContainerDefinitions
            /// 		
            /// A list of container definitions in JSON format that describe the different containers 			that make
            /// up your task. For more information about container definition parameters and 			defaults, see Amazon
            /// ECS Task 				Definitions in the Amazon Elastic Container Service Developer Guide.
            /// 	
            /// Required: No
            /// Type: List of ContainerDefinition
            /// Update requires: Replacement
            /// </summary>
            public List<ContainerDefinition> ContainerDefinitions { get; set; }

            /// <summary>
            /// Cpu
            /// 		
            /// The number of cpu units used by the task. If you are using the EC2 launch 			type, this field is
            /// optional and any value can be used. If you are using the Fargate 			launch type, this field is
            /// required and you must use one of the following values, which 			determines your range of valid
            /// values for the memory parameter:
            /// 		
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
            /// The Amazon Resource Name (ARN) of the task execution role that grants the Amazon ECS container agent
            /// permission to make AWS API calls on your behalf. The task execution IAM role is required depending
            /// on the requirements of your task. For more information, see Amazon ECS task execution IAM role in
            /// the Amazon Elastic Container Service Developer Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

            /// <summary>
            /// InferenceAccelerators
            /// 		
            /// The Elastic Inference accelerators to use for the containers in the task.
            /// 	
            /// Required: No
            /// Type: List of InferenceAccelerator
            /// Update requires: Replacement
            /// </summary>
            public List<InferenceAccelerator> InferenceAccelerators { get; set; }

            /// <summary>
            /// Memory
            /// 		
            /// The amount (in MiB) of memory used by the task.
            /// 		
            /// If your tasks will be run on Amazon EC2 instances, you must specify either a task-level 			memory
            /// value or a container-level memory value. This field is optional and any value can 			be used. If a
            /// task-level memory value is specified then the container-level memory value 			is optional. For more
            /// information regarding container-level memory and memory 			reservation, see ContainerDefinition.
            /// 		
            /// If your tasks will be run on AWS Fargate, this field is required and you must use one of 			the
            /// following values, which determines your range of valid values for the 				cpu parameter:
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
            /// Allowed values: awsvpc | bridge | host | none
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> NetworkMode { get; set; }

            /// <summary>
            /// PlacementConstraints
            /// 		
            /// An array of placement constraint objects to use for tasks.
            /// 		
            /// Note This parameter is not supported for tasks run on AWS Fargate.
            /// 	
            /// Required: No
            /// Type: List of TaskDefinitionPlacementConstraint
            /// Update requires: Replacement
            /// </summary>
            public List<TaskDefinitionPlacementConstraint> PlacementConstraints { get; set; }

            /// <summary>
            /// ProxyConfiguration
            /// The ProxyConfiguration property specifies the configuration details for the App Mesh proxy.
            /// Your Amazon ECS container instances require at least version 1. 26. 0 of the container agent and at
            /// least version 1. 26. 0-1 of the ecs-init package to enable a proxy configuration. If your container
            /// instances are launched from the Amazon ECS-optimized AMI version 20190301 or later, then they
            /// contain the required versions of the container agent and ecs-init. For more information, see Amazon
            /// ECS-optimized Linux AMI in the Amazon Elastic Container Service Developer Guide.
            /// Required: No
            /// Type: ProxyConfiguration
            /// Update requires: Replacement
            /// </summary>
            public ProxyConfiguration ProxyConfiguration { get; set; }

            /// <summary>
            /// RequiresCompatibilities
            /// 		
            /// The task launch types the task definition was validated against. To determine which 			task launch
            /// types the task definition is validated for, see the TaskDefinition$compatibilities parameter.
            /// 	
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> RequiresCompatibilities { get; set; }

            /// <summary>
            /// TaskRoleArn
            /// 		
            /// The short name or full Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM)
            /// role that grants containers in the 			task permission to call AWS APIs on your behalf. For more
            /// information, see Amazon ECS 				Task Role in the Amazon Elastic Container Service Developer Guide.
            /// 		
            /// IAM roles for tasks on Windows require that the -EnableTaskIAMRole option 			is set when you launch
            /// the Amazon ECS-optimized Windows AMI. Your containers must also run some 			configuration code in
            /// order to take advantage of the feature. For more information, see 				Windows IAM roles 				for
            /// tasks in the Amazon Elastic Container Service Developer Guide.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TaskRoleArn { get; set; }

            /// <summary>
            /// Volumes
            /// 		
            /// The list of data volume definitions for the task. For more information, see Using data volumes in
            /// tasks in the 			Amazon Elastic Container Service Developer Guide.
            /// 		
            /// Note The host and sourcePath parameters are not supported for 				tasks run on AWS Fargate.
            /// 	
            /// Required: No
            /// Type: List of Volume
            /// Update requires: Replacement
            /// </summary>
            public List<Volume> Volumes { get; set; }

            /// <summary>
            /// PidMode
            /// The process namespace to use for the containers in the task. The valid values are host or task. If
            /// host is specified, then all containers within the tasks that specified the host PID mode on the same
            /// container instance share the same process namespace with the host Amazon EC2 instance. If task is
            /// specified, all containers within the specified task share the same process namespace. If no value is
            /// specified, the default is a private namespace. For more information, see PID settings in the Docker
            /// run reference.
            /// If the host PID mode is used, be aware that there is a heightened risk of undesired process
            /// namespace expose. For more information, see Docker security.
            /// Note This parameter is not supported for Windows containers or tasks run on AWS Fargate.
            /// Required: No
            /// Type: String
            /// Allowed values: host | task
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PidMode { get; set; }

            /// <summary>
            /// IpcMode
            /// The IPC resource namespace to use for the containers in the task. The valid values are host, task,
            /// or none. If host is specified, then all containers within the tasks that specified the host IPC mode
            /// on the same container instance share the same IPC resources with the host Amazon EC2 instance. If
            /// task is specified, all containers within the specified task share the same IPC resources. If none is
            /// specified, then IPC resources within the containers of a task are private and not shared with other
            /// containers in a task or on the container instance. If no value is specified, then the IPC resource
            /// namespace sharing depends on the Docker daemon setting on the container instance. For more
            /// information, see IPC settings in the Docker run reference.
            /// If the host IPC mode is used, be aware that there is a heightened risk of undesired IPC namespace
            /// expose. For more information, see Docker security.
            /// If you are setting namespaced kernel parameters using systemControls for the containers in the task,
            /// the following will apply to your IPC resource namespace. For more information, see System Controls
            /// in the Amazon Elastic Container Service Developer Guide.
            /// For tasks that use the host IPC mode, IPC namespace related systemControls are not supported. For
            /// tasks that use the task IPC mode, IPC namespace related systemControls will apply to all containers
            /// within a task.
            /// Note This parameter is not supported for Windows containers or tasks run on AWS Fargate.
            /// Required: No
            /// Type: String
            /// Allowed values: host | none | task
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> IpcMode { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// The metadata that you apply to the task definition to help you categorize and organize 			them. Each
            /// tag consists of a key and an optional value, both of which you define.
            /// 		
            /// The following basic restrictions apply to tags:
            /// Maximum number of tags per resource - 50 For each resource, each tag key must be unique, and each
            /// tag key can have only one value. Maximum key length - 128 Unicode characters in UTF-8 Maximum value
            /// length - 256 Unicode characters in UTF-8 If your tagging schema is used across multiple services and
            /// resources, remember that other services may have restrictions on allowed characters. Generally
            /// allowed characters are: letters, numbers, and spaces representable in UTF-8, and the following
            /// characters: + - = . _ : / @. Tag keys and values are case-sensitive. Do not use aws:, AWS:, or any
            /// upper or lowercase combination of such as a prefix for either keys or values as it is reserved for
            /// AWS use. You cannot edit or delete tag keys or values with this prefix. Tags with this prefix do not
            /// count against your tags per resource limit.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ECS::TaskDefinition";

        public TaskDefinitionProperties Properties { get; } = new TaskDefinitionProperties();

    }

    public static class TaskDefinitionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TaskDefinitionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("TaskDefinitionArn");
    }
}
