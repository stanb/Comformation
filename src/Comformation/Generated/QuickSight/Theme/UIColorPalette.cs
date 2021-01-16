using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html
    /// </summary>
    public class UIColorPalette
    {

        /// <summary>
        /// Warning
        /// </summary>
        [JsonProperty("Warning")]
        public Union<string, IntrinsicFunction> Warning { get; set; }

        /// <summary>
        /// Accent
        /// </summary>
        [JsonProperty("Accent")]
        public Union<string, IntrinsicFunction> Accent { get; set; }

        /// <summary>
        /// AccentForeground
        /// </summary>
        [JsonProperty("AccentForeground")]
        public Union<string, IntrinsicFunction> AccentForeground { get; set; }

        /// <summary>
        /// SecondaryBackground
        /// </summary>
        [JsonProperty("SecondaryBackground")]
        public Union<string, IntrinsicFunction> SecondaryBackground { get; set; }

        /// <summary>
        /// DangerForeground
        /// </summary>
        [JsonProperty("DangerForeground")]
        public Union<string, IntrinsicFunction> DangerForeground { get; set; }

        /// <summary>
        /// PrimaryBackground
        /// </summary>
        [JsonProperty("PrimaryBackground")]
        public Union<string, IntrinsicFunction> PrimaryBackground { get; set; }

        /// <summary>
        /// Dimension
        /// </summary>
        [JsonProperty("Dimension")]
        public Union<string, IntrinsicFunction> Dimension { get; set; }

        /// <summary>
        /// SecondaryForeground
        /// </summary>
        [JsonProperty("SecondaryForeground")]
        public Union<string, IntrinsicFunction> SecondaryForeground { get; set; }

        /// <summary>
        /// WarningForeground
        /// </summary>
        [JsonProperty("WarningForeground")]
        public Union<string, IntrinsicFunction> WarningForeground { get; set; }

        /// <summary>
        /// DimensionForeground
        /// </summary>
        [JsonProperty("DimensionForeground")]
        public Union<string, IntrinsicFunction> DimensionForeground { get; set; }

        /// <summary>
        /// PrimaryForeground
        /// </summary>
        [JsonProperty("PrimaryForeground")]
        public Union<string, IntrinsicFunction> PrimaryForeground { get; set; }

        /// <summary>
        /// Success
        /// </summary>
        [JsonProperty("Success")]
        public Union<string, IntrinsicFunction> Success { get; set; }

        /// <summary>
        /// Danger
        /// </summary>
        [JsonProperty("Danger")]
        public Union<string, IntrinsicFunction> Danger { get; set; }

        /// <summary>
        /// SuccessForeground
        /// </summary>
        [JsonProperty("SuccessForeground")]
        public Union<string, IntrinsicFunction> SuccessForeground { get; set; }

        /// <summary>
        /// Measure
        /// </summary>
        [JsonProperty("Measure")]
        public Union<string, IntrinsicFunction> Measure { get; set; }

        /// <summary>
        /// MeasureForeground
        /// </summary>
        [JsonProperty("MeasureForeground")]
        public Union<string, IntrinsicFunction> MeasureForeground { get; set; }

    }
}
