using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.CustomActionType
{
    /// <summary>
    /// AWS CodePipeline CustomActionType ArtifactDetails
    /// ArtifactDetails is a property of the AWS::CodePipeline::CustomActionType resource that specifies the details
    /// of an artifact for an AWS CodePipeline custom action. For valid values, see ArtifactDetails in the AWS
    /// CodePipeline API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype-artifactdetails.html
    /// </summary>
    public class ArtifactDetails
    {

        /// <summary>
        /// MaximumCount
        /// The maximum number of artifacts allowed for the action type.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("MaximumCount")]
        public Union<int, IntrinsicFunction> MaximumCount { get; set; }

        /// <summary>
        /// MinimumCount
        /// The minimum number of artifacts allowed for the action type.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("MinimumCount")]
        public Union<int, IntrinsicFunction> MinimumCount { get; set; }

    }
}
