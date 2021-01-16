using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AssetModel
{
    /// <summary>
    /// AWS::IoTSiteWise::AssetModel TumblingWindow
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-tumblingwindow.html
    /// </summary>
    public class TumblingWindow
    {

        /// <summary>
        /// Interval
        /// The time interval for the tumbling window. Note that w represents weeks, d represents days, h
        /// represents hours, and m represents minutes. AWS IoT SiteWise computes the 1w interval the end of
        /// Sunday at midnight each week (UTC), the 1d interval at the end of each day at midnight (UTC), the 1h
        /// interval at the end of each hour, and so on.
        /// When AWS IoT SiteWise aggregates data points for metric computations, the start of each interval is
        /// exclusive and the end of each interval is inclusive. AWS IoT SiteWise places the computed data point
        /// at the end of the interval.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Interval")]
        public Union<string, IntrinsicFunction> Interval { get; set; }

    }
}
