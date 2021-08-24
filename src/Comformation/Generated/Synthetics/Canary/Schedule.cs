using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Synthetics.Canary
{
    /// <summary>
    /// AWS::Synthetics::Canary Schedule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-schedule.html
    /// </summary>
    public class Schedule
    {

        /// <summary>
        /// Expression
        /// A rate expression or a cron expression that defines how often the canary is to run.
        /// For a rate expression, The syntax is rate(number unit). unit can be minute, minutes, or hour.
        /// For example, rate(1 minute) runs the canary once a minute, rate(10 minutes) runs it once every 10
        /// minutes, and rate(1 hour) runs it once every hour. You can specify a frequency between rate(1
        /// minute) and rate(1 hour).
        /// Specifying rate(0 minute) or rate(0 hour) is a special value that causes the canary to run only once
        /// when it is started.
        /// Use cron(expression) to specify a cron expression. You can&#39;t schedule a canary to wait for more than
        /// a year before running. For information about the syntax for cron expressions, see Scheduling canary
        /// runs using cron.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Expression")]
        public Union<string, IntrinsicFunction> Expression { get; set; }

        /// <summary>
        /// DurationInSeconds
        /// How long, in seconds, for the canary to continue making regular runs according to the schedule in
        /// the Expression value. If you specify 0, the canary continues making runs until you stop it. If you
        /// omit this field, the default of 0 is used.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DurationInSeconds")]
        public Union<string, IntrinsicFunction> DurationInSeconds { get; set; }

    }
}
