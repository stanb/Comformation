using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition FirelensConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-firelensconfiguration.html
    /// </summary>
    public class FirelensConfiguration
    {

        /// <summary>
        /// Type
        /// 		
        /// The log router to use. The valid values are fluentd or 				fluentbit.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: fluentbit | fluentd
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Options
        /// The options to use when configuring the log router. This field is optional and can be used to add
        /// additional metadata, such as the task, task definition, cluster, and container instance details to
        /// the log event.
        /// If specified, valid option keys are:
        /// enable-ecs-log-metadata, which can be true or false config-file-type, which can be s3 or file
        /// config-file-value, which is either an S3 ARN or a file path
        /// Required: No
        /// Type: Map of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Options")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Options { get; set; }

    }
}
