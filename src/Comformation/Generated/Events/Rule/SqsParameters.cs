using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-sqsparameters.html
    /// </summary>
    public class SqsParameters
    {

        /// <summary>
        /// MessageGroupId
        /// </summary>
        [JsonProperty("MessageGroupId")]
        public Union<string, IntrinsicFunction> MessageGroupId { get; set; }

    }
}
