using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.Stack
{
    /// <summary>
    /// Amazon AppStream 2. 0 Stack ApplicationSettings
    /// The ApplicationSettings property type specifies the persistent application settings for users of an Amazon
    /// AppStream 2. 0 stack.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-applicationsettings.html
    /// </summary>
    public class ApplicationSettings
    {

        /// <summary>
        /// SettingsGroup
        /// The path prefix for the Amazon S3 bucket where users’ persistent application settings are stored.
        /// You can allow the same persistent application settings to be used across multiple stacks by
        /// specifying the same settings group for each stack.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SettingsGroup")]
        public Union<string, IntrinsicFunction> SettingsGroup { get; set; }

        /// <summary>
        /// Enabled
        /// Specifies whether persistent application settings are enabled for users during their streaming
        /// sessions.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
