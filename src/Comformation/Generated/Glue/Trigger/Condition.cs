using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Trigger
{
    /// <summary>
    /// AWS::Glue::Trigger Condition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-condition.html
    /// </summary>
    public class Condition
    {

        /// <summary>
        /// CrawlerName
        /// The name of the crawler to which this condition applies.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CrawlerName")]
        public Union<string, IntrinsicFunction> CrawlerName { get; set; }

        /// <summary>
        /// State
        /// The condition state. Currently, the values supported are SUCCEEDED, STOPPED, TIMEOUT, and FAILED.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("State")]
        public Union<string, IntrinsicFunction> State { get; set; }

        /// <summary>
        /// CrawlState
        /// The state of the crawler to which this condition applies.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CrawlState")]
        public Union<string, IntrinsicFunction> CrawlState { get; set; }

        /// <summary>
        /// LogicalOperator
        /// A logical operator.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogicalOperator")]
        public Union<string, IntrinsicFunction> LogicalOperator { get; set; }

        /// <summary>
        /// JobName
        /// The name of the job whose JobRuns this condition applies to, and on which this trigger waits.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JobName")]
        public Union<string, IntrinsicFunction> JobName { get; set; }

    }
}
