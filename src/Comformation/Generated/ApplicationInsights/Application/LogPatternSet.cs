using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationInsights.Application
{
    /// <summary>
    /// AWS::ApplicationInsights::Application LogPatternSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-logpatternset.html
    /// </summary>
    public class LogPatternSet
    {

        /// <summary>
        /// PatternSetName
        /// The name of the log pattern. A log pattern name can contain up to 30 characters, and it cannot be
        /// empty. The characters can be Unicode letters, digits, or one of the following symbols: period, dash,
        /// underscore.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 30
        /// Pattern: [a-zA-Z0-9\. \-_]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PatternSetName")]
        public Union<string, IntrinsicFunction> PatternSetName { get; set; }

        /// <summary>
        /// LogPatterns
        /// A list of objects that define the log patterns that belong to LogPatternSet.
        /// Required: Yes
        /// Type: List of LogPattern
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogPatterns")]
        public List<LogPattern> LogPatterns { get; set; }

    }
}
