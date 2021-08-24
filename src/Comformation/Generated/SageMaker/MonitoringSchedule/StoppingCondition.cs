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
        /// The maximum length of time, in seconds, that a training or compilation job can run.
        /// For compilation jobs, if the job does not complete during this time, you will receive a TimeOut
        /// error. We recommend starting with 900 seconds and increase as necessary based on your model.
        /// For all other jobs, if the job does not complete during this time, Amazon SageMaker ends the job.
        /// When RetryStrategy is specified in the job request, MaxRuntimeInSeconds specifies the maximum time
        /// for all of the attempts in total, not each individual attempt. The default value is 1 day. The
        /// maximum value is 28 days.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxRuntimeInSeconds")]
        public Union<int, IntrinsicFunction> MaxRuntimeInSeconds { get; set; }

    }
}
