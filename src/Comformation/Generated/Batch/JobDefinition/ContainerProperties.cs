using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition ContainerProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html
    /// </summary>
    public class ContainerProperties
    {

        /// <summary>
        /// User
        /// The user name to use inside the container. This parameter maps to User in the Create a container
        /// section of the Docker Remote API and the --user option to docker run.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("User")]
        public Union<string, IntrinsicFunction> User { get; set; }

        /// <summary>
        /// Secrets
        /// The secrets for the container. For more information, see Specifying sensitive data in the AWS Batch
        /// User Guide.
        /// Required: No
        /// Type: List of Secret
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Secrets")]
        public List<Secret> Secrets { get; set; }

        /// <summary>
        /// Memory
        /// This parameter is deprecated and not supported for jobs run on Fargate resources, use
        /// ResourceRequirement. For jobs run on EC2 resources can specify the memory requirement using the
        /// ResourceRequirement structure. The hard limit (in MiB) of memory to present to the container. If
        /// your container attempts to exceed the memory specified here, the container is killed. This parameter
        /// maps to Memory in the Create a container section of the Docker Remote API and the --memory option to
        /// docker run. You must specify at least 4 MiB of memory for a job. This is required but can be
        /// specified in several places; it must be specified for each node at least once.
        /// Note If you&#39;re trying to maximize your resource utilization by providing your jobs as much memory as
        /// possible for a particular instance type, see Memory Management in the AWS Batch User Guide.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Memory")]
        public Union<int, IntrinsicFunction> Memory { get; set; }

        /// <summary>
        /// Privileged
        /// When this parameter is true, the container is given elevated permissions on the host container
        /// instance (similar to the root user). This parameter maps to Privileged in the Create a container
        /// section of the Docker Remote API and the --privileged option to docker run. The default value is
        /// false.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources and shouldn&#39;t be provided,
        /// or specified as false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Privileged")]
        public Union<bool, IntrinsicFunction> Privileged { get; set; }

        /// <summary>
        /// LinuxParameters
        /// Linux-specific modifications that are applied to the container, such as details for device mappings.
        /// Required: No
        /// Type: LinuxParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LinuxParameters")]
        public LinuxParameters LinuxParameters { get; set; }

        /// <summary>
        /// FargatePlatformConfiguration
        /// The platform configuration for jobs running on Fargate resources. Jobs running on EC2 resources must
        /// not specify this parameter.
        /// Required: No
        /// Type: FargatePlatformConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FargatePlatformConfiguration")]
        public FargatePlatformConfiguration FargatePlatformConfiguration { get; set; }

        /// <summary>
        /// JobRoleArn
        /// The Amazon Resource Name (ARN) of the IAM role that the container can assume for AWS permissions.
        /// For more information, see IAM Roles for Tasks in the Amazon Elastic Container Service Developer
        /// Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JobRoleArn")]
        public Union<string, IntrinsicFunction> JobRoleArn { get; set; }

        /// <summary>
        /// ReadonlyRootFilesystem
        /// When this parameter is true, the container is given read-only access to its root file system. This
        /// parameter maps to ReadonlyRootfs in the Create a container section of the Docker Remote API and the
        /// --read-only option to docker run.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReadonlyRootFilesystem")]
        public Union<bool, IntrinsicFunction> ReadonlyRootFilesystem { get; set; }

        /// <summary>
        /// Vcpus
        /// This parameter is deprecated and not supported for jobs run on Fargate resources, see
        /// resourceRequirement. The number of vCPUs reserved for the container. Jobs running on EC2 resources
        /// can specify the vCPU requirement for the job using resourceRequirements but the vCPU requirements
        /// can&#39;t be specified both here and in the resourceRequirement structure. This parameter maps to
        /// CpuShares in the Create a container section of the Docker Remote API and the --cpu-shares option to
        /// docker run. Each vCPU is equivalent to 1,024 CPU shares. You must specify at least one vCPU. This is
        /// required but can be specified in several places. It must be specified for each node at least once.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources and shouldn&#39;t be provided.
        /// Jobs running on Fargate resources must specify the vCPU requirement for the job using
        /// resourceRequirements.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Vcpus")]
        public Union<int, IntrinsicFunction> Vcpus { get; set; }

        /// <summary>
        /// Image
        /// The image used to start a container. This string is passed directly to the Docker daemon. Images in
        /// the Docker Hub registry are available by default. Other repositories are specified with
        /// repository-url/image:tag . Up to 255 letters (uppercase and lowercase), numbers, hyphens,
        /// underscores, colons, periods, forward slashes, and number signs are allowed. This parameter maps to
        /// Image in the Create a container section of the Docker Remote API and the IMAGE parameter of docker
        /// run.
        /// Note Docker image architecture must match the processor architecture of the compute resources that
        /// they&#39;re scheduled on. For example, ARM-based Docker images can only run on ARM-based compute
        /// resources.
        /// Images in Amazon ECR repositories use the full registry and repository URI (for example,
        /// 012345678910. dkr. ecr. &amp;lt;region-name&amp;gt;. amazonaws. com/&amp;lt;repository-name&amp;gt;). Images in
        /// official repositories on Docker Hub use a single name (for example, ubuntu or mongo). Images in
        /// other repositories on Docker Hub are qualified with an organization name (for example,
        /// amazon/amazon-ecs-agent). Images in other online repositories are qualified further by a domain name
        /// (for example, quay. io/assemblyline/ubuntu).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Image")]
        public Union<string, IntrinsicFunction> Image { get; set; }

        /// <summary>
        /// ResourceRequirements
        /// The type and amount of resources to assign to a container. The supported resources include GPU,
        /// MEMORY, and VCPU.
        /// Required: No
        /// Type: List of ResourceRequirement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceRequirements")]
        public List<ResourceRequirement> ResourceRequirements { get; set; }

        /// <summary>
        /// LogConfiguration
        /// The log configuration specification for the container.
        /// This parameter maps to LogConfig in the Create a container section of the Docker Remote API and the
        /// --log-driver option to docker run. By default, containers use the same logging driver that the
        /// Docker daemon uses. However the container might use a different logging driver than the Docker
        /// daemon by specifying a log driver with this parameter in the container definition. To use a
        /// different logging driver for a container, the log system must be configured properly on the
        /// container instance (or on a different log server for remote logging options). For more information
        /// on the options for different supported log drivers, see Configure logging drivers in the Docker
        /// documentation.
        /// Note AWS Batch currently supports a subset of the logging drivers available to the Docker daemon
        /// (shown in the LogConfiguration data type).
        /// This parameter requires version 1. 18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log into your container
        /// instance and run the following command: sudo docker version | grep &quot;Server API version&quot;
        /// Note The Amazon ECS container agent running on a container instance must register the logging
        /// drivers available on that instance with the ECS_AVAILABLE_LOGGING_DRIVERS environment variable
        /// before containers placed on that instance can use these log configuration options. For more
        /// information, see Amazon ECS Container Agent Configuration in the Amazon Elastic Container Service
        /// Developer Guide.
        /// Required: No
        /// Type: LogConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogConfiguration")]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// MountPoints
        /// The mount points for data volumes in your container. This parameter maps to Volumes in the Create a
        /// container section of the Docker Remote API and the --volume option to docker run.
        /// Required: No
        /// Type: List of MountPoints
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MountPoints")]
        public List<MountPoints> MountPoints { get; set; }

        /// <summary>
        /// ExecutionRoleArn
        /// The Amazon Resource Name (ARN) of the execution role that AWS Batch can assume. Jobs running on
        /// Fargate resources must provide an execution role. For more information, see AWS Batch execution IAM
        /// role in the AWS Batch User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExecutionRoleArn")]
        public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

        /// <summary>
        /// Volumes
        /// A list of data volumes used in a job.
        /// Required: No
        /// Type: List of Volumes
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Volumes")]
        public List<Volumes> Volumes { get; set; }

        /// <summary>
        /// Command
        /// The command that&#39;s passed to the container. This parameter maps to Cmd in the Create a container
        /// section of the Docker Remote API and the COMMAND parameter to docker run. For more information, see
        /// https://docs. docker. com/engine/reference/builder/#cmd.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Command")]
        public List<Union<string, IntrinsicFunction>> Command { get; set; }

        /// <summary>
        /// Environment
        /// The environment variables to pass to a container. This parameter maps to Env in the Create a
        /// container section of the Docker Remote API and the --env option to docker run.
        /// Important We don&#39;t recommend using plaintext environment variables for sensitive information, such
        /// as credential data.
        /// Note Environment variables must not start with AWS_BATCH; this naming convention is reserved for
        /// variables that are set by the AWS Batch service.
        /// Required: No
        /// Type: List of Environment
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Environment")]
        public List<Environment> Environment { get; set; }

        /// <summary>
        /// Ulimits
        /// A list of ulimits to set in the container. This parameter maps to Ulimits in the Create a container
        /// section of the Docker Remote API and the --ulimit option to docker run.
        /// Note This parameter isn&#39;t applicable to jobs running on Fargate resources and shouldn&#39;t be provided.
        /// Required: No
        /// Type: List of Ulimit
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ulimits")]
        public List<Ulimit> Ulimits { get; set; }

        /// <summary>
        /// NetworkConfiguration
        /// The network configuration for jobs running on Fargate resources. Jobs running on EC2 resources must
        /// not specify this parameter.
        /// Required: No
        /// Type: NetworkConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NetworkConfiguration")]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// InstanceType
        /// The instance type to use for a multi-node parallel job. All node groups in a multi-node parallel job
        /// must use the same instance type.
        /// Note This parameter isn&#39;t applicable to single-node container jobs or for jobs running on Fargate
        /// resources and shouldn&#39;t be provided.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

    }
}
