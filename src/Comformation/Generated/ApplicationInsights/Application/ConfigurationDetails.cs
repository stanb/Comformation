using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationInsights.Application
{
    /// <summary>
    /// AWS::ApplicationInsights::Application ConfigurationDetails
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-configurationdetails.html
    /// </summary>
    public class ConfigurationDetails
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

        /// <summary>
        /// Alarms
        /// A list of alarms to monitor for the component. All component types can use Alarm.
        /// Required: No
        /// Type: List of Alarm
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Alarms")]
        public List<Alarm> Alarms { get; set; }

        /// <summary>
        /// JMXPrometheusExporter
        /// A list of Java metrics to monitor for the component.
        /// Required: No
        /// Type: JMXPrometheusExporter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JMXPrometheusExporter")]
        public JMXPrometheusExporter JMXPrometheusExporter { get; set; }

    }
}
