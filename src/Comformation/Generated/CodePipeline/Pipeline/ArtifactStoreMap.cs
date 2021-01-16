using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline ArtifactStoreMap
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-artifactstoremap.html
    /// </summary>
    public class ArtifactStoreMap
    {

        /// <summary>
        /// ArtifactStore
        /// Represents information about the S3 bucket where artifacts are stored for the pipeline.
        /// Note You must include either artifactStore or artifactStores in your pipeline, but you cannot use
        /// both. If you create a cross-region action in your pipeline, you must use artifactStores.
        /// Required: Conditional
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
