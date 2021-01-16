using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Trigger
{
    /// <summary>
    /// AWS::Glue::Trigger Action
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// NotificationProperty
        /// Specifies configuration properties of a job run notification.
        /// Required: No
        /// Type: NotificationProperty
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationProperty")]
        public NotificationProperty NotificationProperty { get; set; }

        /// <summary>
        /// CrawlerName
        /// The name of the crawler to be used with this action.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CrawlerName")]
        public Union<string, IntrinsicFunction> CrawlerName { get; set; }

        /// <summary>
        /// Timeout
        /// The JobRun timeout in minutes. This is the maximum time that a job run can consume resources before
        /// it is terminated and enters TIMEOUT status. The default is 2,880 minutes (48 hours). This overrides
        /// the timeout value set in the parent job.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Timeout")]
        public Union<int, IntrinsicFunction> Timeout { get; set; }

        /// <summary>
        /// JobName
        /// The name of a job to be executed.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JobName")]
        public Union<string, IntrinsicFunction> JobName { get; set; }

        /// <summary>
        /// Arguments
        /// The job arguments used when this trigger fires. For this job run, they replace the default arguments
        /// set in the job definition itself.
        /// You can specify arguments here that your own job-execution script consumes, in addition to arguments
        /// that AWS Glue itself consumes.
        /// For information about how to specify and consume your own job arguments, see Calling AWS Glue APIs
        /// in Python in the AWS Glue Developer Guide.
        /// For information about the key-value pairs that AWS Glue consumes to set up your job, see the Special
        /// Parameters Used by AWS Glue topic in the developer guide.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arguments")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Arguments { get; set; }

        /// <summary>
        /// SecurityConfiguration
        /// The name of the SecurityConfiguration structure to be used with this action.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecurityConfiguration")]
        public Union<string, IntrinsicFunction> SecurityConfiguration { get; set; }

    }
}
