using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// Amazon Elastic Container Service TaskDefinition ContainerDefinition
    /// The ContainerDefinition property type describes the configuration of an Amazon Elastic Container Service
    /// (Amazon ECS) container. The container definitions are passed to the Docker daemon.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinitions.html
    /// </summary>
    public class ContainerDefinition
    {

        /// <summary>
        /// Command
        /// The CMD value to pass to the container. For more information about the Docker CMD parameter, see
        /// https://docs. docker. com/engine/reference/builder/#cmd.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Command")]
        public List<Union<string, IntrinsicFunction>> Command { get; set; }

        /// <summary>
        /// Cpu
        /// The minimum number of CPU units to reserve for the container. Containers share unallocated CPU units
        /// with other containers on the instance by using the same ratio as their allocated CPU units. For more
        /// information, see the cpu content for the ContainerDefinition data type in the Amazon Elastic
        /// Container Service API Reference.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("Cpu")]
        public Union<int, IntrinsicFunction> Cpu { get; set; }

        /// <summary>
        /// DisableNetworking
        /// Indicates whether networking is disabled within the container.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("DisableNetworking")]
        public Union<bool, IntrinsicFunction> DisableNetworking { get; set; }

        /// <summary>
        /// DnsSearchDomains
        /// A list of DNS search domains that are provided to the container. The domain names that the DNS logic
        /// looks up when a process attempts to access a bare unqualified hostname.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("DnsSearchDomains")]
        public List<Union<string, IntrinsicFunction>> DnsSearchDomains { get; set; }

        /// <summary>
        /// DnsServers
        /// A list of DNS servers that Amazon ECS provides to the container.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("DnsServers")]
        public List<Union<string, IntrinsicFunction>> DnsServers { get; set; }

        /// <summary>
        /// DockerLabels
        /// A key-value map of labels for the container.
        /// Required: No
        /// Type: Key-value pairs, with the name of the label as the key and the label value as the value.
        /// </summary>
        [JsonProperty("DockerLabels")]
        public Dictionary<string, Union<string, IntrinsicFunction>> DockerLabels { get; set; }

        /// <summary>
        /// DockerSecurityOptions
        /// A list of custom labels for SELinux and AppArmor multi-level security systems. For more information,
        /// see the dockerSecurityOptions content for the ContainerDefinition data type in the Amazon Elastic
        /// Container Service API Reference.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("DockerSecurityOptions")]
        public List<Union<string, IntrinsicFunction>> DockerSecurityOptions { get; set; }

        /// <summary>
        /// EntryPoint
        /// The ENTRYPOINT value to pass to the container. For more information about the Docker ENTRYPOINT
        /// parameter, see https://docs. docker. com/engine/reference/builder/#entrypoint.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("EntryPoint")]
        public List<Union<string, IntrinsicFunction>> EntryPoint { get; set; }

        /// <summary>
        /// Environment
        /// The environment variables to pass to the container.
        /// Required: No
        /// Type: List of KeyValuePair property types
        /// </summary>
        [JsonProperty("Environment")]
        public List<KeyValuePair> Environment { get; set; }

        /// <summary>
        /// Essential
        /// Indicates whether the task stops if this container fails. If you specify true and the container
        /// fails, all other containers in the task stop. If you specify false and the container fails, none of
        /// the other containers in the task is affected. This value is true by default.
        /// You must have at least one essential container in a task.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Essential")]
        public Union<bool, IntrinsicFunction> Essential { get; set; }

        /// <summary>
        /// ExtraHosts
        /// A list of hostnames and IP address mappings to append to the /etc/hosts file on the container.
        /// Required: No
        /// Type: List of HostEntry property types
        /// </summary>
        [JsonProperty("ExtraHosts")]
        public List<HostEntry> ExtraHosts { get; set; }

        /// <summary>
        /// HealthCheck
        /// A container health check. Health check parameters that are specified in a container definition
        /// override any Docker health checks that exist in the container image (such as those specified in a
        /// parent image or from the image&#39;s Dockerfile).
        /// Required: No
        /// Type: HealthCheck
        /// </summary>
        [JsonProperty("HealthCheck")]
        public HealthCheck HealthCheck { get; set; }

        /// <summary>
        /// Hostname
        /// The name that Docker uses for the container hostname.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Hostname")]
        public Union<string, IntrinsicFunction> Hostname { get; set; }

        /// <summary>
        /// Image
        /// The image to use for a container. The image is passed directly to the Docker daemon. You can use
        /// images in the Docker Hub registry or specify other repositories (repository-url/image:tag).
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Image")]
        public Union<string, IntrinsicFunction> Image { get; set; }

        /// <summary>
        /// Links
        /// The name of another container to connect to. With links, containers can communicate with each other
        /// without using port mappings.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Links")]
        public List<Union<string, IntrinsicFunction>> Links { get; set; }

        /// <summary>
        /// LinuxParameters
        /// The Linux-specific options that are applied to the container.
        /// Required: No
        /// Type: LinuxParameters
        /// </summary>
        [JsonProperty("LinuxParameters")]
        public LinuxParameters LinuxParameters { get; set; }

        /// <summary>
        /// LogConfiguration
        /// Configures a custom log driver for the container. For more information, see the logConfiguration
        /// content for the ContainerDefinition data type in the Amazon Elastic Container Service API Reference.
        /// Required: No
        /// Type: LogConfiguration
        /// </summary>
        [JsonProperty("LogConfiguration")]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Memory
        /// The hard limit (in MiB) of memory to present to the container. If your container attempts to exceed
        /// the allocated memory, the container is terminated.
        /// Required: Conditional. You must specify one or both of the Memory or MemoryReservation properties.
        /// If you specify both, the value for the Memory property must be greater than the value of the
        /// MemoryReservation property.
        /// Type: Integer
        /// </summary>
        [JsonProperty("Memory")]
        public Union<int, IntrinsicFunction> Memory { get; set; }

        /// <summary>
        /// MemoryReservation
        /// The soft limit (in MiB) of memory to reserve for the container. When system memory is under
        /// contention, Docker attempts to keep the container memory within the limit. If the container requires
        /// more memory, it can consume up to the value specified by the Memory property or all of the available
        /// memory on the container instance—whichever comes first.
        /// Required: Conditional. You must specify one or both of the Memory or MemoryReservation properties.
        /// If you specify both, the value for the Memory property must be greater than the value of the
        /// MemoryReservation property.
        /// Type: Integer
        /// </summary>
        [JsonProperty("MemoryReservation")]
        public Union<int, IntrinsicFunction> MemoryReservation { get; set; }

        /// <summary>
        /// MountPoints
        /// The mount points for data volumes in the container.
        /// Required: No
        /// Type: List of MountPoint property types
        /// </summary>
        [JsonProperty("MountPoints")]
        public List<MountPoint> MountPoints { get; set; }

        /// <summary>
        /// Name
        /// A name for the container.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// PortMappings
        /// A mapping of the container port to a host port. Port mappings enable containers to access ports on
        /// the host container instance to send or receive traffic.
        /// Required: No
        /// Type: List of PortMapping property types
        /// </summary>
        [JsonProperty("PortMappings")]
        public List<PortMapping> PortMappings { get; set; }

        /// <summary>
        /// Privileged
        /// Indicates whether the container is given full access to the host container instance.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Privileged")]
        public Union<bool, IntrinsicFunction> Privileged { get; set; }

        /// <summary>
        /// ReadonlyRootFilesystem
        /// Indicates whether the container&#39;s root file system is mounted as read only.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("ReadonlyRootFilesystem")]
        public Union<bool, IntrinsicFunction> ReadonlyRootFilesystem { get; set; }

        /// <summary>
        /// RepositoryCredentials
        /// The repository credentials for private registry authentication.
        /// Required: No
        /// Type: RepositoryCredentials
        /// </summary>
        [JsonProperty("RepositoryCredentials")]
        public RepositoryCredentials RepositoryCredentials { get; set; }

        /// <summary>
        /// Ulimits
        /// A list of ulimits to set in the container. The ulimits set constraints on how many resources a
        /// container can consume so that it doesn&#39;t deplete all available resources on the host.
        /// Required: No
        /// Type: List of Ulimit property types
        /// </summary>
        [JsonProperty("Ulimits")]
        public List<Ulimit> Ulimits { get; set; }

        /// <summary>
        /// User
        /// The user name to use inside the container.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("User")]
        public Union<string, IntrinsicFunction> User { get; set; }

        /// <summary>
        /// VolumesFrom
        /// The data volumes to mount from another container.
        /// Required: No
        /// Type: List of VolumeFrom property types
        /// </summary>
        [JsonProperty("VolumesFrom")]
        public List<VolumeFrom> VolumesFrom { get; set; }

        /// <summary>
        /// WorkingDirectory
        /// The working directory in the container to run commands in.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("WorkingDirectory")]
        public Union<string, IntrinsicFunction> WorkingDirectory { get; set; }

    }
}
