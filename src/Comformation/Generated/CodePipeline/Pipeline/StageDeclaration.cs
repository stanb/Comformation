using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// CodePipeline Pipeline Stages
    /// Stages is a property of the AWS::CodePipeline::Pipeline resource that specifies a sequence of tasks for
    /// CodePipeline to complete on an artifact.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages.html
    /// </summary>
    public class StageDeclaration
    {

        /// <summary>
        /// Actions
        /// The actions to include in this stage.
        /// Required: Yes
        /// Type: List of CodePipeline Pipeline Stages Actions
        /// </summary>
        [JsonProperty("Actions")]
        public List<ActionDeclaration> Actions { get; set; }

        /// <summary>
        /// Blockers
        /// The gates included in a stage.
        /// Required: No
        /// Type: List of CodePipeline Pipeline Stages Blockers
        /// </summary>
        [JsonProperty("Blockers")]
        public List<BlockerDeclaration> Blockers { get; set; }

        /// <summary>
        /// Name
        /// A name for this stage.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
