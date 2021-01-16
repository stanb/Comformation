using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition RetryStrategy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-retrystrategy.html
    /// </summary>
    public class RetryStrategy
    {

        /// <summary>
        /// EvaluateOnExit
        /// Array of up to 5 objects that specify conditions under which the job should be retried or failed. If
        /// this parameter is specified, then the attempts parameter must also be specified.
        /// Required: No
        /// Type: List of EvaluateOnExit
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EvaluateOnExit")]
        public List<EvaluateOnExit> EvaluateOnExit { get; set; }

        /// <summary>
        /// Attempts
        /// The number of times to move a job to the RUNNABLE status. You can specify between 1 and 10 attempts.
        /// If the value of attempts is greater than one, the job is retried on failure the same number of
        /// attempts as the value.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attempts")]
        public Union<int, IntrinsicFunction> Attempts { get; set; }

    }
}
