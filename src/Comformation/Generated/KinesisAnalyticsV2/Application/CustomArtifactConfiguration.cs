using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application CustomArtifactConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-customartifactconfiguration.html
    /// </summary>
    public class CustomArtifactConfiguration
    {

        /// <summary>
        /// MavenReference
        /// The parameters required to fully specify a Maven reference.
        /// Required: No
        /// Type: MavenReference
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MavenReference")]
        public MavenReference MavenReference { get; set; }

        /// <summary>
        /// S3ContentLocation
        /// The location of the custom artifacts.
        /// Required: No
        /// Type: S3ContentLocation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3ContentLocation")]
        public S3ContentLocation S3ContentLocation { get; set; }

        /// <summary>
        /// ArtifactType
        /// Set this to either UDF or DEPENDENCY_JAR. UDF stands for user-defined functions. This type of
        /// artifact must be in an S3 bucket. A DEPENDENCY_JAR can be in either Maven or an S3 bucket.
        /// Required: Yes
        /// Type: String
        /// Allowed values: DEPENDENCY_JAR | UDF
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ArtifactType")]
        public Union<string, IntrinsicFunction> ArtifactType { get; set; }

    }
}
