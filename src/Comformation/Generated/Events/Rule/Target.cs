using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule Target
    /// The Target property type specifies a target, such as an AWS Lambda function or an Amazon Kinesis data stream,
    /// that EventBridge invokes when a rule is triggered.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html
    /// </summary>
    public class Target
    {

        /// <summary>
        /// Arn
        /// The Amazon Resource Name (ARN) of the target.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1600
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// EcsParameters
        /// Contains the Amazon ECS task definition and task count to be used if the event target is an Amazon
        /// ECS task. For more information about Amazon ECS tasks, see Task Definitions in the Amazon EC2
        /// Container Service Developer Guide.
        /// Required: No
        /// Type: EcsParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EcsParameters")]
        public EcsParameters EcsParameters { get; set; }

        /// <summary>
        /// Id
        /// A name for the target. Use a string that will help you identify the target. Each target associated
        /// with a rule must have an Id unique for that rule.
        /// The Id can include alphanumeric characters, periods (. ), hyphens (-), and underscores (_).
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Pattern: [\. \-_A-Za-z0-9]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Input
        /// Valid JSON text passed to the target. If you use this property, nothing from the event text itself
        /// is passed to the target.
        /// Required: No
        /// Type: String
        /// Maximum: 8192
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Input")]
        public Union<string, IntrinsicFunction> Input { get; set; }

        /// <summary>
        /// InputPath
        /// When you don&#39;t want to pass the entire matched event, InputPath describes which part of the event to
        /// pass to the target.
        /// Required: No
        /// Type: String
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputPath")]
        public Union<string, IntrinsicFunction> InputPath { get; set; }

        /// <summary>
        /// InputTransformer
        /// Settings to enable you to provide custom input to a target based on certain event data. You can
        /// extract one or more key-value pairs from the event and then use that data to send customized input
        /// to the target.
        /// Required: No
        /// Type: InputTransformer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputTransformer")]
        public InputTransformer InputTransformer { get; set; }

        /// <summary>
        /// KinesisParameters
        /// The custom parameter that you can use to control the shard assignment when the target is a Kinesis
        /// data stream. If you don&#39;t include this parameter, the default is to use the eventId as the partition
        /// key.
        /// Required: No
        /// Type: KinesisParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisParameters")]
        public KinesisParameters KinesisParameters { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of the IAM role to be used for this target when the rule is
        /// triggered. If one rule triggers multiple targets, you can use a different IAM role for each target.
        /// If you&#39;re setting an event bus in another account as the target and that account granted permission
        /// to your account through an organization instead of directly by the account ID, you must specify a
        /// RoleArn with proper permissions here in this parameter.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1600
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// RunCommandParameters
        /// Parameters used when you are using the rule to invoke Amazon EC2 Run Command.
        /// Required: No
        /// Type: RunCommandParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RunCommandParameters")]
        public RunCommandParameters RunCommandParameters { get; set; }

        /// <summary>
        /// SqsParameters
        /// Contains the message group ID to use when the target is a FIFO queue.
        /// If you specify an SQS FIFO queue as a target, the queue must have content-based deduplication
        /// enabled.
        /// Required: No
        /// Type: SqsParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SqsParameters")]
        public SqsParameters SqsParameters { get; set; }

    }
}
