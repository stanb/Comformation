using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// CodePipeline Pipeline Stages Actions OutputArtifacts
    /// OutputArtifacts is a property of the CodePipeline Pipeline Stages Actions property that specifies an artifact
    /// that is the result of an CodePipeline action, such as a test or build artifact.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages-actions-outputartifacts.html
    /// </summary>
    public class OutputArtifact
    {

        /// <summary>
        /// Name
        /// The name of the artifact that is the result of an CodePipeline action, such as My App. Output
        /// artifact names must be unique within a pipeline.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
