using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CE.AnomalySubscription
{
    /// <summary>
    /// AWS::CE::AnomalySubscription Subscriber
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ce-anomalysubscription-subscriber.html
    /// </summary>
    public class Subscriber
    {

        /// <summary>
        /// Address
        /// The email address or SNS Topic Amazon Resource Name (ARN), depending on the Type.
        /// Required: Yes
        /// Type: String
        /// Minimum: 6
        /// Maximum: 302
        /// Pattern: (^[a-zA-Z0-9. !#$%&amp;amp;&#39;*+=?^_‘{|}~-]+@[a-zA-Z0-9_-]+(\.
        /// [a-zA-Z0-9_-]+)+$)|(^arn:(aws[a-zA-Z-]*):sns:[a-zA-Z0-9-]+:[0-9]{12}:[a-zA-Z0-9_-]+$)
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Address")]
        public Union<string, IntrinsicFunction> Address { get; set; }

        /// <summary>
        /// Status
        /// Indicates if the subscriber accepts the notifications.
        /// Required: No
        /// Type: String
        /// Allowed values: CONFIRMED | DECLINED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

        /// <summary>
        /// Type
        /// The notification delivery channel.
        /// Required: Yes
        /// Type: String
        /// Allowed values: EMAIL | SNS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
