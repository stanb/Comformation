using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS Batch JobDefinition RetryStrategy
    /// The RetryStrategy property type specifies the retry strategy to use for failed jobs that are submitted with
    /// this job definition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-retrystrategy.html
    /// </summary>
    public class RetryStrategy
    {

        /// <summary>
        /// Attempts
        /// The number of times to move a job to the RUNNABLE status. You may specify between 1 and 10 attempts.
        /// If attempts is greater than one, the job is retried if it fails until it has moved to RUNNABLE that
        /// many times.
        /// Required: no
        /// Type: Integer
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Attempts")]
        public Union<int, IntrinsicFunction> Attempts { get; set; }

    }
}
