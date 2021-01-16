using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AutomaticInputFailoverSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-automaticinputfailoversettings.html
    /// </summary>
    public class AutomaticInputFailoverSettings
    {

        /// <summary>
        /// FailoverConditions
        /// A list of failover conditions. If any of these conditions occur, MediaLive will perform a failover
        /// to the other input.
        /// Required: No
        /// Type: List of FailoverCondition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FailoverConditions")]
        public List<FailoverCondition> FailoverConditions { get; set; }

        /// <summary>
        /// InputPreference
        /// Input preference when deciding which input to make active when a previously failed input has
        /// recovered.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputPreference")]
        public Union<string, IntrinsicFunction> InputPreference { get; set; }

        /// <summary>
        /// SecondaryInputId
        /// The input ID of the secondary input in the automatic input failover pair.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecondaryInputId")]
        public Union<string, IntrinsicFunction> SecondaryInputId { get; set; }

        /// <summary>
        /// ErrorClearTimeMsec
        /// This clear time defines the requirement a recovered input must meet to be considered healthy. The
        /// input must have no failover conditions for this length of time. Enter a time in milliseconds. This
        /// value is particularly important if the input_preference for the failover pair is set to
        /// PRIMARY_INPUT_PREFERRED, because after this time, MediaLive will switch back to the primary input.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ErrorClearTimeMsec")]
        public Union<int, IntrinsicFunction> ErrorClearTimeMsec { get; set; }

    }
}
