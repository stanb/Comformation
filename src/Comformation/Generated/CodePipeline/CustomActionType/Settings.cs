using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.CustomActionType
{
    /// <summary>
    /// CodePipeline CustomActionType Settings
    /// Settings is a property of the AWS::CodePipeline::CustomActionType resource that provides URLs that users can
    /// access to view information about the CodePipeline custom action.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype-settings.html
    /// </summary>
    public class Settings
    {

        /// <summary>
        /// EntityUrlTemplate
        /// The URL that is returned to the CodePipeline console that links to the resources of the external
        /// system, such as the configuration page for an CodeDeploy deployment group.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("EntityUrlTemplate")]
        public Union<string, IntrinsicFunction> EntityUrlTemplate { get; set; }

        /// <summary>
        /// ExecutionUrlTemplate
        /// The URL that is returned to the CodePipeline console that links to the top-level landing page for
        /// the external system, such as the console page for CodeDeploy.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("ExecutionUrlTemplate")]
        public Union<string, IntrinsicFunction> ExecutionUrlTemplate { get; set; }

        /// <summary>
        /// RevisionUrlTemplate
        /// The URL that is returned to the CodePipeline console that links to the page where customers can
        /// update or change the configuration of the external action.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("RevisionUrlTemplate")]
        public Union<string, IntrinsicFunction> RevisionUrlTemplate { get; set; }

        /// <summary>
        /// ThirdPartyConfigurationUrl
        /// The URL of a sign-up page where users can sign up for an external service and specify the initial
        /// configurations for the service&#39;s action.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("ThirdPartyConfigurationUrl")]
        public Union<string, IntrinsicFunction> ThirdPartyConfigurationUrl { get; set; }

    }
}
