using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition EfsVolumeConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-efsvolumeconfiguration.html
    /// </summary>
    public class EfsVolumeConfiguration
    {

        /// <summary>
        /// TransitEncryption
        /// Determines whether to enable encryption for Amazon EFS data in transit between the Amazon ECS host
        /// and the Amazon EFS server. Transit encryption must be enabled if Amazon EFS IAM authorization is
        /// used. If this parameter is omitted, the default value of DISABLED is used. For more information, see
        /// Encrypting data in transit in the Amazon Elastic File System User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TransitEncryption")]
        public Union<string, IntrinsicFunction> TransitEncryption { get; set; }

        /// <summary>
        /// AuthorizationConfig
        /// The authorization configuration details for the Amazon EFS file system.
        /// Required: No
        /// Type: AuthorizationConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthorizationConfig")]
        public AuthorizationConfig AuthorizationConfig { get; set; }

        /// <summary>
        /// FileSystemId
        /// The Amazon EFS file system ID to use.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileSystemId")]
        public Union<string, IntrinsicFunction> FileSystemId { get; set; }

        /// <summary>
        /// RootDirectory
        /// The directory within the Amazon EFS file system to mount as the root directory inside the host. If
        /// this parameter is omitted, the root of the Amazon EFS volume is used instead. Specifying / has the
        /// same effect as omitting this parameter. The maximum length is 4,096 characters.
        /// Important If an EFS access point is specified in the authorizationConfig, the root directory
        /// parameter must either be omitted or set to /, which enforces the path set on the Amazon EFS access
        /// point.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RootDirectory")]
        public Union<string, IntrinsicFunction> RootDirectory { get; set; }

        /// <summary>
        /// TransitEncryptionPort
        /// The port to use when sending encrypted data between the Amazon ECS host and the Amazon EFS server.
        /// If you don&#39;t specify a transit encryption port, it uses the port selection strategy that the Amazon
        /// EFS mount helper uses. The value must be between 0 and 65,535. For more information, see EFS Mount
        /// Helper in the Amazon Elastic File System User Guide.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TransitEncryptionPort")]
        public Union<int, IntrinsicFunction> TransitEncryptionPort { get; set; }

    }
}
