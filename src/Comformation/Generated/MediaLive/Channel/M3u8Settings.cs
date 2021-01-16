using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel M3u8Settings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html
    /// </summary>
    public class M3u8Settings
    {

        /// <summary>
        /// PatInterval
        /// The number of milliseconds between instances of this table in the output transport stream. A value
        /// of \&quot;0\&quot; writes out the PMT once per segment file.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PatInterval")]
        public Union<int, IntrinsicFunction> PatInterval { get; set; }

        /// <summary>
        /// ProgramNum
        /// The value of the program number field in the Program Map Table (PMT).
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProgramNum")]
        public Union<int, IntrinsicFunction> ProgramNum { get; set; }

        /// <summary>
        /// PcrPeriod
        /// The maximum time, in milliseconds, between Program Clock References (PCRs) inserted into the
        /// transport stream.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PcrPeriod")]
        public Union<int, IntrinsicFunction> PcrPeriod { get; set; }

        /// <summary>
        /// PmtInterval
        /// The number of milliseconds between instances of this table in the output transport stream. A value
        /// of \&quot;0\&quot; writes out the PMT once per segment file.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PmtInterval")]
        public Union<int, IntrinsicFunction> PmtInterval { get; set; }

        /// <summary>
        /// NielsenId3Behavior
        /// If set to passthrough, Nielsen inaudible tones for media tracking will be detected in the input
        /// audio and an equivalent ID3 tag will be inserted in the output.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NielsenId3Behavior")]
        public Union<string, IntrinsicFunction> NielsenId3Behavior { get; set; }

        /// <summary>
        /// PcrPid
        /// The PID of the Program Clock Reference (PCR) in the transport stream. When no value is given,
        /// MediaLive assigns the same value as the video PID. You can enter the value as a decimal or
        /// hexadecimal value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PcrPid")]
        public Union<string, IntrinsicFunction> PcrPid { get; set; }

        /// <summary>
        /// VideoPid
        /// The PID of the elementary video stream in the transport stream. You can enter the value as a decimal
        /// or hexadecimal value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VideoPid")]
        public Union<string, IntrinsicFunction> VideoPid { get; set; }

        /// <summary>
        /// AudioFramesPerPes
        /// The number of audio frames to insert for each PES packet.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioFramesPerPes")]
        public Union<int, IntrinsicFunction> AudioFramesPerPes { get; set; }

        /// <summary>
        /// TransportStreamId
        /// The value of the transport stream ID field in the Program Map Table (PMT).
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TransportStreamId")]
        public Union<int, IntrinsicFunction> TransportStreamId { get; set; }

        /// <summary>
        /// PmtPid
        /// The PID for the Program Map Table (PMT) in the transport stream. You can enter the value as a
        /// decimal or hexadecimal value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PmtPid")]
        public Union<string, IntrinsicFunction> PmtPid { get; set; }

        /// <summary>
        /// Scte35Pid
        /// The PID of the SCTE-35 stream in the transport stream. You can enter the value as a decimal or
        /// hexadecimal value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scte35Pid")]
        public Union<string, IntrinsicFunction> Scte35Pid { get; set; }

        /// <summary>
        /// Scte35Behavior
        /// If set to passthrough, passes any SCTE-35 signals from the input source to this output.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scte35Behavior")]
        public Union<string, IntrinsicFunction> Scte35Behavior { get; set; }

        /// <summary>
        /// EcmPid
        /// This parameter is unused and deprecated.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EcmPid")]
        public Union<string, IntrinsicFunction> EcmPid { get; set; }

        /// <summary>
        /// TimedMetadataPid
        /// The PID of the timed metadata stream in the transport stream. You can enter the value as a decimal
        /// or hexadecimal value. Valid values are 32 (or 0x20). . 8182 (or 0x1ff6).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimedMetadataPid")]
        public Union<string, IntrinsicFunction> TimedMetadataPid { get; set; }

        /// <summary>
        /// AudioPids
        /// The PID of the elementary audio streams in the transport stream. Multiple values are accepted, and
        /// can be entered in ranges or by comma separation. You can enter the value as a decimal or hexadecimal
        /// value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioPids")]
        public Union<string, IntrinsicFunction> AudioPids { get; set; }

        /// <summary>
        /// PcrControl
        /// When set to pcrEveryPesPacket, a Program Clock Reference value is inserted for every Packetized
        /// Elementary Stream (PES) header. This parameter is effective only when the PCR PID is the same as the
        /// video or audio elementary stream.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PcrControl")]
        public Union<string, IntrinsicFunction> PcrControl { get; set; }

        /// <summary>
        /// TimedMetadataBehavior
        /// When set to passthrough, timed metadata is passed through from input to output.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimedMetadataBehavior")]
        public Union<string, IntrinsicFunction> TimedMetadataBehavior { get; set; }

    }
}
