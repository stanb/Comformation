using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingConfiguration
{
    /// <summary>
    /// AWS::MediaPackage::PackagingConfiguration DashPackage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packagingconfiguration-dashpackage.html
    /// </summary>
    public class DashPackage
    {

        /// <summary>
        /// DashManifests
        /// A list of DASH manifest configurations that are available from this endpoint.
        /// Required: Yes
        /// Type: List of DashManifest
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DashManifests")]
        public List<DashManifest> DashManifests { get; set; }

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
        /// SegmentDurationSeconds
        /// Duration (in seconds) of each fragment. Actual fragments are rounded to the nearest multiple of the
        /// source segment duration.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentDurationSeconds")]
        public Union<int, IntrinsicFunction> SegmentDurationSeconds { get; set; }

        /// <summary>
        /// SegmentTemplateFormat
        /// Determines the type of SegmentTemplate included in the Media Presentation Description (MPD). When
        /// set to NUMBER_WITH_TIMELINE, a full timeline is presented in each SegmentTemplate, with $Number$
        /// media URLs. When set to TIME_WITH_TIMELINE, a full timeline is presented in each SegmentTemplate,
        /// with $Time$ media URLs. When set to NUMBER_WITH_DURATION, only a duration is included in each
        /// SegmentTemplate, with $Number$ media URLs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SegmentTemplateFormat")]
        public Union<string, IntrinsicFunction> SegmentTemplateFormat { get; set; }

    }
}
