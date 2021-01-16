using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.MonitoringSchedule
{
    /// <summary>
    /// AWS::SageMaker::MonitoringSchedule BaselineConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-baselineconfig.html
    /// </summary>
    public class BaselineConfig
    {

        /// <summary>
        /// ConstraintsResource
        /// The Amazon S3 URI for the constraints resource.
        /// Required: No
        /// Type: ConstraintsResource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConstraintsResource")]
        public ConstraintsResource ConstraintsResource { get; set; }

        /// <summary>
        /// StatisticsResource
        /// The baseline statistics file in Amazon S3 that the current monitoring job should be validated
        /// against.
        /// Required: No
        /// Type: StatisticsResource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatisticsResource")]
        public StatisticsResource StatisticsResource { get; set; }

    }
}
