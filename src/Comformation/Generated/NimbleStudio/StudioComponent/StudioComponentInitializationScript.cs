using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NimbleStudio.StudioComponent
{
    /// <summary>
    /// AWS::NimbleStudio::StudioComponent StudioComponentInitializationScript
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-nimblestudio-studiocomponent-studiocomponentinitializationscript.html
    /// </summary>
    public class StudioComponentInitializationScript
    {

        /// <summary>
        /// LaunchProfileProtocolVersion
        /// The version number of the protocol that is used by the launch profile. The only valid version is
        /// &quot;2021-03-31&quot;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchProfileProtocolVersion")]
        public Union<string, IntrinsicFunction> LaunchProfileProtocolVersion { get; set; }

        /// <summary>
        /// Platform
        /// The platform of the initialization script, either WINDOWS or LINUX.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Platform")]
        public Union<string, IntrinsicFunction> Platform { get; set; }

        /// <summary>
        /// RunContext
        /// The method to use when running the initialization script.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RunContext")]
        public Union<string, IntrinsicFunction> RunContext { get; set; }

        /// <summary>
        /// Script
        /// The initialization script.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Script")]
        public Union<string, IntrinsicFunction> Script { get; set; }

    }
}
