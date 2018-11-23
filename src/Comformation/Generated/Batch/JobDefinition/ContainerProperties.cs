using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS Batch JobDefinition ContainerProperties
    /// The ContainerProperties property type specifies various properties specific to container-based jobs.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html
    /// </summary>
    public class ContainerProperties
    {

        /// <summary>
        /// User
        /// The user name to use inside the container. This parameter maps to User in the Create a container
        /// section of the Docker Remote API and the --user option to docker run.
        /// Required: no
        /// Type: String
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("User")]
        public Union<string, IntrinsicFunction> User { get; set; }

        /// <summary>
        /// Memory
        /// The hard limit (in MiB) of memory to present to the container. If your container attempts to exceed
        /// the memory specified here, the container is killed. This parameter maps to Memory in the Create a
        /// container section of the Docker Remote API and the --memory option to docker run.
        /// Required: yes
        /// Type: Integer
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Memory")]
        public Union<int, IntrinsicFunction> Memory { get; set; }

        /// <summary>
        /// Privileged
        /// When this parameter is true, the container is given elevated privileges on the host container
        /// instance (similar to the root user). This parameter maps to Privileged in the Create a container
        /// section of the Docker Remote API and the --privileged option to docker run.
        /// Required: no
        /// Type: Boolean
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Privileged")]
        public Union<bool, IntrinsicFunction> Privileged { get; set; }

        /// <summary>
        /// JobRoleArn
        /// The Amazon Resource Name (ARN) of the IAM role that the container can assume for AWS permissions.
        /// Required: no
        /// Type: String
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("JobRoleArn")]
        public Union<string, IntrinsicFunction> JobRoleArn { get; set; }

        /// <summary>
        /// ReadonlyRootFilesystem
        /// When this parameter is true, the container is given read-only access to its root file system. This
        /// parameter maps to ReadonlyRootfs in the Create a container section of the Docker Remote API and the
        /// --read-only option to docker run.
        /// Required: no
        /// Type: Boolean
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("ReadonlyRootFilesystem")]
        public Union<bool, IntrinsicFunction> ReadonlyRootFilesystem { get; set; }

        /// <summary>
        /// Vcpus
        /// The number of vCPUs reserved for the container. This parameter maps to CpuShares in the Create a
        /// container section of the Docker Remote API and the --cpu-shares option to docker run. Each vCPU is
        /// equivalent to 1,024 CPU shares.
        /// Required: yes
        /// Type: Integer
        /// Update requires: No Interruption
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
        /// Images in Amazon ECR repositories use the full registry and repository URI (for example,
        /// 012345678910. dkr. ecr. region-name. amazonaws. com/repository-name). Images in official
        /// repositories on Docker Hub use a single name (for example, ubuntu or mongo). Images in other
        /// repositories on Docker Hub are qualified with an organization name (for example,
        /// amazon/amazon-ecs-agent). Images in other online repositories are qualified further by a domain name
        /// (for example, quay. io/assemblyline/ubuntu).
        /// Required: yes
        /// Type: String
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Image")]
        public Union<string, IntrinsicFunction> Image { get; set; }

        /// <summary>
        /// MountPoints
        /// The mount points for data volumes in your container. This parameter maps to Volumes in the Create a
        /// container section of the Docker Remote API and the --volume option to docker run.
        /// Required: no
        /// Type: List of AWS Batch JobDefinition MountPoints
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("MountPoints")]
        public List<MountPoints> MountPoints { get; set; }

        /// <summary>
        /// Volumes
        /// A list of data volumes used in a job.
        /// Required: no
        /// Type: List of AWS Batch JobDefinition Volumes
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Volumes")]
        public List<Volumes> Volumes { get; set; }

        /// <summary>
        /// Command
        /// The command that is passed to the container. This parameter maps to Cmd in the Create a container
        /// section of the Docker Remote API and the COMMAND parameter to docker run.
        /// Required: no
        /// Type: List of String values
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Command")]
        public List<Union<string, IntrinsicFunction>> Command { get; set; }

        /// <summary>
        /// Environment
        /// The environment variables to pass to a container. This parameter maps to Env in the Create a
        /// container section of the Docker Remote API and the --env option to docker run.
        /// Important We do not recommend using plain text environment variables for sensitive information, such
        /// as credential data.
        /// Required: no
        /// Type: List of AWS Batch JobDefinition Environment
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Environment")]
        public List<Environment> Environment { get; set; }

        /// <summary>
        /// Ulimits
        /// A list of ulimits to set in the container. This parameter maps to Ulimits in the Create a container
        /// section of the Docker Remote API and the --ulimit option to docker run.
        /// Required: no
        /// Type: List of AWS Batch JobDefinition Ulimit
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Ulimits")]
        public List<Ulimit> Ulimits { get; set; }

        /// <summary>
        /// InstanceType
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

    }
}
