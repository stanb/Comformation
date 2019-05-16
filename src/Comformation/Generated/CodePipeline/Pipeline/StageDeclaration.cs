using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline StageDeclaration
    /// Represents information about a stage and its definition.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages.html
    /// </summary>
    public class StageDeclaration
    {

        /// <summary>
        /// Actions
        /// The actions included in a stage.
        /// Required: Yes
        /// Type: List of ActionDeclaration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Actions")]
        public List<ActionDeclaration> Actions { get; set; }

        /// <summary>
        /// Blockers
        /// Reserved for future use.
        /// Required: No
        /// Type: List of BlockerDeclaration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Blockers")]
        public List<BlockerDeclaration> Blockers { get; set; }

        /// <summary>
        /// Name
        /// The name of the stage.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: [A-Za-z0-9. @\-_]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
