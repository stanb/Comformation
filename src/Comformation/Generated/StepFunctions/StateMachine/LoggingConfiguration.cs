using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.StepFunctions.StateMachine
{
    /// <summary>
    /// AWS::StepFunctions::StateMachine LoggingConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-loggingconfiguration.html
    /// </summary>
    public class LoggingConfiguration
    {

        /// <summary>
        /// Level
        /// Defines which category of execution history events are logged.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Level")]
        public Union<string, IntrinsicFunction> Level { get; set; }

        /// <summary>
        /// IncludeExecutionData
        /// Determines whether execution data is included in your log. When set to false, data is excluded.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeExecutionData")]
        public Union<bool, IntrinsicFunction> IncludeExecutionData { get; set; }

        /// <summary>
        /// Destinations
        /// An array of objects that describes where your execution history events will be logged. Limited to
        /// size 1. Required, if your log level is not set to OFF.
        /// Required: No
        /// Type: List of LogDestination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destinations")]
        public List<LogDestination> Destinations { get; set; }

    }
}
