using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule Target
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
        /// BatchParameters
        /// If the event target is an AWS Batch job, this contains the job definition, job name, and other
        /// parameters. For more information, see Jobs in the AWS Batch User Guide.
        /// Required: No
        /// Type: BatchParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BatchParameters")]
        public BatchParameters BatchParameters { get; set; }

        /// <summary>
        /// DeadLetterConfig
        /// The DeadLetterConfig that defines the target queue to send dead-letter queue events to.
        /// To learn more using a dead-letter queue to send events that fail to be delivered to a target, see
        /// Event retry policy and using dead-letter queues.
        /// Required: No
        /// Type: DeadLetterConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeadLetterConfig")]
        public DeadLetterConfig DeadLetterConfig { get; set; }

        /// <summary>
        /// EcsParameters
        /// Contains the Amazon ECS task definition and task count to be used, if the event target is an Amazon
        /// ECS task. For more information about Amazon ECS tasks, see Task Definitions in the Amazon EC2
        /// Container Service Developer Guide.
        /// Required: No
        /// Type: EcsParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EcsParameters")]
        public EcsParameters EcsParameters { get; set; }

        /// <summary>
        /// HttpParameters
        /// Contains the HTTP parameters to use when the target is a API Gateway REST endpoint.
        /// If you specify an API Gateway REST API as a target, you can use this parameter to specify headers,
        /// path parameter, query string keys/values as part of your target invoking request.
        /// Required: No
        /// Type: HttpParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpParameters")]
        public HttpParameters HttpParameters { get; set; }

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
        /// The custom parameter you can use to control the shard assignment, when the target is a Kinesis data
        /// stream. If you do not include this parameter, the default is to use the eventId as the partition
        /// key.
        /// Required: No
        /// Type: KinesisParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisParameters")]
        public KinesisParameters KinesisParameters { get; set; }

        /// <summary>
        /// RedshiftDataParameters
        /// Contains the Redshift Data API parameters to use when the target is a Redshift cluster.
        /// If you specify a Redshift Cluster as a Target, you can use this to specify parameters to invoke the
        /// Redshift Data API ExecuteStatement based on EventBridge events.
        /// Required: No
        /// Type: RedshiftDataParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RedshiftDataParameters")]
        public RedshiftDataParameters RedshiftDataParameters { get; set; }

        /// <summary>
        /// RetryPolicy
        /// A RetryPolicy object that includes information about the retry policy settings.
        /// To learn more using retry policy settings and using dead-letter queues, see Event retry policy and
        /// using dead-letter queues.
        /// Required: No
        /// Type: RetryPolicy
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RetryPolicy")]
        public RetryPolicy RetryPolicy { get; set; }

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
