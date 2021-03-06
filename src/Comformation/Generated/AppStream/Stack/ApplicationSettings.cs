using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.Stack
{
    /// <summary>
    /// AWS::AppStream::Stack ApplicationSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-applicationsettings.html
    /// </summary>
    public class ApplicationSettings
    {

        /// <summary>
        /// SettingsGroup
        /// The path prefix for the S3 bucket where users’ persistent application settings are stored. You can
        /// allow the same persistent application settings to be used across multiple stacks by specifying the
        /// same settings group for each stack.
        /// Required: No
        /// Type: String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SettingsGroup")]
        public Union<string, IntrinsicFunction> SettingsGroup { get; set; }

        /// <summary>
        /// Enabled
        /// Enables or disables persistent application settings for users during their streaming sessions.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
