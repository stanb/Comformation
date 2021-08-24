using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule DeadLetterConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-deadletterconfig.html
    /// </summary>
    public class DeadLetterConfig
    {

        /// <summary>
        /// Arn
        /// The ARN of the SQS queue specified as the target for the dead-letter queue.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1600
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

    }
}
