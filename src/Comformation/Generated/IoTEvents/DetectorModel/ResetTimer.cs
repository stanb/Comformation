using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel ResetTimer
    /// Information needed to reset the timer.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-resettimer.html
    /// </summary>
    public class ResetTimer
    {

        /// <summary>
        /// TimerName
        /// The name of the timer.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimerName")]
        public Union<string, IntrinsicFunction> TimerName { get; set; }

    }
}
