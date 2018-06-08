using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS CodePipeline Pipeline Stages Blockers
    /// Blockers is a property of the AWS CodePipeline Pipeline Stages property that specifies an AWS CodePipeline
    /// gate declaration.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages-blockers.html
    /// </summary>
    public class BlockerDeclaration
    {

        /// <summary>
        /// Name
        /// The name of the gate declaration.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Type
        /// The type of gate declaration. For valid values, see BlockerDeclaration in the AWS CodePipeline API
        /// Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
