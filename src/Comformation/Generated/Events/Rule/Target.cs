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
        /// Type: EcsParameters
        /// </summary>
        [JsonProperty("EcsParameters")]
        public EcsParameters EcsParameters { get; set; }

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
        /// Required: No. If you don&#39;t specify both this property and the InputPath property, CloudWatch Events
        /// passes the entire matched event to the target.
        /// Type: String
        /// </summary>
        [JsonProperty("Input")]
        public Union<string, IntrinsicFunction> Input { get; set; }

        /// <summary>
        /// InputPath
        /// When you don&#39;t want to pass the entire matched event, the JSONPath that describes which part of the
        /// event to pass to the target.
        /// Required: No. If you don&#39;t specify both this property and the Input property, CloudWatch Events
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
        /// Type: InputTransformer
        /// </summary>
        [JsonProperty("InputTransformer")]
        public InputTransformer InputTransformer { get; set; }

        /// <summary>
        /// KinesisParameters
        /// Settings that control shard assignment, when the target is a Kinesis stream. If you don&#39;t include
        /// this parameter, eventId is used as the partition key.
        /// Required: No
        /// Type: KinesisParameters
        /// </summary>
        [JsonProperty("KinesisParameters")]
        public KinesisParameters KinesisParameters { get; set; }

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
        /// Type: RunCommandParameters
        /// </summary>
        [JsonProperty("RunCommandParameters")]
        public RunCommandParameters RunCommandParameters { get; set; }

        /// <summary>
        /// SqsParameters
        /// Specifies the message group ID to use when the target is a FIFO queue.
        /// If you specify an Amazon SQS FIFO queue as a target, the queue must have content-based deduplication
        /// enabled.
        /// Required: No
        /// Type: SqsParameters
        /// </summary>
        [JsonProperty("SqsParameters")]
        public SqsParameters SqsParameters { get; set; }

    }
}
