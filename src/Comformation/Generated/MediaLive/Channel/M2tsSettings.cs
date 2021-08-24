using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel M2tsSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m2tssettings.html
    /// </summary>
    public class M2tsSettings
    {

        /// <summary>
        /// EtvPlatformPid
        /// The PID for the input source ETV Platform data to this output. You can enter it as a decimal or
        /// hexadecimal value. Valid values are 32 (or 0x20) to 8182 (or 0x1ff6).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EtvPlatformPid")]
        public Union<string, IntrinsicFunction> EtvPlatformPid { get; set; }

        /// <summary>
        /// PatInterval
        /// The number of milliseconds between instances of this table in the output transport stream. Valid
        /// values are 0, 10. . 1000.
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
        /// RateMode
        /// When VBR, does not insert null packets into the transport stream to fill the specified bitrate. The
        /// bitrate setting acts as the maximum bitrate when VBR is set.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RateMode")]
        public Union<string, IntrinsicFunction> RateMode { get; set; }

        /// <summary>
        /// KlvDataPids
        /// The PID for the input source KLV data to this output. Multiple values are accepted, and can be
        /// entered in ranges or by comma separation. You can enter the value as a decimal or hexadecimal value.
        /// Each PID specified must be in the range of 32 (or 0x20). . 8182 (or 0x1ff6).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KlvDataPids")]
        public Union<string, IntrinsicFunction> KlvDataPids { get; set; }

        /// <summary>
        /// NullPacketBitrate
        /// The value, in bits per second, of extra null packets to insert into the transport stream. This can
        /// be used if a downstream encryption system requires periodic null packets.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NullPacketBitrate")]
        public Union<double, IntrinsicFunction> NullPacketBitrate { get; set; }

        /// <summary>
        /// PmtInterval
        /// The number of milliseconds between instances of this table in the output transport stream. Valid
        /// values are 0, 10. . 1000.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PmtInterval")]
        public Union<int, IntrinsicFunction> PmtInterval { get; set; }

        /// <summary>
        /// AribCaptionsPid
        /// The PID for ARIB Captions in the transport stream. You can enter the value as a decimal or
        /// hexadecimal value. Valid values are 32 (or 0x20). . 8182 (or 0x1ff6).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AribCaptionsPid")]
        public Union<string, IntrinsicFunction> AribCaptionsPid { get; set; }

        /// <summary>
        /// EsRateInPes
        /// Includes or excludes the ES Rate field in the PES header.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EsRateInPes")]
        public Union<string, IntrinsicFunction> EsRateInPes { get; set; }

        /// <summary>
        /// VideoPid
        /// The PID of the elementary video stream in the transport stream. You can enter the value as a decimal
        /// or hexadecimal value. Valid values are 32 (or 0x20). . 8182 (or 0x1ff6).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VideoPid")]
        public Union<string, IntrinsicFunction> VideoPid { get; set; }

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
        /// EbpPlacement
        /// Controls placement of EBP on audio PIDs. If set to videoAndAudioPids, EBP markers are placed on the
        /// video PID and all audio PIDs. If set to videoPid, EBP markers are placed on only the video PID.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EbpPlacement")]
        public Union<string, IntrinsicFunction> EbpPlacement { get; set; }

        /// <summary>
        /// DvbSubPids
        /// The PID for the input source DVB Subtitle data to this output. Multiple values are accepted, and can
        /// be entered in ranges and/or by comma separation. You can enter the value as a decimal or hexadecimal
        /// value. Each PID specified must be in the range of 32 (or 0x20). . 8182 (or 0x1ff6).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DvbSubPids")]
        public Union<string, IntrinsicFunction> DvbSubPids { get; set; }

        /// <summary>
        /// SegmentationStyle
        /// The segmentation style parameter controls how segmentation markers are inserted into the transport
        /// stream. With avails, it is possible that segments might be truncated, which can influence where
        /// future segmentation markers are inserted. When a segmentation style of resetCadence is selected and
        /// a segment is truncated due to an avail, we will reset the segmentation cadence. This means the
        /// subsequent segment will have a duration of $segmentationTime seconds. When a segmentation style of
        /// maintainCadence is selected and a segment is truncated due to an avail, we will not reset the
        /// segmentation cadence. This means the subsequent segment will likely be truncated as well. However,
        /// all segments after that will have a duration of $segmentationTime seconds. Note that EBP lookahead
        /// is a slight exception to this rule.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentationStyle")]
        public Union<string, IntrinsicFunction> SegmentationStyle { get; set; }

        /// <summary>
        /// Scte35Pid
        /// The PID of the SCTE-35 stream in the transport stream. You can enter the value as a decimal or
        /// hexadecimal value. Valid values are 32 (or 0x20). . 8182 (or 0x1ff6).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scte35Pid")]
        public Union<string, IntrinsicFunction> Scte35Pid { get; set; }

        /// <summary>
        /// AudioStreamType
        /// When set to atsc, uses stream type = 0x81 for AC3 and stream type = 0x87 for EAC3. When set to dvb,
        /// uses stream type = 0x06.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioStreamType")]
        public Union<string, IntrinsicFunction> AudioStreamType { get; set; }

        /// <summary>
        /// Klv
        /// If set to passthrough, passes any KLV data from the input source to this output.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Klv")]
        public Union<string, IntrinsicFunction> Klv { get; set; }

        /// <summary>
        /// EbpLookaheadMs
        /// When set, enforces that Encoder Boundary Points do not come within the specified time interval of
        /// each other by looking ahead at input video. If another EBP is going to come in within the specified
        /// time interval, the current EBP is not emitted, and the segment is &quot;stretched&quot; to the next marker.
        /// The lookahead value does not add latency to the system. The channel must be configured elsewhere to
        /// create sufficient latency to make the lookahead accurate.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EbpLookaheadMs")]
        public Union<int, IntrinsicFunction> EbpLookaheadMs { get; set; }

        /// <summary>
        /// DvbTdtSettings
        /// Inserts DVB Time and Date Table (TDT) at the specified table repetition interval.
        /// Required: No
        /// Type: DvbTdtSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DvbTdtSettings")]
        public DvbTdtSettings DvbTdtSettings { get; set; }

        /// <summary>
        /// TimedMetadataBehavior
        /// When set to passthrough, timed metadata is passed through from input to output.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimedMetadataBehavior")]
        public Union<string, IntrinsicFunction> TimedMetadataBehavior { get; set; }

        /// <summary>
        /// EbpAudioInterval
        /// When videoAndFixedIntervals is selected, audio EBP markers are added to partitions 3 and 4. The
        /// interval between these additional markers is fixed, and is slightly shorter than the video EBP
        /// marker interval. This is only available when EBP Cablelabs segmentation markers are selected.
        /// Partitions 1 and 2 always follow the video interval.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EbpAudioInterval")]
        public Union<string, IntrinsicFunction> EbpAudioInterval { get; set; }

        /// <summary>
        /// FragmentTime
        /// The length in seconds of each fragment. This is used only with EBP markers.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FragmentTime")]
        public Union<double, IntrinsicFunction> FragmentTime { get; set; }

        /// <summary>
        /// DvbTeletextPid
        /// The PID for the input source DVB Teletext data to this output. You can enter the value as a decimal
        /// or hexadecimal value. Valid values are 32 (or 0x20). . 8182 (or 0x1ff6).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DvbTeletextPid")]
        public Union<string, IntrinsicFunction> DvbTeletextPid { get; set; }

        /// <summary>
        /// Scte35Control
        /// Optionally passes SCTE-35 signals from the input source to this output.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scte35Control")]
        public Union<string, IntrinsicFunction> Scte35Control { get; set; }

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
        /// hexadecimal value. Valid values are 32 (or 0x20). . 8182 (or 0x1ff6).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PcrPid")]
        public Union<string, IntrinsicFunction> PcrPid { get; set; }

        /// <summary>
        /// SegmentationTime
        /// The length, in seconds, of each segment. This is required unless markers is set to None_.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentationTime")]
        public Union<double, IntrinsicFunction> SegmentationTime { get; set; }

        /// <summary>
        /// CcDescriptor
        /// When set to enabled, generates captionServiceDescriptor in PMT.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CcDescriptor")]
        public Union<string, IntrinsicFunction> CcDescriptor { get; set; }

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
        /// AbsentInputAudioBehavior
        /// When set to drop, the output audio streams are removed from the program if the selected input audio
        /// stream is removed from the input. This allows the output audio configuration to dynamically change
        /// based on the input configuration. If this is set to encodeSilence, all output audio streams will
        /// output encoded silence when not connected to an active input stream.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AbsentInputAudioBehavior")]
        public Union<string, IntrinsicFunction> AbsentInputAudioBehavior { get; set; }

        /// <summary>
        /// Bitrate
        /// The output bitrate of the transport stream in bits per second. Setting to 0 lets the muxer
        /// automatically determine the appropriate bitrate.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bitrate")]
        public Union<int, IntrinsicFunction> Bitrate { get; set; }

        /// <summary>
        /// PmtPid
        /// The PID for the Program Map Table (PMT) in the transport stream. You can enter the value as a
        /// decimal or hexadecimal value. Valid values are 32 (or 0x20). . 8182 (or 0x1ff6).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PmtPid")]
        public Union<string, IntrinsicFunction> PmtPid { get; set; }

        /// <summary>
        /// Scte27Pids
        /// The PID for the input source SCTE-27 data to this output. Multiple values are accepted, and can be
        /// entered in ranges or by comma separation. You can enter the value as a decimal or hexadecimal value.
        /// Each PID specified must be in the range of 32 (or 0x20). . 8182 (or 0x1ff6).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Scte27Pids")]
        public Union<string, IntrinsicFunction> Scte27Pids { get; set; }

        /// <summary>
        /// SegmentationMarkers
        /// Inserts segmentation markers at each segmentationTime period. raiSegstart sets the Random Access
        /// Indicator bit in the adaptation field. raiAdapt sets the RAI bit and adds the current timecode in
        /// the private data bytes. psiSegstart inserts PAT and PMT tables at the start of segments. ebp adds
        /// Encoder Boundary Point information to the adaptation field as per OpenCable specification
        /// OC-SP-EBP-I01-130118. ebpLegacy adds Encoder Boundary Point information to the adaptation field
        /// using a legacy proprietary format.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentationMarkers")]
        public Union<string, IntrinsicFunction> SegmentationMarkers { get; set; }

        /// <summary>
        /// DvbNitSettings
        /// Inserts a DVB Network Information Table (NIT) at the specified table repetition interval.
        /// Required: No
        /// Type: DvbNitSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DvbNitSettings")]
        public DvbNitSettings DvbNitSettings { get; set; }

        /// <summary>
        /// DvbSdtSettings
        /// Inserts a DVB Service Description Table (SDT) at the specified table repetition interval.
        /// Required: No
        /// Type: DvbSdtSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DvbSdtSettings")]
        public DvbSdtSettings DvbSdtSettings { get; set; }

        /// <summary>
        /// EtvSignalPid
        /// The PID for input source ETV Signal data to this output. You can enter the value as a decimal or
        /// hexadecimal value. Valid values are 32 (or 0x20). . 8182 (or 0x1ff6).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EtvSignalPid")]
        public Union<string, IntrinsicFunction> EtvSignalPid { get; set; }

        /// <summary>
        /// Arib
        /// When set to enabled, uses ARIB-compliant field muxing and removes video descriptor.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arib")]
        public Union<string, IntrinsicFunction> Arib { get; set; }

        /// <summary>
        /// BufferModel
        /// If set to multiplex, uses the multiplex buffer model for accurate interleaving. Setting to
        /// bufferModel to none can lead to lower latency, but low-memory devices might not be able to play back
        /// the stream without interruptions.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BufferModel")]
        public Union<string, IntrinsicFunction> BufferModel { get; set; }

        /// <summary>
        /// EcmPid
        /// This field is unused and deprecated.
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
        /// value. Each PID specified must be in the range of 32 (or 0x20). . 8182 (or 0x1ff6).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioPids")]
        public Union<string, IntrinsicFunction> AudioPids { get; set; }

        /// <summary>
        /// AudioBufferModel
        /// When set to dvb, uses the DVB buffer model for Dolby Digital audio. When set to atsc, the ATSC model
        /// is used.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioBufferModel")]
        public Union<string, IntrinsicFunction> AudioBufferModel { get; set; }

        /// <summary>
        /// Ebif
        /// If set to passthrough, passes any EBIF data from the input source to this output.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Ebif")]
        public Union<string, IntrinsicFunction> Ebif { get; set; }

        /// <summary>
        /// AribCaptionsPidControl
        /// If set to auto, The PID number used for ARIB Captions will be auto-selected from unused PIDs. If set
        /// to useConfigured, ARIB captions will be on the configured PID number.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AribCaptionsPidControl")]
        public Union<string, IntrinsicFunction> AribCaptionsPidControl { get; set; }

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

    }
}
