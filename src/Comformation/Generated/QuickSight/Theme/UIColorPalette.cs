using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// AWS::QuickSight::Theme UIColorPalette
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-uicolorpalette.html
    /// </summary>
    public class UIColorPalette
    {

        /// <summary>
        /// Warning
        /// This color that applies to warning and informational messages.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Warning")]
        public Union<string, IntrinsicFunction> Warning { get; set; }

        /// <summary>
        /// Accent
        /// This color is that applies to selected states and buttons.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Accent")]
        public Union<string, IntrinsicFunction> Accent { get; set; }

        /// <summary>
        /// AccentForeground
        /// The foreground color that applies to any text or other elements that appear over the accent color.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccentForeground")]
        public Union<string, IntrinsicFunction> AccentForeground { get; set; }

        /// <summary>
        /// SecondaryBackground
        /// The background color that applies to the sheet background and sheet controls.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecondaryBackground")]
        public Union<string, IntrinsicFunction> SecondaryBackground { get; set; }

        /// <summary>
        /// DangerForeground
        /// The foreground color that applies to any text or other elements that appear over the error color.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DangerForeground")]
        public Union<string, IntrinsicFunction> DangerForeground { get; set; }

        /// <summary>
        /// PrimaryBackground
        /// The background color that applies to visuals and other high emphasis UI.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrimaryBackground")]
        public Union<string, IntrinsicFunction> PrimaryBackground { get; set; }

        /// <summary>
        /// Dimension
        /// The color that applies to the names of fields that are identified as dimensions.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dimension")]
        public Union<string, IntrinsicFunction> Dimension { get; set; }

        /// <summary>
        /// SecondaryForeground
        /// The foreground color that applies to any sheet title, sheet control text, or UI that appears over
        /// the secondary background.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecondaryForeground")]
        public Union<string, IntrinsicFunction> SecondaryForeground { get; set; }

        /// <summary>
        /// WarningForeground
        /// The foreground color that applies to any text or other elements that appear over the warning color.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WarningForeground")]
        public Union<string, IntrinsicFunction> WarningForeground { get; set; }

        /// <summary>
        /// DimensionForeground
        /// The foreground color that applies to any text or other elements that appear over the dimension
        /// color.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DimensionForeground")]
        public Union<string, IntrinsicFunction> DimensionForeground { get; set; }

        /// <summary>
        /// PrimaryForeground
        /// The color of text and other foreground elements that appear over the primary background regions,
        /// such as grid lines, borders, table banding, icons, and so on.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PrimaryForeground")]
        public Union<string, IntrinsicFunction> PrimaryForeground { get; set; }

        /// <summary>
        /// Success
        /// The color that applies to success messages, for example the check mark for a successful download.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Success")]
        public Union<string, IntrinsicFunction> Success { get; set; }

        /// <summary>
        /// Danger
        /// The color that applies to error messages.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Danger")]
        public Union<string, IntrinsicFunction> Danger { get; set; }

        /// <summary>
        /// SuccessForeground
        /// The foreground color that applies to any text or other elements that appear over the success color.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SuccessForeground")]
        public Union<string, IntrinsicFunction> SuccessForeground { get; set; }

        /// <summary>
        /// Measure
        /// The color that applies to the names of fields that are identified as measures.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Measure")]
        public Union<string, IntrinsicFunction> Measure { get; set; }

        /// <summary>
        /// MeasureForeground
        /// The foreground color that applies to any text or other elements that appear over the measure color.
        /// Required: No
        /// Type: String
        /// Pattern: ^#[A-F0-9]{6}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MeasureForeground")]
        public Union<string, IntrinsicFunction> MeasureForeground { get; set; }

    }
}
