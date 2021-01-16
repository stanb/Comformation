using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition AuthorizationConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-authorizationconfig.html
    /// </summary>
    public class AuthorizationConfig
    {

        /// <summary>
        /// IAM
        /// 		
        /// Whether or not to use the Amazon ECS task IAM role defined in a task definition when 			mounting the
        /// Amazon EFS file system. If enabled, transit encryption must be enabled in the
        /// 				EFSVolumeConfiguration. If this parameter is omitted, the default value 			of DISABLED is used.
        /// For more information, see Using 				Amazon EFS Access Points in the Amazon Elastic Container Service
        /// Developer Guide.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: DISABLED | ENABLED
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("IAM")]
        public Union<string, IntrinsicFunction> IAM { get; set; }

        /// <summary>
        /// AccessPointId
        /// 		
        /// The Amazon EFS access point ID to use. If an access point is specified, the root directory 			value
        /// specified in the EFSVolumeConfiguration must either be omitted or set 			to / which will enforce the
        /// path set on the EFS access point. If an access 			point is used, transit encryption must be enabled
        /// in the 				EFSVolumeConfiguration. For more information, see Working with Amazon 				EFS Access
        /// Points in the Amazon Elastic File System User Guide.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AccessPointId")]
        public Union<string, IntrinsicFunction> AccessPointId { get; set; }

    }
}
