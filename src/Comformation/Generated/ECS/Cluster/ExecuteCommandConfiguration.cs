using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Cluster
{
    /// <summary>
    /// AWS::ECS::Cluster ExecuteCommandConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-executecommandconfiguration.html
    /// </summary>
    public class ExecuteCommandConfiguration
    {

        /// <summary>
        /// KmsKeyId
        /// 		
        /// Specify an AWS Key Management Service key ID to encrypt the data between the local client 			and the
        /// container.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

        /// <summary>
        /// Logging
        /// 		
        /// The log setting to use for redirecting logs for your execute command results. The 			following log
        /// settings are available.
        /// 		
        /// 			 			 			 		 				 NONE: The execute command session is not logged. 			 				 DEFAULT: The awslogs
        /// configuration in the task 					definition is used. If no logging parameter is specified, it defaults
        /// to this 					value. If no awslogs log driver is configured in the task 					definition, the output
        /// won&#39;t be logged. 			 				 OVERRIDE: Specify the logging details as a part of 						logConfiguration.
        /// If the OVERRIDE logging option 					is specified, the logConfiguration is required. 			
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: DEFAULT | NONE | OVERRIDE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Logging")]
        public Union<string, IntrinsicFunction> Logging { get; set; }

        /// <summary>
        /// LogConfiguration
        /// 		
        /// The log configuration for the results of the execute command actions. The logs can be 			sent to
        /// CloudWatch Logs or an Amazon S3 bucket. When logging=OVERRIDE is 			specified, a logConfiguration
        /// must be provided.
        /// 	
        /// Required: No
        /// Type: ExecuteCommandLogConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogConfiguration")]
        public ExecuteCommandLogConfiguration LogConfiguration { get; set; }

    }
}
