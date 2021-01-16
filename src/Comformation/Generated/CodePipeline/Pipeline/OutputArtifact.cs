using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline OutputArtifact
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages-actions-outputartifacts.html
    /// </summary>
    public class OutputArtifact
    {

        /// <summary>
        /// Name
        /// The name of the output of an artifact, such as &quot;My App&quot;.
        /// The output artifact name must exactly match the input artifact declared for a downstream action.
        /// However, the downstream action&#39;s input artifact does not have to be the next action in strict
        /// sequence from the action that provided the output artifact. Actions in parallel can declare
        /// different output artifacts, which are in turn consumed by different following actions.
        /// Output artifact names must be unique within a pipeline.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: [a-zA-Z0-9_\-]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
