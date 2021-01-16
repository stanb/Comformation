using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.MonitoringSchedule
{
    /// <summary>
    /// AWS::SageMaker::MonitoringSchedule StoppingCondition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-stoppingcondition.html
    /// </summary>
    public class StoppingCondition
    {

        /// <summary>
        /// MaxRuntimeInSeconds
        /// The maximum length of time, in seconds, that the training or compilation job can run. If job does
        /// not complete during this time, Amazon SageMaker ends the job. If value is not specified, default
        /// value is 1 day. The maximum value is 28 days.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxRuntimeInSeconds")]
        public Union<int, IntrinsicFunction> MaxRuntimeInSeconds { get; set; }

    }
}
