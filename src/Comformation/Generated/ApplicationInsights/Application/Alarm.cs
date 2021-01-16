using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationInsights.Application
{
    /// <summary>
    /// AWS::ApplicationInsights::Application Alarm
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-alarm.html
    /// </summary>
    public class Alarm
    {

        /// <summary>
        /// AlarmName
        /// The name of the CloudWatch alarm to be monitored for the component.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AlarmName")]
        public Union<string, IntrinsicFunction> AlarmName { get; set; }

        /// <summary>
        /// Severity
        /// Indicates the degree of outage when the alarm goes off.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Severity")]
        public Union<string, IntrinsicFunction> Severity { get; set; }

    }
}
