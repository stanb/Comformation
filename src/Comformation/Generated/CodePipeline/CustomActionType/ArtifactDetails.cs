using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.CustomActionType
{
    /// <summary>
    /// AWS::CodePipeline::CustomActionType ArtifactDetails
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-artifactdetails.html
    /// </summary>
    public class ArtifactDetails
    {

        /// <summary>
        /// MaximumCount
        /// The maximum number of artifacts allowed for the action type.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 5
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaximumCount")]
        public Union<int, IntrinsicFunction> MaximumCount { get; set; }

        /// <summary>
        /// MinimumCount
        /// The minimum number of artifacts allowed for the action type.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 5
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinimumCount")]
        public Union<int, IntrinsicFunction> MinimumCount { get; set; }

    }
}
