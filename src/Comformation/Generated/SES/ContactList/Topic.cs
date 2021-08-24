using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ContactList
{
    /// <summary>
    /// AWS::SES::ContactList Topic
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-contactlist-topic.html
    /// </summary>
    public class Topic
    {

        /// <summary>
        /// TopicName
        /// The name of the topic.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TopicName")]
        public Union<string, IntrinsicFunction> TopicName { get; set; }

        /// <summary>
        /// DisplayName
        /// The name of the topic the contact will see.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisplayName")]
        public Union<string, IntrinsicFunction> DisplayName { get; set; }

        /// <summary>
        /// Description
        /// A description of what the topic is about, which the contact will see.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// DefaultSubscriptionStatus
        /// The default subscription status to be applied to a contact if the contact has not noted their
        /// preference for subscribing to a topic.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultSubscriptionStatus")]
        public Union<string, IntrinsicFunction> DefaultSubscriptionStatus { get; set; }

    }
}
