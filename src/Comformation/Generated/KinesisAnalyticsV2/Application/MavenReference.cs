using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application MavenReference
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-mavenreference.html
    /// </summary>
    public class MavenReference
    {

        /// <summary>
        /// ArtifactId
        /// The artifact ID of the Maven reference.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: [a-zA-Z0-9_. -]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ArtifactId")]
        public Union<string, IntrinsicFunction> ArtifactId { get; set; }

        /// <summary>
        /// Version
        /// The version of the Maven reference.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: [a-zA-Z0-9_. -]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

        /// <summary>
        /// GroupId
        /// The group ID of the Maven reference.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: [a-zA-Z0-9_. -]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GroupId")]
        public Union<string, IntrinsicFunction> GroupId { get; set; }

    }
}
