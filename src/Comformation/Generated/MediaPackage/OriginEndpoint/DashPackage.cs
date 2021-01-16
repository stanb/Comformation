using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.OriginEndpoint
{
    /// <summary>
    /// AWS::MediaPackage::OriginEndpoint DashPackage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-originendpoint-dashpackage.html
    /// </summary>
    public class DashPackage
    {

        /// <summary>
        /// SegmentDurationSeconds
        /// Duration (in seconds) of each fragment. Actual fragments are rounded to the nearest multiple of the
        /// source fragment duration.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentDurationSeconds")]
        public Union<int, IntrinsicFunction> SegmentDurationSeconds { get; set; }

        /// <summary>
        /// ManifestWindowSeconds
        /// Time window (in seconds) contained in each manifest.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ManifestWindowSeconds")]
        public Union<int, IntrinsicFunction> ManifestWindowSeconds { get; set; }

        /// <summary>
        /// Profile
        /// DASH profile for the output, such as HbbTV.
        /// Valid values:
        /// NONE - the output doesn&#39;t use a DASH profile. HBBTV_1_5 - the output is HbbTV-compliant.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Profile")]
        public Union<string, IntrinsicFunction> Profile { get; set; }

        /// <summary>
        /// MinUpdatePeriodSeconds
        /// Minimum amount of time (in seconds) that the player should wait before requesting updates to the
        /// manifest.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinUpdatePeriodSeconds")]
        public Union<int, IntrinsicFunction> MinUpdatePeriodSeconds { get; set; }

        /// <summary>
        /// MinBufferTimeSeconds
        /// Minimum amount of content (measured in seconds) that a player must keep available in the buffer.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinBufferTimeSeconds")]
        public Union<int, IntrinsicFunction> MinBufferTimeSeconds { get; set; }

        /// <summary>
        /// SuggestedPresentationDelaySeconds
        /// Amount of time (in seconds) that the player should be from the live point at the end of the
        /// manifest.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SuggestedPresentationDelaySeconds")]
        public Union<int, IntrinsicFunction> SuggestedPresentationDelaySeconds { get; set; }

        /// <summary>
        /// PeriodTriggers
        /// Controls whether MediaPackage produces single-period or multi-period DASH manifests. For more
        /// information about periods, see Multi-period DASH in AWS Elemental MediaPackage.
        /// Valid values:
        /// ADS - MediaPackage will produce multi-period DASH manifests. Periods are created based on the
        /// SCTE-35 ad markers present in the input manifest. No value - MediaPackage will produce single-period
        /// DASH manifests. This is the default setting.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PeriodTriggers")]
        public List<Union<string, IntrinsicFunction>> PeriodTriggers { get; set; }

        /// <summary>
        /// ManifestLayout
        /// Determines the position of some tags in the manifest.
        /// Options:
        /// FULL - elements like SegmentTemplate and ContentProtection are included in each Representation.
        /// COMPACT - duplicate elements are combined and presented at the AdaptationSet level.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ManifestLayout")]
        public Union<string, IntrinsicFunction> ManifestLayout { get; set; }

        /// <summary>
        /// SegmentTemplateFormat
        /// Determines the type of variable used in the media URL of the SegmentTemplate tag in the manifest.
        /// Also specifies if segment timeline information is included in SegmentTimeline or SegmentTemplate.
        /// NUMBER_WITH_TIMELINE - The $Number$ variable is used in the media URL. The value of this variable is
        /// the sequential number of the segment. A full SegmentTimeline object is presented in each
        /// SegmentTemplate. NUMBER_WITH_DURATION - The $Number$ variable is used in the media URL and a
        /// duration attribute is added to the segment template. The SegmentTimeline object is removed from the
        /// representation. TIME_WITH_TIMELINE - The $Time$ variable is used in the media URL. The value of this
        /// variable is the timestamp of when the segment starts. A full SegmentTimeline object is presented in
        /// each SegmentTemplate.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentTemplateFormat")]
        public Union<string, IntrinsicFunction> SegmentTemplateFormat { get; set; }

        /// <summary>
        /// AdTriggers
        /// Specifies the SCTE-35 message types that MediaPackage treats as ad markers in the output manifest.
        /// Valid values:
        /// BREAK DISTRIBUTOR_ADVERTISEMENT DISTRIBUTOR_OVERLAY_PLACEMENT_OPPORTUNITY.
        /// DISTRIBUTOR_PLACEMENT_OPPORTUNITY. PROVIDER_ADVERTISEMENT. PROVIDER_OVERLAY_PLACEMENT_OPPORTUNITY.
        /// PROVIDER_PLACEMENT_OPPORTUNITY. SPLICE_INSERT.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdTriggers")]
        public List<Union<string, IntrinsicFunction>> AdTriggers { get; set; }

        /// <summary>
        /// AdsOnDeliveryRestrictions
        /// The flags on SCTE-35 segmentation descriptors that have to be present for MediaPackage to insert ad
        /// markers in the output manifest. For information about SCTE-35 in MediaPackage, see SCTE-35 Message
        /// Options in AWS Elemental MediaPackage.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AdsOnDeliveryRestrictions")]
        public Union<string, IntrinsicFunction> AdsOnDeliveryRestrictions { get; set; }

        /// <summary>
        /// Encryption
        /// Parameters for encrypting content.
        /// Required: No
        /// Type: DashEncryption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encryption")]
        public DashEncryption Encryption { get; set; }

        /// <summary>
        /// StreamSelection
        /// Limitations for outputs from the endpoint, based on the video bitrate.
        /// Required: No
        /// Type: StreamSelection
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamSelection")]
        public StreamSelection StreamSelection { get; set; }

    }
}
