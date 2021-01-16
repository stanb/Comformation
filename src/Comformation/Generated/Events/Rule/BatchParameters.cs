using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule BatchParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchparameters.html
    /// </summary>
    public class BatchParameters
    {

        /// <summary>
        /// ArrayProperties
        /// The array properties for the submitted job, such as the size of the array. The array size can be
        /// between 2 and 10,000. If you specify array properties for a job, it becomes an array job. This
        /// parameter is used only if the target is an AWS Batch job.
        /// Required: No
        /// Type: BatchArrayProperties
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ArrayProperties")]
        public BatchArrayProperties ArrayProperties { get; set; }

        /// <summary>
        /// JobDefinition
        /// The ARN or name of the job definition to use if the event target is an AWS Batch job. This job
        /// definition must already exist.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JobDefinition")]
        public Union<string, IntrinsicFunction> JobDefinition { get; set; }

        /// <summary>
        /// JobName
        /// The name to use for this execution of the job, if the target is an AWS Batch job.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JobName")]
        public Union<string, IntrinsicFunction> JobName { get; set; }

        /// <summary>
        /// RetryStrategy
        /// The retry strategy to use for failed jobs, if the target is an AWS Batch job. The retry strategy is
        /// the number of times to retry the failed job execution. Valid values are 1–10. When you specify a
        /// retry strategy here, it overrides the retry strategy defined in the job definition.
        /// Required: No
        /// Type: BatchRetryStrategy
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetryStrategy")]
        public BatchRetryStrategy RetryStrategy { get; set; }

    }
}
