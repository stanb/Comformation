using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition LogConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinitions-logconfiguration.html
    /// </summary>
    public class LogConfiguration
    {

        /// <summary>
        /// LogDriver
        /// 		
        /// The log driver to use for the container.
        /// 		
        /// For tasks on AWS Fargate, the supported log drivers are awslogs, 				splunk, and awsfirelens.
        /// 		
        /// For tasks hosted on Amazon EC2 instances, the supported log drivers are 				awslogs, fluentd, gelf,
        /// 				json-file, journald, 				logentries,syslog, splunk, and 				awsfirelens.
        /// 		
        /// For more information about using the awslogs log driver, see Using 				the awslogs log driver in the
        /// Amazon Elastic Container Service Developer Guide.
        /// 		
        /// For more information about using the awsfirelens log driver, see Custom log routing in the Amazon
        /// Elastic Container Service Developer Guide.
        /// 		
        /// Note If you have a custom driver that is not listed, you can fork the Amazon ECS container 				agent
        /// project that is available 					on GitHub and customize it to work with that driver. We encourage you
        /// to 				submit pull requests for changes that you would like to have included. However, we 				do not
        /// currently provide support for running modified copies of this 				software.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: awsfirelens | awslogs | fluentd | gelf | journald | json-file | splunk | syslog
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LogDriver")]
        public Union<string, IntrinsicFunction> LogDriver { get; set; }

        /// <summary>
        /// Options
        /// 		
        /// The configuration options to send to the log driver. This parameter requires version 1. 19 of the
        /// Docker Remote API or greater on your container instance. To check the Docker Remote API version on
        /// your container instance, log in to your container instance and run the following command: sudo
        /// docker version --format &#39;{{. Server. APIVersion}}&#39;
        /// 	
        /// Required: No
        /// Type: Map of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Options")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Options { get; set; }

        /// <summary>
        /// SecretOptions
        /// 		
        /// The secrets to pass to the log configuration. For more information, see Specifying 				Sensitive
        /// Data in the Amazon Elastic Container Service Developer Guide.
        /// 	
        /// Required: No
        /// Type: List of Secret
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SecretOptions")]
        public List<Secret> SecretOptions { get; set; }

    }
}
