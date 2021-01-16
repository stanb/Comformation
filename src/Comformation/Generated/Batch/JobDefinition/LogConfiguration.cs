using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition LogConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-logconfiguration.html
    /// </summary>
    public class LogConfiguration
    {

        /// <summary>
        /// SecretOptions
        /// The secrets to pass to the log configuration. For more information, see Specifying Sensitive Data in
        /// the AWS Batch User Guide.
        /// Required: No
        /// Type: List of Secret
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretOptions")]
        public List<Secret> SecretOptions { get; set; }

        /// <summary>
        /// Options
        /// The configuration options to send to the log driver. This parameter requires version 1. 19 of the
        /// Docker Remote API or greater on your container instance. To check the Docker Remote API version on
        /// your container instance, log into your container instance and run the following command: sudo docker
        /// version | grep &quot;Server API version&quot;
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Options")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Options { get; set; }

        /// <summary>
        /// LogDriver
        /// The log driver to use for the container. The valid values listed for this parameter are log drivers
        /// that the Amazon ECS container agent can communicate with by default.
        /// The supported log drivers are awslogs, fluentd, gelf, json-file, journald, logentries, syslog, and
        /// splunk.
        /// Note Jobs running on Fargate resources are restricted to the awslogs and splunk log drivers.
        /// awslogs Specifies the Amazon CloudWatch Logs logging driver. For more information, see Using the
        /// awslogs Log Driver in the AWS Batch User Guide and Amazon CloudWatch Logs logging driver in the
        /// Docker documentation. fluentd Specifies the Fluentd logging driver. For more information, including
        /// usage and options, see Fluentd logging driver in the Docker documentation. gelf Specifies the
        /// Graylog Extended Format (GELF) logging driver. For more information, including usage and options,
        /// see Graylog Extended Format logging driver in the Docker documentation. journald Specifies the
        /// journald logging driver. For more information, including usage and options, see Journald logging
        /// driver in the Docker documentation. json-file Specifies the JSON file logging driver. For more
        /// information, including usage and options, see JSON File logging driver in the Docker documentation.
        /// splunk Specifies the Splunk logging driver. For more information, including usage and options, see
        /// Splunk logging driver in the Docker documentation. syslog Specifies the syslog logging driver. For
        /// more information, including usage and options, see Syslog logging driver in the Docker
        /// documentation.
        /// Note If you have a custom driver that&#39;sn&#39;t listed earlier that you want to work with the Amazon ECS
        /// container agent, you can fork the Amazon ECS container agent project that&#39;s available on GitHub and
        /// customize it to work with that driver. We encourage you to submit pull requests for changes that you
        /// want to have included. However, Amazon Web Services doesn&#39;t currently support running modified
        /// copies of this software.
        /// This parameter requires version 1. 18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log into your container
        /// instance and run the following command: sudo docker version | grep &quot;Server API version&quot;
        /// Required: Yes
        /// Type: String
        /// Allowed values: awslogs | fluentd | gelf | journald | json-file | splunk | syslog
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogDriver")]
        public Union<string, IntrinsicFunction> LogDriver { get; set; }

    }
}
