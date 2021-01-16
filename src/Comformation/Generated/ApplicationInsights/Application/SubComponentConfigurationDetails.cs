using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationInsights.Application
{
    /// <summary>
    /// AWS::ApplicationInsights::Application SubComponentConfigurationDetails
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-subcomponentconfigurationdetails.html
    /// </summary>
    public class SubComponentConfigurationDetails
    {

        /// <summary>
        /// AlarmMetrics
        /// A list of metrics to monitor for the component. All component types can use AlarmMetrics.
        /// Required: No
        /// Type: List of AlarmMetric
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AlarmMetrics")]
        public List<AlarmMetric> AlarmMetrics { get; set; }

        /// <summary>
        /// Logs
        /// A list of logs to monitor for the component. Only Amazon EC2 instances can use Logs.
        /// Required: No
        /// Type: List of Log
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Logs")]
        public List<Log> Logs { get; set; }

        /// <summary>
        /// WindowsEvents
        /// A list of Windows Events to monitor for the component. Only Amazon EC2 instances running on Windows
        /// can use WindowsEvents.
        /// Required: No
        /// Type: List of WindowsEvent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WindowsEvents")]
        public List<WindowsEvent> WindowsEvents { get; set; }

    }
}
