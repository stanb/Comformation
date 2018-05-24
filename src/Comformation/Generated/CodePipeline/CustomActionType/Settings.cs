using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.CustomActionType
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-settings.html
    /// </summary>
    public class Settings
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-settings.html#cfn-codepipeline-customactiontype-settings-entityurltemplate
        /// </summary>
        [JsonProperty("EntityUrlTemplate")]
        public Union<string, IntrinsicFunction> EntityUrlTemplate { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-settings.html#cfn-codepipeline-customactiontype-settings-executionurltemplate
        /// </summary>
        [JsonProperty("ExecutionUrlTemplate")]
        public Union<string, IntrinsicFunction> ExecutionUrlTemplate { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-settings.html#cfn-codepipeline-customactiontype-settings-revisionurltemplate
        /// </summary>
        [JsonProperty("RevisionUrlTemplate")]
        public Union<string, IntrinsicFunction> RevisionUrlTemplate { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-settings.html#cfn-codepipeline-customactiontype-settings-thirdpartyconfigurationurl
        /// </summary>
        [JsonProperty("ThirdPartyConfigurationUrl")]
        public Union<string, IntrinsicFunction> ThirdPartyConfigurationUrl { get; set; }

    }
}
