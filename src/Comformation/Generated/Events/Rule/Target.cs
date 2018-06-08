using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// Amazon CloudWatch Events Rule Target
    /// The Target property type specifies a target, such as AWS Lambda (Lambda) functions or Kinesis streams, that
    /// CloudWatch Events invokes when a rule is triggered.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html
    /// </summary>
    public class Target
    {

        /// <summary>
        /// Arn
        /// The Amazon Resource Name (ARN) of the target.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// EcsParameters
        /// The Amazon ECS task definition and task count to use, if the event target is an Amazon ECS task.
        /// Required: No
        /// Type: CloudWatch Events Rule EcsParameters
        /// </summary>
        [JsonProperty("EcsParameters")]
        public Union<EcsParameters, IntrinsicFunction> EcsParameters { get; set; }

        /// <summary>
        /// Id
        /// A unique, user-defined identifier for the target. Acceptable values include alphanumeric characters,
        /// periods (. ), hyphens (-), and underscores (_).
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Input
        /// A JSON-formatted text string that is passed to the target. This value overrides the matched event.
        /// Required: No. If you don't specify both this property and the InputPath property, CloudWatch Events
        /// passes the entire matched event to the target.
        /// Type: String
        /// </summary>
        [JsonProperty("Input")]
        public Union<string, IntrinsicFunction> Input { get; set; }

        /// <summary>
        /// InputPath
        /// When you don't want to pass the entire matched event, the JSONPath that describes which part of the
        /// event to pass to the target.
        /// Required: No. If you don't specify both this property and the Input property, CloudWatch Events
        /// passes the entire matched event to the target.
        /// Type: String
        /// </summary>
        [JsonProperty("InputPath")]
        public Union<string, IntrinsicFunction> InputPath { get; set; }

        /// <summary>
        /// InputTransformer
        /// Settings that provide custom input to a target based on certain event data. You can extract one or
        /// more key-value pairs from the event, and then use that data to send customized input to the target.
        /// Required: No
        /// Type: CloudWatch Events Rule InputTransformer
        /// </summary>
        [JsonProperty("InputTransformer")]
        public Union<InputTransformer, IntrinsicFunction> InputTransformer { get; set; }

        /// <summary>
        /// KinesisParameters
        /// Settings that control shard assignment, when the target is a Kinesis stream. If you don't include
        /// this parameter, eventId is used as the partition key.
        /// Required: No
        /// Type: CloudWatch Events Rule KinesisParameters
        /// </summary>
        [JsonProperty("KinesisParameters")]
        public Union<KinesisParameters, IntrinsicFunction> KinesisParameters { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role to use for this
        /// target when the rule is triggered. If one rule triggers multiple targets, you can use a different
        /// IAM role for each target.
        /// Note CloudWatch Events needs appropriate permissions to make API calls against the resources you
        /// own. For Kinesis streams, CloudWatch Events relies on IAM roles. For Lambda, Amazon SNS, and Amazon
        /// SQS resources, CloudWatch Events relies on resource-based policies. For more information, see Using
        /// Resource-Based Policies for CloudWatch Events in the Amazon CloudWatch User Guide.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// RunCommandParameters
        /// Parameters used when the rule invokes the AWS Systems Manager Run Command.
        /// Required: No
        /// Type: CloudWatch Events Rule RunCommandParameters
        /// </summary>
        [JsonProperty("RunCommandParameters")]
        public Union<RunCommandParameters, IntrinsicFunction> RunCommandParameters { get; set; }

    }
}
