using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS CodePipeline Pipeline Stages Actions InputArtifacts
    /// InputArtifacts is a property of the AWS CodePipeline Pipeline Stages Actions property that specifies an
    /// artifact that the AWS CodePipeline action works on, such as a test or build artifact.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages-actions-inputartifacts.html
    /// </summary>
    public class InputArtifact
    {

        /// <summary>
        /// Name
        /// The name of the artifact that the AWS CodePipeline action works on, such as My App. The input
        /// artifact of an action must match the output artifact from any preceding action.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
