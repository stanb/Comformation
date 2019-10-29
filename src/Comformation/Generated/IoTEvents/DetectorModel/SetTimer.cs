using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel SetTimer
    /// Information needed to set the timer.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-settimer.html
    /// </summary>
    public class SetTimer
    {

        /// <summary>
        /// Seconds
        /// The number of seconds until the timer expires. The minimum value is 60 seconds to ensure accuracy.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Seconds")]
        public Union<int, IntrinsicFunction> Seconds { get; set; }

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
