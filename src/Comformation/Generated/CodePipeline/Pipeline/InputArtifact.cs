using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline InputArtifact
    /// Represents information about an artifact to be worked on, such as a test or build artifact.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages-actions-inputartifacts.html
    /// </summary>
    public class InputArtifact
    {

        /// <summary>
        /// Name
        /// The name of the artifact to be worked on (for example, &quot;My App&quot;).
        /// The input artifact of an action must exactly match the output artifact declared in a preceding
        /// action, but the input artifact does not have to be the next action in strict sequence from the
        /// action that provided the output artifact. Actions in parallel can declare different output
        /// artifacts, which are in turn consumed by different following actions.
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
