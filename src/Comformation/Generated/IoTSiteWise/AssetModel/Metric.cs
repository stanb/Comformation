using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AssetModel
{
    /// <summary>
    /// AWS::IoTSiteWise::AssetModel Metric
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-assetmodel-metric.html
    /// </summary>
    public class Metric
    {

        /// <summary>
        /// Expression
        /// The mathematical expression that defines the metric aggregation function. You can specify up to 10
        /// variables per expression. You can specify up to 10 functions per expression.
        /// For more information, see Quotas in the AWS IoT SiteWise User Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Expression")]
        public Union<string, IntrinsicFunction> Expression { get; set; }

        /// <summary>
        /// Variables
        /// The list of variables used in the expression.
        /// Required: Yes
        /// Type: List of ExpressionVariable
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Variables")]
        public List<ExpressionVariable> Variables { get; set; }

        /// <summary>
        /// Window
        /// The window (time interval) over which AWS IoT SiteWise computes the metric&#39;s aggregation expression.
        /// AWS IoT SiteWise computes one data point per window.
        /// Required: Yes
        /// Type: MetricWindow
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Window")]
        public MetricWindow Window { get; set; }

    }
}
