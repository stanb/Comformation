using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// Amazon CloudWatch Events Rule SqsParameters
    /// The SqsParameters property type specify the custom parameter to be used when the target is an Amazon SQS FIFO
    /// queue.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-sqsparameters.html
    /// </summary>
    public class SqsParameters
    {

        /// <summary>
        /// MessageGroupId
        /// The FIFO message group ID to use as the target.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MessageGroupId")]
        public Union<string, IntrinsicFunction> MessageGroupId { get; set; }

    }
}
