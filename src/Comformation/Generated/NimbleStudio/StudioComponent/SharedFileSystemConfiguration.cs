using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NimbleStudio.StudioComponent
{
    /// <summary>
    /// AWS::NimbleStudio::StudioComponent SharedFileSystemConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-nimblestudio-studiocomponent-sharedfilesystemconfiguration.html
    /// </summary>
    public class SharedFileSystemConfiguration
    {

        /// <summary>
        /// Endpoint
        /// The endpoint of the shared file system that is accessed by the studio component resource.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Endpoint")]
        public Union<string, IntrinsicFunction> Endpoint { get; set; }

        /// <summary>
        /// FileSystemId
        /// The unique identifier for a file system.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileSystemId")]
        public Union<string, IntrinsicFunction> FileSystemId { get; set; }

        /// <summary>
        /// LinuxMountPoint
        /// The mount location for a shared file system on a Linux virtual workstation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LinuxMountPoint")]
        public Union<string, IntrinsicFunction> LinuxMountPoint { get; set; }

        /// <summary>
        /// ShareName
        /// The name of the file share.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ShareName")]
        public Union<string, IntrinsicFunction> ShareName { get; set; }

        /// <summary>
        /// WindowsMountDrive
        /// The mount location for a shared file system on a Windows virtual workstation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WindowsMountDrive")]
        public Union<string, IntrinsicFunction> WindowsMountDrive { get; set; }

    }
}
