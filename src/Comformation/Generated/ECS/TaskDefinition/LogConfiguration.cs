using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition LogConfiguration
    /// The LogConfiguration property specifies log configuration options to send to a custom log driver for the
    /// container.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinitions-logconfiguration.html
    /// </summary>
    public class LogConfiguration
    {

        /// <summary>
        /// LogDriver
        /// The log driver to use for the container. The valid values listed for this parameter are log drivers
        /// that the Amazon ECS container agent can communicate with by default.
        /// For tasks using the Fargate launch type, the supported log drivers are awslogs and splunk.
        /// For tasks using the EC2 launch type, the supported log drivers are awslogs, fluentd, gelf,
        /// json-file, journald, logentries, syslog, and splunk.
        /// For more information about using the awslogs log driver, see Using the awslogs Log Driver in the
        /// Amazon Elastic Container Service Developer Guide.
        /// Note If you have a custom driver that is not listed above that you would like to work with the
        /// Amazon ECS container agent, you can fork the Amazon ECS container agent project that is available on
        /// GitHub and customize it to work with that driver. We encourage you to submit pull requests for
        /// changes that you would like to have included. However, Amazon Web Services does not currently
        /// support running modified copies of this software.
        /// This parameter requires version 1. 18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log in to your
        /// container instance and run the following command: sudo docker version --format &#39;{{. Server.
        /// APIVersion}}&#39;
        /// Required: Yes
        /// Type: String
        /// Allowed Values: awsfirelens | awslogs | fluentd | gelf | journald | json-file | splunk | syslog
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("LogDriver")]
        public Union<string, IntrinsicFunction> LogDriver { get; set; }

        /// <summary>
        /// Options
        /// The configuration options to send to the log driver. This parameter requires version 1. 19 of the
        /// Docker Remote API or greater on your container instance. To check the Docker Remote API version on
        /// your container instance, log in to your container instance and run the following command: sudo
        /// docker version --format &#39;{{. Server. APIVersion}}&#39;
        /// Required: No
        /// Type: Map of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Options")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Options { get; set; }

        /// <summary>
        /// SecretOptions
        /// The secrets to pass to the log configuration. For more information, see Specifying Sensitive Data in
        /// the Amazon Elastic Container Service Developer Guide.
        /// Required: No
        /// Type: List of Secret
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SecretOptions")]
        public List<Secret> SecretOptions { get; set; }

    }
}
