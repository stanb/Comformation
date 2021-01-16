using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationInsights.Application
{
    /// <summary>
    /// AWS::ApplicationInsights::Application AlarmMetric
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-alarmmetric.html
    /// </summary>
    public class AlarmMetric
    {

        /// <summary>
        /// AlarmMetricName
        /// The name of the metric to be monitored for the component. For metrics supported by Application
        /// Insights, see Logs and metrics supported by Amazon CloudWatch Application Insights.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AlarmMetricName")]
        public Union<string, IntrinsicFunction> AlarmMetricName { get; set; }

    }
}
