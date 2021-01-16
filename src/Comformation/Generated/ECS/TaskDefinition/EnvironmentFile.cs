using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition EnvironmentFile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-environmentfile.html
    /// </summary>
    public class EnvironmentFile
    {

        /// <summary>
        /// Value
        /// 		
        /// The Amazon Resource Name (ARN) of the Amazon S3 object containing the environment 			variable file.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Type
        /// 		
        /// The file type to use. The only supported value is s3.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: s3
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
