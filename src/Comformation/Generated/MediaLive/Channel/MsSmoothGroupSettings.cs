using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel MsSmoothGroupSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mssmoothgroupsettings.html
    /// </summary>
    public class MsSmoothGroupSettings
    {

        /// <summary>
        /// SegmentationMode
        /// useInputSegmentation has been deprecated. The configured segment size is always used.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentationMode")]
        public Union<string, IntrinsicFunction> SegmentationMode { get; set; }

        /// <summary>
        /// Destination
        /// The Smooth Streaming publish point on an IIS server. MediaLive acts as a &quot;Push&quot; encoder to IIS.
        /// Required: No
        /// Type: OutputLocationRef
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public OutputLocationRef Destination { get; set; }

        /// <summary>
        /// EventStopBehavior
        /// When set to sendEos, sends an EOS signal to an IIS server when stopping the channel.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventStopBehavior")]
        public Union<string, IntrinsicFunction> EventStopBehavior { get; set; }

        /// <summary>
        /// FilecacheDuration
        /// The size, in seconds, of the file cache for streaming outputs.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FilecacheDuration")]
        public Union<int, IntrinsicFunction> FilecacheDuration { get; set; }

        /// <summary>
        /// CertificateMode
        /// If set to verifyAuthenticity, verifies the HTTPS certificate chain to a trusted certificate
        /// authority (CA). This causes HTTPS outputs to self-signed certificates to fail.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CertificateMode")]
        public Union<string, IntrinsicFunction> CertificateMode { get; set; }

        /// <summary>
        /// AcquisitionPointId
        /// The value of the Acquisition Point Identity element that is used in each message placed in the
        /// sparse track. Enabled only if sparseTrackType is not &quot;none. &quot;
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AcquisitionPointId")]
        public Union<string, IntrinsicFunction> AcquisitionPointId { get; set; }

        /// <summary>
        /// StreamManifestBehavior
        /// When set to send, sends a stream manifest so that the publishing point doesn&#39;t start until all
        /// streams start.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamManifestBehavior")]
        public Union<string, IntrinsicFunction> StreamManifestBehavior { get; set; }

        /// <summary>
        /// InputLossAction
        /// A parameter that controls output group behavior on an input loss.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputLossAction")]
        public Union<string, IntrinsicFunction> InputLossAction { get; set; }

        /// <summary>
        /// FragmentLength
        /// The length, in seconds, of mp4 fragments to generate. The fragment length must be compatible with
        /// GOP size and frame rate.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FragmentLength")]
        public Union<int, IntrinsicFunction> FragmentLength { get; set; }

        /// <summary>
        /// RestartDelay
        /// The number of seconds before initiating a restart due to output failure, due to exhausting the
        /// numRetries on one segment, or exceeding filecacheDuration.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RestartDelay")]
        public Union<int, IntrinsicFunction> RestartDelay { get; set; }

        /// <summary>
        /// SparseTrackType
        /// If set to scte35, uses incoming SCTE-35 messages to generate a sparse track in this group of
        /// Microsoft Smooth outputs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SparseTrackType")]
        public Union<string, IntrinsicFunction> SparseTrackType { get; set; }

        /// <summary>
        /// EventIdMode
        /// Specifies whether to send a channel ID to the IIS server. If no channel ID is sent and the same
        /// channel is used without changing the publishing point, clients might see cached video from the
        /// previous run. Options: - &quot;useConfigured&quot; - use the value provided in eventId - &quot;useTimestamp&quot; -
        /// generate and send a channel ID based on the current timestamp - &quot;noEventId&quot; - do not send a channel
        /// ID to the IIS server.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventIdMode")]
        public Union<string, IntrinsicFunction> EventIdMode { get; set; }

        /// <summary>
        /// TimestampOffsetMode
        /// The type of timestamp date offset to use. - useEventStartDate: Use the date the channel was started
        /// as the offset - useConfiguredOffset: Use an explicitly configured date as the offset.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimestampOffsetMode")]
        public Union<string, IntrinsicFunction> TimestampOffsetMode { get; set; }

        /// <summary>
        /// AudioOnlyTimecodeControl
        /// If set to passthrough for an audio-only Microsoft Smooth output, the fragment absolute time is set
        /// to the current timecode. This option does not write timecodes to the audio elementary stream.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AudioOnlyTimecodeControl")]
        public Union<string, IntrinsicFunction> AudioOnlyTimecodeControl { get; set; }

        /// <summary>
        /// NumRetries
        /// The number of retry attempts.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NumRetries")]
        public Union<int, IntrinsicFunction> NumRetries { get; set; }

        /// <summary>
        /// TimestampOffset
        /// The timestamp offset for the channel. Used only if timestampOffsetMode is set to
        /// useConfiguredOffset.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimestampOffset")]
        public Union<string, IntrinsicFunction> TimestampOffset { get; set; }

        /// <summary>
        /// EventId
        /// The Microsoft Smooth channel ID that is sent to the IIS server. Specify the ID only if eventIdMode
        /// is set to useConfigured.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventId")]
        public Union<string, IntrinsicFunction> EventId { get; set; }

        /// <summary>
        /// SendDelayMs
        /// The number of milliseconds to delay the output from the second pipeline.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SendDelayMs")]
        public Union<int, IntrinsicFunction> SendDelayMs { get; set; }

        /// <summary>
        /// ConnectionRetryInterval
        /// The number of seconds to wait before retrying the connection to the IIS server if the connection is
        /// lost. Content is cached during this time, and the cache is delivered to the IIS server after the
        /// connection is re-established.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionRetryInterval")]
        public Union<int, IntrinsicFunction> ConnectionRetryInterval { get; set; }

    }
}
