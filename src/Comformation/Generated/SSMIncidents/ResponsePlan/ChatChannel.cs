using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMIncidents.ResponsePlan
{
    /// <summary>
    /// AWS::SSMIncidents::ResponsePlan ChatChannel
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-chatchannel.html
    /// </summary>
    public class ChatChannel
    {

        /// <summary>
        /// ChatbotSns
        /// The SNS targets that AWS Chatbot uses to notify the chat channel of updates to an incident. You can
        /// also make updates to the incident through the chat channel by using the SNS topics
        /// Required: No
        /// Type: List of String
        /// Maximum: 5
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChatbotSns")]
        public List<Union<string, IntrinsicFunction>> ChatbotSns { get; set; }

    }
}
