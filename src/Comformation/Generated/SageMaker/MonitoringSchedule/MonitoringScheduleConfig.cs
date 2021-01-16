using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.MonitoringSchedule
{
    /// <summary>
    /// AWS::SageMaker::MonitoringSchedule MonitoringScheduleConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringscheduleconfig.html
    /// </summary>
    public class MonitoringScheduleConfig
    {

        /// <summary>
        /// MonitoringJobDefinition
        /// Defines the monitoring job.
        /// Required: No
        /// Type: MonitoringJobDefinition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MonitoringJobDefinition")]
        public MonitoringJobDefinition MonitoringJobDefinition { get; set; }

        /// <summary>
        /// MonitoringJobDefinitionName
        /// The name of the monitoring job definition to schedule.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 63
        /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9])*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MonitoringJobDefinitionName")]
        public Union<string, IntrinsicFunction> MonitoringJobDefinitionName { get; set; }

        /// <summary>
        /// MonitoringType
        /// The type of the monitoring job definition to schedule.
        /// Required: No
        /// Type: String
        /// Allowed values: DataQuality | ModelBias | ModelExplainability | ModelQuality
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MonitoringType")]
        public Union<string, IntrinsicFunction> MonitoringType { get; set; }

        /// <summary>
        /// ScheduleConfig
        /// Configures the monitoring schedule.
        /// Required: No
        /// Type: ScheduleConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleConfig")]
        public ScheduleConfig ScheduleConfig { get; set; }

    }
}
