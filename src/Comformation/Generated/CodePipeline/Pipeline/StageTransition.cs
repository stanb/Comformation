using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline StageTransition
    /// The name of the pipeline in which you want to disable the flow of artifacts from one stage to another.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-disableinboundstagetransitions.html
    /// </summary>
    public class StageTransition
    {

        /// <summary>
        /// Reason
        /// The reason given to the user that a stage is disabled, such as waiting for manual approval or manual
        /// tests. This message is displayed in the pipeline console UI.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 300
        /// Pattern: [a-zA-Z0-9!@ \(\)\. \*\?\-]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Reason")]
        public Union<string, IntrinsicFunction> Reason { get; set; }

        /// <summary>
        /// StageName
        /// The name of the stage where you want to disable the inbound or outbound transition of artifacts.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: [A-Za-z0-9. @\-_]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StageName")]
        public Union<string, IntrinsicFunction> StageName { get; set; }

    }
}
