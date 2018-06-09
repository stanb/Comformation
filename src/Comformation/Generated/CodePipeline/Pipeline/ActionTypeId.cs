using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS CodePipeline Pipeline Stages Actions ActionTypeId
    /// ActionTypeId is a property of the AWS CodePipeline Pipeline Stages Actions property that specifies the action
    /// type and provider for an AWS CodePipeline action.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages-actions-actiontypeid.html
    /// </summary>
    public class ActionTypeId
    {

        /// <summary>
        /// Category
        /// A category that defines which action type the owner (the entity that performs the action) performs.
        /// The category that you select determine the providers that you can specify for the Provider property.
        /// For valid values, see ActionTypeId in the AWS CodePipeline API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Category")]
        public Union<string, IntrinsicFunction> Category { get; set; }

        /// <summary>
        /// Owner
        /// The entity that performs the action. For valid values, see ActionTypeId in the AWS CodePipeline API
        /// Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Owner")]
        public Union<string, IntrinsicFunction> Owner { get; set; }

        /// <summary>
        /// Provider
        /// The service provider that the action calls. The providers that you can specify are determined by the
        /// category that you select. For example, a valid provider for the Deploy category is AWS CodeDeploy,
        /// which you would specify as CodeDeploy.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Provider")]
        public Union<string, IntrinsicFunction> Provider { get; set; }

        /// <summary>
        /// Version
        /// A version identifier for this action.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
