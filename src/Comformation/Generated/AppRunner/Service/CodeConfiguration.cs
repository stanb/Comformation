using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppRunner.Service
{
    /// <summary>
    /// AWS::AppRunner::Service CodeConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-service-codeconfiguration.html
    /// </summary>
    public class CodeConfiguration
    {

        /// <summary>
        /// ConfigurationSource
        /// The source of the App Runner configuration. Values are interpreted as follows:
        /// REPOSITORY – App Runner reads configuration values from the apprunner. yaml file in the source code
        /// repository and ignores CodeConfigurationValues. API – App Runner uses configuration values provided
        /// in CodeConfigurationValues and ignores the apprunner. yaml file in the source code repository.
        /// Required: Yes
        /// Type: String
        /// Allowed values: API | REPOSITORY
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConfigurationSource")]
        public Union<string, IntrinsicFunction> ConfigurationSource { get; set; }

        /// <summary>
        /// CodeConfigurationValues
        /// The basic configuration for building and running the App Runner service. Use it to quickly launch an
        /// App Runner service without providing a apprunner. yaml file in the source code repository (or
        /// ignoring the file if it exists).
        /// Required: No
        /// Type: CodeConfigurationValues
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodeConfigurationValues")]
        public CodeConfigurationValues CodeConfigurationValues { get; set; }

    }
}
