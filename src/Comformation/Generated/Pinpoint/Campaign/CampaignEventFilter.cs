using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Campaign
{
    /// <summary>
    /// AWS::Pinpoint::Campaign CampaignEventFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaigneventfilter.html
    /// </summary>
    public class CampaignEventFilter
    {

        /// <summary>
        /// FilterType
        /// The type of event that causes the campaign to be sent. Valid values are: SYSTEM, sends the campaign
        /// when a system event occurs; and, ENDPOINT, sends the campaign when an endpoint event (Events
        /// resource) occurs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FilterType")]
        public Union<string, IntrinsicFunction> FilterType { get; set; }

        /// <summary>
        /// Dimensions
        /// The dimension settings of the event filter for the campaign.
        /// Required: No
        /// Type: EventDimensions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dimensions")]
        public EventDimensions Dimensions { get; set; }

    }
}
