using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS CodePipeline Pipeline DisableInboundStageTransitions
    /// DisableInboundStageTransitions is a property of the AWS::CodePipeline::Pipeline resource that specifies which
    /// AWS CodePipeline stage to disable transitions to.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-disableinboundstagetransitions.html
    /// </summary>
    public class StageTransition
    {

        /// <summary>
        /// Reason
        /// An explanation of why the transition between two stages of a pipeline was disabled.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Reason")]
        public Union<string, IntrinsicFunction> Reason { get; set; }

        /// <summary>
        /// StageName
        /// The name of the stage to which transitions are disabled.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("StageName")]
        public Union<string, IntrinsicFunction> StageName { get; set; }

    }
}
