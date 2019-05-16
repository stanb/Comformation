using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.CustomActionType
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-artifactdetails.html
    /// </summary>
    public class ArtifactDetails
    {

        /// <summary>
        /// MaximumCount
        /// </summary>
        [JsonProperty("MaximumCount")]
        public Union<int, IntrinsicFunction> MaximumCount { get; set; }

        /// <summary>
        /// MinimumCount
        /// </summary>
        [JsonProperty("MinimumCount")]
        public Union<int, IntrinsicFunction> MinimumCount { get; set; }

    }
}
