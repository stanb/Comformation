using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline BlockerDeclaration
    /// Reserved for future use.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages-blockers.html
    /// </summary>
    public class BlockerDeclaration
    {

        /// <summary>
        /// Name
        /// Reserved for future use.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Type
        /// Reserved for future use.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: Schedule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
