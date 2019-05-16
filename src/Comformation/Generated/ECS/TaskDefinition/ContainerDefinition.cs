using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition ContainerDefinition
    /// The ContainerDefinition property specifies a container definition. Container definitions are used in task
    /// definitions to describe the different containers that are launched as part of a task.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinitions.html
    /// </summary>
    public class ContainerDefinition
    {

        /// <summary>
        /// Command
        /// The command that is passed to the container. This parameter maps to Cmd in the Create a container
        /// section of the Docker Remote API and the COMMAND parameter to docker run. For more information, see
        /// https://docs. docker. com/engine/reference/builder/#cmd. If there are multiple arguments, each
        /// argument should be a separated string in the array.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Command")]
        public List<Union<string, IntrinsicFunction>> Command { get; set; }

        /// <summary>
        /// Cpu
        /// The number of cpu units reserved for the container. This parameter maps to CpuShares in the Create a
        /// container section of the Docker Remote API and the --cpu-shares option to docker run.
        /// This field is optional for tasks using the Fargate launch type, and the only requirement is that the
        /// total amount of CPU reserved for all containers within a task be lower than the task-level cpu
        /// value.
        /// Note You can determine the number of CPU units that are available per EC2 instance type by
        /// multiplying the vCPUs listed for that instance type on the Amazon EC2 Instances detail page by
        /// 1,024.
        /// For example, if you run a single-container task on a single-core instance type with 512 CPU units
        /// specified for that container, and that is the only task running on the container instance, that
        /// container could use the full 1,024 CPU unit share at any given time. However, if you launched
        /// another copy of the same task on that container instance, each task would be guaranteed a minimum of
        /// 512 CPU units when needed, and each container could float to higher CPU usage if the other container
        /// was not using it, but if both tasks were 100% active all of the time, they would be limited to 512
        /// CPU units.
        /// Linux containers share unallocated CPU units with other containers on the container instance with
        /// the same ratio as their allocated amount. For example, if you run a single-container task on a
        /// single-core instance type with 512 CPU units specified for that container, and that is the only task
        /// running on the container instance, that container could use the full 1,024 CPU unit share at any
        /// given time. However, if you launched another copy of the same task on that container instance, each
        /// task would be guaranteed a minimum of 512 CPU units when needed, and each container could float to
        /// higher CPU usage if the other container was not using it, but if both tasks were 100% active all of
        /// the time, they would be limited to 512 CPU units.
        /// On Linux container instances, the Docker daemon on the container instance uses the CPU value to
        /// calculate the relative CPU share ratios for running containers. For more information, see CPU share
        /// constraint in the Docker documentation. The minimum valid CPU share value that the Linux kernel
        /// allows is 2. However, the CPU parameter is not required, and you can use CPU values below 2 in your
        /// container definitions. For CPU values below 2 (including null), the behavior varies based on your
        /// Amazon ECS container agent version:
        /// Agent versions less than or equal to 1. 1. 0: Null and zero CPU values are passed to Docker as 0,
        /// which Docker then converts to 1,024 CPU shares. CPU values of 1 are passed to Docker as 1, which the
        /// Linux kernel converts to two CPU shares. Agent versions greater than or equal to 1. 2. 0: Null,
        /// zero, and CPU values of 1 are passed to Docker as 2.
        /// On Windows container instances, the CPU limit is enforced as an absolute limit, or a quota. Windows
        /// containers only have access to the specified amount of CPU that is described in the task definition.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Cpu")]
        public Union<int, IntrinsicFunction> Cpu { get; set; }

        /// <summary>
        /// DisableNetworking
        /// When this parameter is true, networking is disabled within the container. This parameter maps to
        /// NetworkDisabled in the Create a container section of the Docker Remote API.
        /// Note This parameter is not supported for Windows containers.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DisableNetworking")]
        public Union<bool, IntrinsicFunction> DisableNetworking { get; set; }

        /// <summary>
        /// DnsSearchDomains
        /// A list of DNS search domains that are presented to the container. This parameter maps to DnsSearch
        /// in the Create a container section of the Docker Remote API and the --dns-search option to docker
        /// run.
        /// Note This parameter is not supported for Windows containers.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DnsSearchDomains")]
        public List<Union<string, IntrinsicFunction>> DnsSearchDomains { get; set; }

        /// <summary>
        /// DnsServers
        /// A list of DNS servers that are presented to the container. This parameter maps to Dns in the Create
        /// a container section of the Docker Remote API and the --dns option to docker run.
        /// Note This parameter is not supported for Windows containers.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DnsServers")]
        public List<Union<string, IntrinsicFunction>> DnsServers { get; set; }

        /// <summary>
        /// DockerLabels
        /// A key/value map of labels to add to the container. This parameter maps to Labels in the Create a
        /// container section of the Docker Remote API and the --label option to docker run. This parameter
        /// requires version 1. 18 of the Docker Remote API or greater on your container instance. To check the
        /// Docker Remote API version on your container instance, log in to your container instance and run the
        /// following command: sudo docker version --format &#39;{{. Server. APIVersion}}&#39;
        /// Required: No
        /// Type: Map of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DockerLabels")]
        public Dictionary<string, Union<string, IntrinsicFunction>> DockerLabels { get; set; }

        /// <summary>
        /// DockerSecurityOptions
        /// A list of strings to provide custom labels for SELinux and AppArmor multi-level security systems.
        /// This field is not valid for containers in tasks using the Fargate launch type.
        /// This parameter maps to SecurityOpt in the Create a container section of the Docker Remote API and
        /// the --security-opt option to docker run.
        /// Note The Amazon ECS container agent running on a container instance must register with the
        /// ECS_SELINUX_CAPABLE=true or ECS_APPARMOR_CAPABLE=true environment variables before containers placed
        /// on that instance can use these security options. For more information, see Amazon ECS Container
        /// Agent Configuration in the Amazon Elastic Container Service Developer Guide. This parameter is not
        /// supported for Windows containers.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DockerSecurityOptions")]
        public List<Union<string, IntrinsicFunction>> DockerSecurityOptions { get; set; }

        /// <summary>
        /// EntryPoint
        /// Important Early versions of the Amazon ECS container agent do not properly handle entryPoint
        /// parameters. If you have problems using entryPoint, update your container agent or enter your
        /// commands and arguments as command array items instead.
        /// The entry point that is passed to the container. This parameter maps to Entrypoint in the Create a
        /// container section of the Docker Remote API and the --entrypoint option to docker run. For more
        /// information, see https://docs. docker. com/engine/reference/builder/#entrypoint.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EntryPoint")]
        public List<Union<string, IntrinsicFunction>> EntryPoint { get; set; }

        /// <summary>
        /// Environment
        /// The environment variables to pass to a container. This parameter maps to Env in the Create a
        /// container section of the Docker Remote API and the --env option to docker run.
        /// Important We do not recommend using plaintext environment variables for sensitive information, such
        /// as credential data.
        /// Required: No
        /// Type: List of KeyValuePair
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Environment")]
        public List<KeyValuePair> Environment { get; set; }

        /// <summary>
        /// Essential
        /// If the essential parameter of a container is marked as true, and that container fails or stops for
        /// any reason, all other containers that are part of the task are stopped. If the essential parameter
        /// of a container is marked as false, then its failure does not affect the rest of the containers in a
        /// task. If this parameter is omitted, a container is assumed to be essential.
        /// All tasks must have at least one essential container. If you have an application that is composed of
        /// multiple containers, you should group containers that are used for a common purpose into components,
        /// and separate the different components into multiple task definitions. For more information, see
        /// Application Architecture in the Amazon Elastic Container Service Developer Guide.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Essential")]
        public Union<bool, IntrinsicFunction> Essential { get; set; }

        /// <summary>
        /// ExtraHosts
        /// A list of hostnames and IP address mappings to append to the /etc/hosts file on the container. This
        /// parameter maps to ExtraHosts in the Create a container section of the Docker Remote API and the
        /// --add-host option to docker run.
        /// Note This parameter is not supported for Windows containers or tasks that use the awsvpc network
        /// mode.
        /// Required: No
        /// Type: List of HostEntry
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ExtraHosts")]
        public List<HostEntry> ExtraHosts { get; set; }

        /// <summary>
        /// HealthCheck
        /// The health check command and associated configuration parameters for the container. This parameter
        /// maps to HealthCheck in the Create a container section of the Docker Remote API and the HEALTHCHECK
        /// parameter of docker run.
        /// Required: No
        /// Type: HealthCheck
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("HealthCheck")]
        public HealthCheck HealthCheck { get; set; }

        /// <summary>
        /// Hostname
        /// The hostname to use for your container. This parameter maps to Hostname in the Create a container
        /// section of the Docker Remote API and the --hostname option to docker run.
        /// Note The hostname parameter is not supported if you are using the awsvpc network mode.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Hostname")]
        public Union<string, IntrinsicFunction> Hostname { get; set; }

        /// <summary>
        /// Image
        /// The image used to start a container. This string is passed directly to the Docker daemon. Images in
        /// the Docker Hub registry are available by default. Other repositories are specified with either
        /// repository-url/image:tag or repository-url/image@digest . Up to 255 letters (uppercase and
        /// lowercase), numbers, hyphens, underscores, colons, periods, forward slashes, and number signs are
        /// allowed. This parameter maps to Image in the Create a container section of the Docker Remote API and
        /// the IMAGE parameter of docker run.
        /// When a new task starts, the Amazon ECS container agent pulls the latest version of the specified
        /// image and tag for the container to use. However, subsequent updates to a repository image are not
        /// propagated to already running tasks. Images in Amazon ECR repositories can be specified by either
        /// using the full registry/repository:tag or registry/repository@digest. For example, 012345678910.
        /// dkr. ecr. &amp;lt;region-name&amp;gt;. amazonaws. com/&amp;lt;repository-name&amp;gt;:latest or 012345678910. dkr.
        /// ecr. &amp;lt;region-name&amp;gt;. amazonaws.
        /// com/&amp;lt;repository-name&amp;gt;@sha256:94afd1f2e64d908bc90dbca0035a5b567EXAMPLE. Images in official
        /// repositories on Docker Hub use a single name (for example, ubuntu or mongo). Images in other
        /// repositories on Docker Hub are qualified with an organization name (for example,
        /// amazon/amazon-ecs-agent). Images in other online repositories are qualified further by a domain name
        /// (for example, quay. io/assemblyline/ubuntu).
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Image")]
        public Union<string, IntrinsicFunction> Image { get; set; }

        /// <summary>
        /// Links
        /// The link parameter allows containers to communicate with each other without the need for port
        /// mappings. Only supported if the network mode of a task definition is set to bridge. The
        /// name:internalName construct is analogous to name:alias in Docker links. Up to 255 letters (uppercase
        /// and lowercase), numbers, and hyphens are allowed. For more information about linking Docker
        /// containers, go to https://docs. docker.
        /// com/engine/userguide/networking/default_network/dockerlinks/. This parameter maps to Links in the
        /// Create a container section of the Docker Remote API and the --link option to docker run .
        /// Note This parameter is not supported for Windows containers.
        /// Important Containers that are collocated on a single container instance may be able to communicate
        /// with each other without requiring links or host port mappings. Network isolation is achieved on the
        /// container instance using security groups and VPC settings.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Links")]
        public List<Union<string, IntrinsicFunction>> Links { get; set; }

        /// <summary>
        /// LinuxParameters
        /// Linux-specific modifications that are applied to the container, such as Linux kernel capabilities.
        /// For more information see KernelCapabilities.
        /// Note This parameter is not supported for Windows containers.
        /// Required: No
        /// Type: LinuxParameters
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LinuxParameters")]
        public LinuxParameters LinuxParameters { get; set; }

        /// <summary>
        /// LogConfiguration
        /// The log configuration specification for the container.
        /// If you are using the Fargate launch type, the only supported value is awslogs.
        /// This parameter maps to LogConfig in the Create a container section of the Docker Remote API and the
        /// --log-driver option to docker run. By default, containers use the same logging driver that the
        /// Docker daemon uses. However the container may use a different logging driver than the Docker daemon
        /// by specifying a log driver with this parameter in the container definition. To use a different
        /// logging driver for a container, the log system must be configured properly on the container instance
        /// (or on a different log server for remote logging options). For more information on the options for
        /// different supported log drivers, see Configure logging drivers in the Docker documentation.
        /// Note Amazon ECS currently supports a subset of the logging drivers available to the Docker daemon
        /// (shown in the LogConfiguration data type). Additional log drivers may be available in future
        /// releases of the Amazon ECS container agent.
        /// This parameter requires version 1. 18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log in to your
        /// container instance and run the following command: sudo docker version --format &#39;{{. Server.
        /// APIVersion}}&#39;
        /// Note The Amazon ECS container agent running on a container instance must register the logging
        /// drivers available on that instance with the ECS_AVAILABLE_LOGGING_DRIVERS environment variable
        /// before containers placed on that instance can use these log configuration options. For more
        /// information, see Amazon ECS Container Agent Configuration in the Amazon Elastic Container Service
        /// Developer Guide.
        /// Required: No
        /// Type: LogConfiguration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LogConfiguration")]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Memory
        /// The hard limit (in MiB) of memory to present to the container. If your container attempts to exceed
        /// the memory specified here, the container is killed. This parameter maps to Memory in the Create a
        /// container section of the Docker Remote API and the --memory option to docker run.
        /// If your containers are part of a task using the Fargate launch type, this field is optional and the
        /// only requirement is that the total amount of memory reserved for all containers within a task be
        /// lower than the task memory value.
        /// For containers that are part of a task using the EC2 launch type, you must specify a non-zero
        /// integer for one or both of memory or memoryReservation in container definitions. If you specify
        /// both, memory must be greater than memoryReservation. If you specify memoryReservation, then that
        /// value is subtracted from the available memory resources for the container instance on which the
        /// container is placed. Otherwise, the value of memory is used.
        /// The Docker daemon reserves a minimum of 4 MiB of memory for a container, so you should not specify
        /// fewer than 4 MiB of memory for your containers.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Memory")]
        public Union<int, IntrinsicFunction> Memory { get; set; }

        /// <summary>
        /// MemoryReservation
        /// The soft limit (in MiB) of memory to reserve for the container. When system memory is under heavy
        /// contention, Docker attempts to keep the container memory to this soft limit. However, your container
        /// can consume more memory when it needs to, up to either the hard limit specified with the memory
        /// parameter (if applicable), or all of the available memory on the container instance, whichever comes
        /// first. This parameter maps to MemoryReservation in the Create a container section of the Docker
        /// Remote API and the --memory-reservation option to docker run.
        /// You must specify a non-zero integer for one or both of memory or memoryReservation in container
        /// definitions. If you specify both, memory must be greater than memoryReservation. If you specify
        /// memoryReservation, then that value is subtracted from the available memory resources for the
        /// container instance on which the container is placed. Otherwise, the value of memory is used.
        /// For example, if your container normally uses 128 MiB of memory, but occasionally bursts to 256 MiB
        /// of memory for short periods of time, you can set a memoryReservation of 128 MiB, and a memory hard
        /// limit of 300 MiB. This configuration would allow the container to only reserve 128 MiB of memory
        /// from the remaining resources on the container instance, but also allow the container to consume more
        /// memory resources when needed.
        /// The Docker daemon reserves a minimum of 4 MiB of memory for a container, so you should not specify
        /// fewer than 4 MiB of memory for your containers.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MemoryReservation")]
        public Union<int, IntrinsicFunction> MemoryReservation { get; set; }

        /// <summary>
        /// MountPoints
        /// The mount points for data volumes in your container.
        /// This parameter maps to Volumes in the Create a container section of the Docker Remote API and the
        /// --volume option to docker run.
        /// Windows containers can mount whole directories on the same drive as $env:ProgramData. Windows
        /// containers cannot mount directories on a different drive, and mount point cannot be across drives.
        /// Required: No
        /// Type: List of MountPoint
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MountPoints")]
        public List<MountPoint> MountPoints { get; set; }

        /// <summary>
        /// Name
        /// The name of a container. If you are linking multiple containers together in a task definition, the
        /// name of one container can be entered in the links of another container to connect the containers. Up
        /// to 255 letters (uppercase and lowercase), numbers, and hyphens are allowed. This parameter maps to
        /// name in the Create a container section of the Docker Remote API and the --name option to docker run.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// PortMappings
        /// The list of port mappings for the container. Port mappings allow containers to access ports on the
        /// host container instance to send or receive traffic.
        /// For task definitions that use the awsvpc network mode, you should only specify the containerPort.
        /// The hostPort can be left blank or it must be the same value as the containerPort.
        /// Port mappings on Windows use the NetNAT gateway address rather than localhost. There is no loopback
        /// for port mappings on Windows, so you cannot access a container&#39;s mapped port from the host itself.
        /// This parameter maps to PortBindings in the Create a container section of the Docker Remote API and
        /// the --publish option to docker run. If the network mode of a task definition is set to none, then
        /// you can&#39;t specify port mappings. If the network mode of a task definition is set to host, then host
        /// ports must either be undefined or they must match the container port in the port mapping.
        /// Note After a task reaches the RUNNING status, manual and automatic host and container port
        /// assignments are visible in the Network Bindings section of a container description for a selected
        /// task in the Amazon ECS console. The assignments are also visible in the networkBindings section
        /// DescribeTasks responses.
        /// Required: No
        /// Type: List of PortMapping
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("PortMappings")]
        public List<PortMapping> PortMappings { get; set; }

        /// <summary>
        /// Privileged
        /// When this parameter is true, the container is given elevated privileges on the host container
        /// instance (similar to the root user). This parameter maps to Privileged in the Create a container
        /// section of the Docker Remote API and the --privileged option to docker run.
        /// Note This parameter is not supported for Windows containers or tasks using the Fargate launch type.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Privileged")]
        public Union<bool, IntrinsicFunction> Privileged { get; set; }

        /// <summary>
        /// ReadonlyRootFilesystem
        /// When this parameter is true, the container is given read-only access to its root file system. This
        /// parameter maps to ReadonlyRootfs in the Create a container section of the Docker Remote API and the
        /// --read-only option to docker run.
        /// Note This parameter is not supported for Windows containers.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ReadonlyRootFilesystem")]
        public Union<bool, IntrinsicFunction> ReadonlyRootFilesystem { get; set; }

        /// <summary>
        /// RepositoryCredentials
        /// The private repository authentication credentials to use.
        /// Required: No
        /// Type: RepositoryCredentials
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RepositoryCredentials")]
        public RepositoryCredentials RepositoryCredentials { get; set; }

        /// <summary>
        /// Ulimits
        /// A list of ulimits to set in the container. This parameter maps to Ulimits in the Create a container
        /// section of the Docker Remote API and the --ulimit option to docker run. Valid naming values are
        /// displayed in the Ulimit data type. This parameter requires version 1. 18 of the Docker Remote API or
        /// greater on your container instance. To check the Docker Remote API version on your container
        /// instance, log in to your container instance and run the following command: sudo docker version
        /// --format &#39;{{. Server. APIVersion}}&#39;
        /// Note This parameter is not supported for Windows containers.
        /// Required: No
        /// Type: List of Ulimit
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Ulimits")]
        public List<Ulimit> Ulimits { get; set; }

        /// <summary>
        /// User
        /// The user name to use inside the container. This parameter maps to User in the Create a container
        /// section of the Docker Remote API and the --user option to docker run.
        /// You can use the following formats. If specifying a UID or GID, you must specify it as a positive
        /// integer.
        /// user user:group uid uid:gid user:gid uid:group
        /// Note This parameter is not supported for Windows containers.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("User")]
        public Union<string, IntrinsicFunction> User { get; set; }

        /// <summary>
        /// VolumesFrom
        /// Data volumes to mount from another container. This parameter maps to VolumesFrom in the Create a
        /// container section of the Docker Remote API and the --volumes-from option to docker run.
        /// Required: No
        /// Type: List of VolumeFrom
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("VolumesFrom")]
        public List<VolumeFrom> VolumesFrom { get; set; }

        /// <summary>
        /// WorkingDirectory
        /// The working directory in which to run commands inside the container. This parameter maps to
        /// WorkingDir in the Create a container section of the Docker Remote API and the --workdir option to
        /// docker run.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("WorkingDirectory")]
        public Union<string, IntrinsicFunction> WorkingDirectory { get; set; }

    }
}
