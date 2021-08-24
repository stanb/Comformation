using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppRunner.Service
{
    /// <summary>
    /// AWS::AppRunner::Service HealthCheckConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-healthcheckconfiguration.html
    /// </summary>
    public class HealthCheckConfiguration
    {

        /// <summary>
        /// Protocol
        /// The IP protocol that App Runner uses to perform health checks for your service.
        /// If you set Protocol to HTTP, App Runner sends health check requests to the HTTP path specified by
        /// Path.
        /// Default: TCP
        /// Required: No
        /// Type: String
        /// Allowed values: HTTP | TCP
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// Path
        /// The URL that health check requests are sent to.
        /// Path is only applicable when you set Protocol to HTTP.
        /// Default: &quot;/&quot;
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Path")]
        public Union<string, IntrinsicFunction> Path { get; set; }

        /// <summary>
        /// Interval
        /// The time interval, in seconds, between health checks.
        /// Default: 5
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 20
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Interval")]
        public Union<int, IntrinsicFunction> Interval { get; set; }

        /// <summary>
        /// Timeout
        /// The time, in seconds, to wait for a health check response before deciding it failed.
        /// Default: 2
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 20
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Timeout")]
        public Union<int, IntrinsicFunction> Timeout { get; set; }

        /// <summary>
        /// HealthyThreshold
        /// The number of consecutive checks that must succeed before App Runner decides that the service is
        /// healthy.
        /// Default: 1
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 20
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HealthyThreshold")]
        public Union<int, IntrinsicFunction> HealthyThreshold { get; set; }

        /// <summary>
        /// UnhealthyThreshold
        /// The number of consecutive checks that must fail before App Runner decides that the service is
        /// unhealthy.
        /// Default: 5
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 20
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UnhealthyThreshold")]
        public Union<int, IntrinsicFunction> UnhealthyThreshold { get; set; }

    }
}
