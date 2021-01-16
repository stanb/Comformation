using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule BatchRetryStrategy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchretrystrategy.html
    /// </summary>
    public class BatchRetryStrategy
    {

        /// <summary>
        /// Attempts
        /// The number of times to attempt to retry, if the job fails. Valid values are 1–10.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attempts")]
        public Union<int, IntrinsicFunction> Attempts { get; set; }

    }
}
