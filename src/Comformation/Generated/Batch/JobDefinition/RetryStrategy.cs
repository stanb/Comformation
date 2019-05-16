using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.JobDefinition
{
    /// <summary>
    /// AWS::Batch::JobDefinition RetryStrategy
    /// The retry strategy associated with a job.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-retrystrategy.html
    /// </summary>
    public class RetryStrategy
    {

        /// <summary>
        /// Attempts
        /// The number of times to move a job to the RUNNABLE status. You may specify between 1 and 10 attempts.
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
