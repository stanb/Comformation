using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS CodePipeline Pipeline Stages Actions
    /// Actions is a property of the AWS CodePipeline Pipeline Stages property that specifies an action for an AWS
    /// CodePipeline stage.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages-actions.html
    /// </summary>
    public class ActionDeclaration
    {

        /// <summary>
        /// ActionTypeId
        /// Specifies the action type and the provider of the action.
        /// Required: Yes
        /// Type: AWS CodePipeline Pipeline Stages Actions ActionTypeId
        /// </summary>
        [JsonProperty("ActionTypeId")]
        public Union<ActionTypeId, IntrinsicFunction> ActionTypeId { get; set; }

        /// <summary>
        /// Configuration
        /// The action&#39;s configuration. These are key-value pairs that specify input values for an action. For
        /// more information, see Action Structure Requirements in AWS CodePipeline in the AWS CodePipeline User
        /// Guide.
        /// Required: No
        /// Type: JSON object
        /// </summary>
        [JsonProperty("Configuration")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Configuration { get; set; }

        /// <summary>
        /// InputArtifacts
        /// The name or ID of the artifact that the action consumes, such as a test or build artifact.
        /// Required: No
        /// Type: List of AWS CodePipeline Pipeline Stages Actions InputArtifacts
        /// </summary>
        [JsonProperty("InputArtifacts")]
        public Union<List<InputArtifact>, IntrinsicFunction> InputArtifacts { get; set; }

        /// <summary>
        /// Name
        /// The action name.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// OutputArtifacts
        /// The artifact name or ID that is a result of the action, such as a test or build artifact.
        /// Required: No
        /// Type: List of AWS CodePipeline Pipeline Stages Actions OutputArtifacts
        /// </summary>
        [JsonProperty("OutputArtifacts")]
        public Union<List<OutputArtifact>, IntrinsicFunction> OutputArtifacts { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of a service role that the action uses. The pipeline&#39;s role assumes
        /// this role.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// RunOrder
        /// The order in which AWS CodePipeline runs this action.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("RunOrder")]
        public Union<int, IntrinsicFunction> RunOrder { get; set; }

    }
}
