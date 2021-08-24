using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition Device
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-device.html
    /// </summary>
    public class Device
    {

        /// <summary>
        /// HostPath
        /// The path for the device on the host container instance.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HostPath")]
        public Union<string, IntrinsicFunction> HostPath { get; set; }

        /// <summary>
        /// Permissions
        /// The explicit permissions to provide to the container for the device. By default, the container has
        /// permissions for read, write, and mknod for the device.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Permissions")]
        public List<Union<string, IntrinsicFunction>> Permissions { get; set; }

        /// <summary>
        /// ContainerPath
        /// The path inside the container that&#39;s used to expose the host device. By default, the hostPath value
        /// is used.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContainerPath")]
        public Union<string, IntrinsicFunction> ContainerPath { get; set; }

    }
}
