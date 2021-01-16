using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AssetModel
{
    /// <summary>
    /// AWS::IoTSiteWise::AssetModel MetricWindow
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-metricwindow.html
    /// </summary>
    public class MetricWindow
    {

        /// <summary>
        /// Tumbling
        /// The tumbling time interval window.
        /// Required: No
        /// Type: TumblingWindow
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tumbling")]
        public TumblingWindow Tumbling { get; set; }

    }
}
