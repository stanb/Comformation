using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition EFSVolumeConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-efsvolumeconfiguration.html
    /// </summary>
    public class EFSVolumeConfiguration
    {

        /// <summary>
        /// FilesystemId
        /// 		
        /// The Amazon EFS file system ID to use.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("FilesystemId")]
        public Union<string, IntrinsicFunction> FilesystemId { get; set; }

        /// <summary>
        /// RootDirectory
        /// 		
        /// The directory within the Amazon EFS file system to mount as the root directory inside the 			host.
        /// If this parameter is omitted, the root of the Amazon EFS volume will be used. 			Specifying / will
        /// have the same effect as omitting this parameter.
        /// 		
        /// Important If an EFS access point is specified in the authorizationConfig, the 				root directory
        /// parameter must either be omitted or set to / which will 				enforce the path set on the EFS access
        /// point.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RootDirectory")]
        public Union<string, IntrinsicFunction> RootDirectory { get; set; }

        /// <summary>
        /// TransitEncryption
        /// 		
        /// Whether or not to enable encryption for Amazon EFS data in transit between the Amazon ECS host
        /// 			and the Amazon EFS server. Transit encryption must be enabled if Amazon EFS IAM authorization is
        /// 			used. If this parameter is omitted, the default value of DISABLED is used. 			For more
        /// information, see Encrypting Data in Transit in 			the Amazon Elastic File System User Guide.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: DISABLED | ENABLED
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TransitEncryption")]
        public Union<string, IntrinsicFunction> TransitEncryption { get; set; }

        /// <summary>
        /// TransitEncryptionPort
        /// 		
        /// The port to use when sending encrypted data between the Amazon ECS host and the Amazon EFS
        /// 			server. If you do not specify a transit encryption port, it will use the port selection
        /// 			strategy that the Amazon EFS mount helper uses. For more information, see EFS Mount 				Helper in
        /// the Amazon Elastic File System User Guide.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TransitEncryptionPort")]
        public Union<int, IntrinsicFunction> TransitEncryptionPort { get; set; }

        /// <summary>
        /// AuthorizationConfig
        /// 		
        /// The authorization configuration details for the Amazon EFS file system.
        /// 	
        /// Required: No
        /// Type: AuthorizationConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AuthorizationConfig")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AuthorizationConfig { get; set; }

    }
}
