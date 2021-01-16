using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.MonitoringSchedule
{
    /// <summary>
    /// AWS::SageMaker::MonitoringSchedule MonitoringInputs
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringinputs.html
    /// </summary>
    public class MonitoringInputs
    {

        /// <summary>
        /// MonitoringInputs_
        /// </summary>
        [JsonProperty("MonitoringInputs")]
        public List<MonitoringInput> MonitoringInputs_ { get; set; }

    }
}
