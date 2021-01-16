using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationInsights.Application
{
    /// <summary>
    /// AWS::ApplicationInsights::Application JMXPrometheusExporter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-jmxprometheusexporter.html
    /// </summary>
    public class JMXPrometheusExporter
    {

        /// <summary>
        /// JMXURL
        /// The complete JMX URL to connect to.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JMXURL")]
        public Union<string, IntrinsicFunction> JMXURL { get; set; }

        /// <summary>
        /// HostPort
        /// The host and port to connect to through remote JMX. Only one of jmxURL and hostPort can be
        /// specified.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HostPort")]
        public Union<string, IntrinsicFunction> HostPort { get; set; }

        /// <summary>
        /// PrometheusPort
        /// The target port to send Prometheus metrics to. If not specified, the default port 9404 is used.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrometheusPort")]
        public Union<string, IntrinsicFunction> PrometheusPort { get; set; }

    }
}
