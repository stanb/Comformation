using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel Scte35SpliceInsert
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte35spliceinsert.html
    /// </summary>
    public class Scte35SpliceInsert
    {

        /// <summary>
        /// AdAvailOffset
        /// When specified, this offset (in milliseconds) is added to the input ad avail PTS time. This applies
        /// only to embedded SCTE 104/35 messages. It doesn&#39;t apply to OOB messages.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdAvailOffset")]
        public Union<int, IntrinsicFunction> AdAvailOffset { get; set; }

        /// <summary>
        /// WebDeliveryAllowedFlag
        /// When set to ignore, segment descriptors with webDeliveryAllowedFlag set to 0 no longer trigger
        /// blackouts or ad avail slates.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WebDeliveryAllowedFlag")]
        public Union<string, IntrinsicFunction> WebDeliveryAllowedFlag { get; set; }

        /// <summary>
        /// NoRegionalBlackoutFlag
        /// When set to ignore, segment descriptors with noRegionalBlackoutFlag set to 0 no longer trigger
        /// blackouts or ad avail slates.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NoRegionalBlackoutFlag")]
        public Union<string, IntrinsicFunction> NoRegionalBlackoutFlag { get; set; }

    }
}
