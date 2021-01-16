using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationInsights.Application
{
    /// <summary>
    /// AWS::ApplicationInsights::Application LogPattern
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-logpattern.html
    /// </summary>
    public class LogPattern
    {

        /// <summary>
        /// PatternName
        /// The name of the log pattern. A log pattern name can contain up to 50 characters, and it cannot be
        /// empty. The characters can be Unicode letters, digits, or one of the following symbols: period, dash,
        /// underscore.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 50
        /// Pattern: [a-zA-Z0-9\. \-_]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PatternName")]
        public Union<string, IntrinsicFunction> PatternName { get; set; }

        /// <summary>
        /// Pattern
        /// A regular expression that defines the log pattern. A log pattern can contain up to 50 characters,
        /// and it cannot be empty.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 50
        /// Pattern: [\S\s]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Pattern")]
        public Union<string, IntrinsicFunction> Pattern { get; set; }

        /// <summary>
        /// Rank
        /// The rank of the log pattern.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rank")]
        public Union<int, IntrinsicFunction> Rank { get; set; }

    }
}
