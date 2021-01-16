using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Campaign
{
    /// <summary>
    /// AWS::Pinpoint::Campaign Schedule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html
    /// </summary>
    public class Schedule
    {

        /// <summary>
        /// TimeZone
        /// The starting UTC offset for the campaign schedule, if the value of the IsLocalTime property is true.
        /// Valid values are: UTC, UTC+01, UTC+02, UTC+03, UTC+03:30, UTC+04, UTC+04:30, UTC+05, UTC+05:30,
        /// UTC+05:45, UTC+06, UTC+06:30, UTC+07, UTC+08, UTC+09, UTC+09:30, UTC+10, UTC+10:30, UTC+11, UTC+12,
        /// UTC+13, UTC-02, UTC-03, UTC-04, UTC-05, UTC-06, UTC-07, UTC-08, UTC-09, UTC-10, and UTC-11.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeZone")]
        public Union<string, IntrinsicFunction> TimeZone { get; set; }

        /// <summary>
        /// QuietTime
        /// The default quiet time for the campaign. Quiet time is a specific time range when a campaign doesn&#39;t
        /// send messages to endpoints, if all the following conditions are met:
        /// The EndpointDemographic. Timezone property of the endpoint is set to a valid value. The current time
        /// in the endpoint&#39;s time zone is later than or equal to the time specified by the QuietTime. Start
        /// property for the campaign. The current time in the endpoint&#39;s time zone is earlier than or equal to
        /// the time specified by the QuietTime. End property for the campaign.
        /// If any of the preceding conditions isn&#39;t met, the endpoint will receive messages from the campaign,
        /// even if quiet time is enabled.
        /// Required: No
        /// Type: QuietTime
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QuietTime")]
        public QuietTime QuietTime { get; set; }

        /// <summary>
        /// EndTime
        /// The scheduled time, in ISO 8601 format, when the campaign ended or will end.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndTime")]
        public Union<string, IntrinsicFunction> EndTime { get; set; }

        /// <summary>
        /// StartTime
        /// The scheduled time when the campaign began or will begin. Valid values are: IMMEDIATE, to start the
        /// campaign immediately; or, a specific time in ISO 8601 format.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StartTime")]
        public Union<string, IntrinsicFunction> StartTime { get; set; }

        /// <summary>
        /// Frequency
        /// Specifies how often the campaign is sent or whether the campaign is sent in response to a specific
        /// event.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Frequency")]
        public Union<string, IntrinsicFunction> Frequency { get; set; }

        /// <summary>
        /// EventFilter
        /// The type of event that causes the campaign to be sent, if the value of the Frequency property is
        /// EVENT.
        /// Required: No
        /// Type: CampaignEventFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventFilter")]
        public CampaignEventFilter EventFilter { get; set; }

        /// <summary>
        /// IsLocalTime
        /// Specifies whether the start and end times for the campaign schedule use each recipient&#39;s local time.
        /// To base the schedule on each recipient&#39;s local time, set this value to true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IsLocalTime")]
        public Union<bool, IntrinsicFunction> IsLocalTime { get; set; }

    }
}
