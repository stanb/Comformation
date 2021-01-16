using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.MonitoringSchedule
{
    /// <summary>
    /// AWS::SageMaker::MonitoringSchedule MonitoringInput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringinput.html
    /// </summary>
    public class MonitoringInput
    {

        /// <summary>
        /// EndpointInput
        /// The endpoint for a monitoring job.
        /// Required: Yes
        /// Type: EndpointInput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndpointInput")]
        public EndpointInput EndpointInput { get; set; }

    }
}
