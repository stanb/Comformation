using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.CustomActionType
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-settings.html
    /// </summary>
    public class Settings
    {

        /// <summary>
        /// EntityUrlTemplate
        /// </summary>
        [JsonProperty("EntityUrlTemplate")]
        public Union<string, IntrinsicFunction> EntityUrlTemplate { get; set; }

        /// <summary>
        /// ExecutionUrlTemplate
        /// </summary>
        [JsonProperty("ExecutionUrlTemplate")]
        public Union<string, IntrinsicFunction> ExecutionUrlTemplate { get; set; }

        /// <summary>
        /// RevisionUrlTemplate
        /// </summary>
        [JsonProperty("RevisionUrlTemplate")]
        public Union<string, IntrinsicFunction> RevisionUrlTemplate { get; set; }

        /// <summary>
        /// ThirdPartyConfigurationUrl
        /// </summary>
        [JsonProperty("ThirdPartyConfigurationUrl")]
        public Union<string, IntrinsicFunction> ThirdPartyConfigurationUrl { get; set; }

    }
}
