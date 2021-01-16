using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRuleDestination
{
    /// <summary>
    /// AWS::IoT::TopicRuleDestination HttpUrlDestinationSummary
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-httpurldestinationsummary.html
    /// </summary>
    public class HttpUrlDestinationSummary
    {

        /// <summary>
        /// ConfirmationUrl
        /// The URL used to confirm the HTTP topic rule destination URL.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ConfirmationUrl")]
        public Union<string, IntrinsicFunction> ConfirmationUrl { get; set; }

    }
}
