using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Campaign
{
    /// <summary>
    /// AWS::Pinpoint::Campaign WriteTreatmentResource
    /// Specifies the settings for a campaign treatment. A treatment is a variation of a campaign that&#39;s used for A/B
    /// testing of a campaign.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-writetreatmentresource.html
    /// </summary>
    public class WriteTreatmentResource
    {

        /// <summary>
        /// TreatmentDescription
        /// The custom description of the treatment.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TreatmentDescription")]
        public Union<string, IntrinsicFunction> TreatmentDescription { get; set; }

        /// <summary>
        /// MessageConfiguration
        /// The message configuration settings for the treatment.
        /// Required: No
        /// Type: MessageConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MessageConfiguration")]
        public MessageConfiguration MessageConfiguration { get; set; }

        /// <summary>
        /// Schedule
        /// The schedule settings for the treatment.
        /// Required: No
        /// Type: Schedule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Schedule")]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// SizePercent
        /// The allocated percentage of users (segment members) to send the treatment to.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SizePercent")]
        public Union<int, IntrinsicFunction> SizePercent { get; set; }

        /// <summary>
        /// TreatmentName
        /// The custom name of the treatment. A treatment is a variation of a campaign that&#39;s used for A/B
        /// testing of a campaign.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TreatmentName")]
        public Union<string, IntrinsicFunction> TreatmentName { get; set; }

    }
}
