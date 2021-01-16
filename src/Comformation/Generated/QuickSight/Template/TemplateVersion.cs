using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Template
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-templateversion.html
    /// </summary>
    public class TemplateVersion
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
        public List<TemplateError> Errors { get; set; }

        /// <summary>
        /// CreatedTime
        /// </summary>
        [JsonProperty("CreatedTime")]
        public Union<string, IntrinsicFunction> CreatedTime { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// ThemeArn
        /// </summary>
        [JsonProperty("ThemeArn")]
        public Union<string, IntrinsicFunction> ThemeArn { get; set; }

        /// <summary>
        /// DataSetConfigurations
        /// </summary>
        [JsonProperty("DataSetConfigurations")]
        public List<DataSetConfiguration> DataSetConfigurations { get; set; }

        /// <summary>
        /// SourceEntityArn
        /// </summary>
        [JsonProperty("SourceEntityArn")]
        public Union<string, IntrinsicFunction> SourceEntityArn { get; set; }

        /// <summary>
        /// VersionNumber
        /// </summary>
        [JsonProperty("VersionNumber")]
        public Union<double, IntrinsicFunction> VersionNumber { get; set; }

        /// <summary>
        /// Sheets
        /// </summary>
        [JsonProperty("Sheets")]
        public List<Sheet> Sheets { get; set; }

    }
}
