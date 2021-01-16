using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AudioNormalizationSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audionormalizationsettings.html
    /// </summary>
    public class AudioNormalizationSettings
    {

        /// <summary>
        /// TargetLkfs
        /// The Target LKFS(loudness) to adjust volume to. If no value is entered, a default value is used
        /// according to the chosen algorithm. The CALM Act (1770-1) recommends a target of -24 LKFS. The EBU
        /// R-128 specification (1770-2) recommends a target of -23 LKFS.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetLkfs")]
        public Union<double, IntrinsicFunction> TargetLkfs { get; set; }

        /// <summary>
        /// Algorithm
        /// The audio normalization algorithm to use. itu17701 conforms to the CALM Act specification. itu17702
        /// conforms to the EBU R-128 specification.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Algorithm")]
        public Union<string, IntrinsicFunction> Algorithm { get; set; }

        /// <summary>
        /// AlgorithmControl
        /// When set to correctAudio, the output audio is corrected using the chosen algorithm. If set to
        /// measureOnly, the audio is measured but not adjusted.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AlgorithmControl")]
        public Union<string, IntrinsicFunction> AlgorithmControl { get; set; }

    }
}
