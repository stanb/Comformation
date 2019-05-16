using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline ArtifactStoreMap
    /// A mapping of artifactStore objects and their corresponding regions. There must be an artifact store for the
    /// pipeline region and for each cross-region action within the pipeline. You can only use either artifactStore or
    /// artifactStores, not both.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-artifactstoremap.html
    /// </summary>
    public class ArtifactStoreMap
    {

        /// <summary>
        /// ArtifactStore
        /// Represents information about the Amazon S3 bucket where artifacts are stored for the pipeline.
        /// Required: Yes
        /// Type: ArtifactStore
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ArtifactStore")]
        public ArtifactStore ArtifactStore { get; set; }

        /// <summary>
        /// Region
        /// The action declaration&#39;s AWS Region, such as us-east-1.
        /// Required: Yes
        /// Type: String
        /// Minimum: 4
        /// Maximum: 30
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

    }
}
