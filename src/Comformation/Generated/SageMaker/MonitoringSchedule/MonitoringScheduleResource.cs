using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.MonitoringSchedule
{
    /// <summary>
    /// AWS::SageMaker::MonitoringSchedule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-monitoringschedule.html
    /// </summary>
    public class MonitoringScheduleResource : ResourceBase
    {
        public class MonitoringScheduleProperties
        {
            /// <summary>
            /// MonitoringScheduleName
            /// The name of the monitoring schedule.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MonitoringScheduleName { get; set; }

            /// <summary>
            /// MonitoringScheduleConfig
            /// The configuration object that specifies the monitoring schedule and defines the monitoring job.
            /// Required: Yes
            /// Type: MonitoringScheduleConfig
            /// Update requires: No interruption
            /// </summary>
            public MonitoringScheduleConfig MonitoringScheduleConfig { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// EndpointName
            /// The name of the endpoint using the monitoring schedule.
            /// Required: No
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EndpointName { get; set; }

            /// <summary>
            /// FailureReason
            /// Contains the reason a monitoring job failed, if it failed.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FailureReason { get; set; }

            /// <summary>
            /// LastMonitoringExecutionSummary
            /// Describes metadata on the last execution to run, if there was one.
            /// Required: No
            /// Type: MonitoringExecutionSummary
            /// Update requires: No interruption
            /// </summary>
            public MonitoringExecutionSummary LastMonitoringExecutionSummary { get; set; }

            /// <summary>
            /// MonitoringScheduleStatus
            /// The status of the monitoring schedule.
            /// Required: No
            /// Type: String
            /// Allowed values: Failed | Pending | Scheduled | Stopped
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MonitoringScheduleStatus { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::MonitoringSchedule";

        public MonitoringScheduleProperties Properties { get; } = new MonitoringScheduleProperties();

    }

    public static class MonitoringScheduleAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MonitoringScheduleArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("MonitoringScheduleArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastModifiedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastModifiedTime");
    }
}
