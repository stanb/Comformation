using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Campaign
{
    /// <summary>
    /// AWS::Pinpoint::Campaign EventDimensions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-eventdimensions.html
    /// </summary>
    public class EventDimensions
    {

        /// <summary>
        /// Metrics
        /// One or more custom metrics that your application reports to Amazon Pinpoint. You can use these
        /// metrics as selection criteria when you create an event filter.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Metrics")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Metrics { get; set; }

        /// <summary>
        /// EventType
        /// The name of the event that causes the campaign to be sent or the journey activity to be performed.
        /// This can be a standard event that Amazon Pinpoint generates, such as _email. delivered. For
        /// campaigns, this can also be a custom event that&#39;s specific to your application. For information
        /// about standard events, see Streaming Amazon Pinpoint Events in the Amazon Pinpoint Developer Guide.
        /// Required: No
        /// Type: SetDimension
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventType")]
        public SetDimension EventType { get; set; }

        /// <summary>
        /// Attributes
        /// One or more custom attributes that your application reports to Amazon Pinpoint. You can use these
        /// attributes as selection criteria when you create an event filter.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attributes")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Attributes { get; set; }

    }
}
