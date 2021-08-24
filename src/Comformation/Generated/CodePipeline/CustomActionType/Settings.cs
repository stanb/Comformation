using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.CustomActionType
{
    /// <summary>
    /// AWS::CodePipeline::CustomActionType Settings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-settings.html
    /// </summary>
    public class Settings
    {

        /// <summary>
        /// EntityUrlTemplate
        /// The URL returned to the CodePipeline console that provides a deep link to the resources of the
        /// external system, such as the configuration page for a CodeDeploy deployment group. This link is
        /// provided as part of the action display in the pipeline.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EntityUrlTemplate")]
        public Union<string, IntrinsicFunction> EntityUrlTemplate { get; set; }

        /// <summary>
        /// ExecutionUrlTemplate
        /// The URL returned to the CodePipeline console that contains a link to the top-level landing page for
        /// the external system, such as the console page for CodeDeploy. This link is shown on the pipeline
        /// view page in the CodePipeline console and provides a link to the execution entity of the external
        /// action.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExecutionUrlTemplate")]
        public Union<string, IntrinsicFunction> ExecutionUrlTemplate { get; set; }

        /// <summary>
        /// RevisionUrlTemplate
        /// The URL returned to the CodePipeline console that contains a link to the page where customers can
        /// update or change the configuration of the external action.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RevisionUrlTemplate")]
        public Union<string, IntrinsicFunction> RevisionUrlTemplate { get; set; }

        /// <summary>
        /// ThirdPartyConfigurationUrl
        /// The URL of a sign-up page where users can sign up for an external service and perform initial
        /// configuration of the action provided by that service.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ThirdPartyConfigurationUrl")]
        public Union<string, IntrinsicFunction> ThirdPartyConfigurationUrl { get; set; }

    }
}
