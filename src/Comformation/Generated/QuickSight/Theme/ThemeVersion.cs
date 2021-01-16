using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Theme
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-theme-themeversion.html
    /// </summary>
    public class ThemeVersion
    {

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

        /// <summary>
        /// Errors
        /// </summary>
        [JsonProperty("Errors")]
        public List<ThemeError> Errors { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// CreatedTime
        /// </summary>
        [JsonProperty("CreatedTime")]
        public Union<string, IntrinsicFunction> CreatedTime { get; set; }

        /// <summary>
        /// Configuration
        /// </summary>
        [JsonProperty("Configuration")]
        public ThemeConfiguration Configuration { get; set; }

        /// <summary>
        /// BaseThemeId
        /// </summary>
        [JsonProperty("BaseThemeId")]
        public Union<string, IntrinsicFunction> BaseThemeId { get; set; }

        /// <summary>
        /// Arn
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// VersionNumber
        /// </summary>
        [JsonProperty("VersionNumber")]
        public Union<double, IntrinsicFunction> VersionNumber { get; set; }

    }
}
