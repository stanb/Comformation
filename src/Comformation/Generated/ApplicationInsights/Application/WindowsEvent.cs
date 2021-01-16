using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationInsights.Application
{
    /// <summary>
    /// AWS::ApplicationInsights::Application WindowsEvent
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-windowsevent.html
    /// </summary>
    public class WindowsEvent
    {

        /// <summary>
        /// LogGroupName
        /// The CloudWatch log group name to be associated with the monitored log.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogGroupName")]
        public Union<string, IntrinsicFunction> LogGroupName { get; set; }

        /// <summary>
        /// EventName
        /// The type of Windows Events to log, equivalent to the Windows Event log channel name. For example,
        /// System, Security, CustomEventName, and so on. This field is required for each type of Windows event
        /// to log.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventName")]
        public Union<string, IntrinsicFunction> EventName { get; set; }

        /// <summary>
        /// EventLevels
        /// The levels of event to log. You must specify each level to log. Possible values include INFORMATION,
        /// WARNING, ERROR, CRITICAL, and VERBOSE. This field is required for each type of Windows Event to log.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventLevels")]
        public List<Union<string, IntrinsicFunction>> EventLevels { get; set; }

        /// <summary>
        /// PatternSet
        /// The log pattern set.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PatternSet")]
        public Union<string, IntrinsicFunction> PatternSet { get; set; }

    }
}
