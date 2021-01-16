using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.MonitoringSchedule
{
    /// <summary>
    /// AWS::SageMaker::MonitoringSchedule MonitoringExecutionSummary
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringexecutionsummary.html
    /// </summary>
    public class MonitoringExecutionSummary
    {

        /// <summary>
        /// CreationTime
        /// The time at which the monitoring job was created.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreationTime")]
        public Union<string, IntrinsicFunction> CreationTime { get; set; }

        /// <summary>
        /// EndpointName
        /// The name of the endpoint used to run the monitoring job.
        /// Required: No
        /// Type: String
        /// Maximum: 63
        /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndpointName")]
        public Union<string, IntrinsicFunction> EndpointName { get; set; }

        /// <summary>
        /// FailureReason
        /// Contains the reason a monitoring job failed, if it failed.
        /// Required: No
        /// Type: String
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FailureReason")]
        public Union<string, IntrinsicFunction> FailureReason { get; set; }

        /// <summary>
        /// LastModifiedTime
        /// A timestamp that indicates the last time the monitoring job was modified.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LastModifiedTime")]
        public Union<string, IntrinsicFunction> LastModifiedTime { get; set; }

        /// <summary>
        /// MonitoringExecutionStatus
        /// The status of the monitoring job.
        /// Required: Yes
        /// Type: String
        /// Allowed values: Completed | CompletedWithViolations | Failed | InProgress | Pending | Stopped |
        /// Stopping
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MonitoringExecutionStatus")]
        public Union<string, IntrinsicFunction> MonitoringExecutionStatus { get; set; }

        /// <summary>
        /// MonitoringScheduleName
        /// The name of the monitoring schedule.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 63
        /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MonitoringScheduleName")]
        public Union<string, IntrinsicFunction> MonitoringScheduleName { get; set; }

        /// <summary>
        /// ProcessingJobArn
        /// The Amazon Resource Name (ARN) of the monitoring job.
        /// Required: No
        /// Type: String
        /// Maximum: 256
        /// Pattern: arn:aws[a-z\-]*:sagemaker:[a-z0-9\-]*:[0-9]{12}:processing-job/. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProcessingJobArn")]
        public Union<string, IntrinsicFunction> ProcessingJobArn { get; set; }

        /// <summary>
        /// ScheduledTime
        /// The time the monitoring job was scheduled.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduledTime")]
        public Union<string, IntrinsicFunction> ScheduledTime { get; set; }

    }
}
