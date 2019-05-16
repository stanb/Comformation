using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline ActionTypeId
    /// Represents information about an action type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages-actions-actiontypeid.html
    /// </summary>
    public class ActionTypeId
    {

        /// <summary>
        /// Category
        /// A category defines what kind of action can be taken in the stage, and constrains the provider type
        /// for the action. Valid categories are limited to one of the values below.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Category")]
        public Union<string, IntrinsicFunction> Category { get; set; }

        /// <summary>
        /// Owner
        /// The creator of the action being called.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Owner")]
        public Union<string, IntrinsicFunction> Owner { get; set; }

        /// <summary>
        /// Provider
        /// The provider of the service being called by the action. Valid providers are determined by the action
        /// category. For example, an action in the Deploy category type might have a provider of AWS
        /// CodeDeploy, which would be specified as CodeDeploy. To reference a list of action providers by
        /// action type, see Valid Action Types and Providers in CodePipeline.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Provider")]
        public Union<string, IntrinsicFunction> Provider { get; set; }

        /// <summary>
        /// Version
        /// A string that describes the action version.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
