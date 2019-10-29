using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline ActionDeclaration
    /// Represents information about an action declaration.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-stages-actions.html
    /// </summary>
    public class ActionDeclaration
    {

        /// <summary>
        /// ActionTypeId
        /// Specifies the action type and the provider of the action.
        /// Required: Yes
        /// Type: ActionTypeId
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ActionTypeId")]
        public ActionTypeId ActionTypeId { get; set; }

        /// <summary>
        /// Configuration
        /// The action&#39;s configuration. These are key-value pairs that specify input values for an action. For
        /// more information, see Action Structure Requirements in CodePipeline. For the list of configuration
        /// properties for the AWS CloudFormation action type in CodePipeline, see Configuration Properties
        /// Reference in the AWS CloudFormation User Guide. For template snippets with examples, see Using
        /// Parameter Override Functions with CodePipeline Pipelines in the AWS CloudFormation User Guide.
        /// The values can be represented in either JSON or YAML format. For example, the JSON configuration
        /// item format is as follows:
        /// JSON:
        /// &quot;Configuration&quot; : { Key : Value },
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Configuration")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Configuration { get; set; }

        /// <summary>
        /// InputArtifacts
        /// The name or ID of the artifact consumed by the action, such as a test or build artifact.
        /// Required: No
        /// Type: List of InputArtifact
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputArtifacts")]
        public List<InputArtifact> InputArtifacts { get; set; }

        /// <summary>
        /// Name
        /// The action declaration&#39;s name.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: [A-Za-z0-9. @\-_]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// OutputArtifacts
        /// The name or ID of the result of the action declaration, such as a test or build artifact.
        /// Required: No
        /// Type: List of OutputArtifact
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputArtifacts")]
        public List<OutputArtifact> OutputArtifacts { get; set; }

        /// <summary>
        /// Region
        /// The action declaration&#39;s AWS Region, such as us-east-1.
        /// Required: No
        /// Type: String
        /// Minimum: 4
        /// Maximum: 30
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM service role that performs the declared action. This is assumed through the
        /// roleArn for the pipeline.
        /// Required: No
        /// Type: String
        /// Maximum: 1024
        /// Pattern: arn:aws(-[\w]+)*:iam::[0-9]{12}:role/. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// RunOrder
        /// The order in which actions are run.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 999
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RunOrder")]
        public Union<int, IntrinsicFunction> RunOrder { get; set; }

    }
}
