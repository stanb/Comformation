using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset Filter
    /// Information which is used to filter message data, to segregate it according to the time frame in which it
    /// arrives.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-filter.html
    /// </summary>
    public class Filter
    {

        /// <summary>
        /// DeltaTime
        /// Used to limit data to that which has arrived since the last execution of the action.
        /// Required: No
        /// Type: DeltaTime
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeltaTime")]
        public DeltaTime DeltaTime { get; set; }

    }
}
