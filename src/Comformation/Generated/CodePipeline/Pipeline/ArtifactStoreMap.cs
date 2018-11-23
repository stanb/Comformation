using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS CodePipeline Pipeline ArtifactStoreMap
    /// The ArtifactStoreMap property type specifies a mapping of an ArtifactStore object and its corresponding
    /// region.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-artifactstoremap.html
    /// </summary>
    public class ArtifactStoreMap
    {

        /// <summary>
        /// ArtifactStore
        /// The Amazon S3 bucket where artifacts are stored for the pipeline.
        /// Required: Yes
        /// Type: ArtifactStore
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ArtifactStore")]
        public ArtifactStore ArtifactStore { get; set; }

        /// <summary>
        /// Region
        /// Specifies the action’s AWS Region, such as us-east-1.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

    }
}
