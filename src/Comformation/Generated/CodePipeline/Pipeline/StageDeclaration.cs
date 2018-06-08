using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS CodePipeline Pipeline Stages
    /// Stages is a property of the AWS::CodePipeline::Pipeline resource that specifies a sequence of tasks for AWS
    /// CodePipeline to complete on an artifact.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages.html
    /// </summary>
    public class StageDeclaration
    {

        /// <summary>
        /// Actions
        /// The actions to include in this stage.
        /// Required: Yes
        /// Type: List of AWS CodePipeline Pipeline Stages Actions
        /// </summary>
        [JsonProperty("Actions")]
        public Union<List<ActionDeclaration>, IntrinsicFunction> Actions { get; set; }

        /// <summary>
        /// Blockers
        /// The gates included in a stage.
        /// Required: No
        /// Type: List of AWS CodePipeline Pipeline Stages Blockers
        /// </summary>
        [JsonProperty("Blockers")]
        public Union<List<BlockerDeclaration>, IntrinsicFunction> Blockers { get; set; }

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
