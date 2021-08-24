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
        /// Contains the HTTP parameters to use when the target is a API Gateway REST endpoint or EventBridge
        /// ApiDestination.
        /// If you specify an API Gateway REST API or EventBridge ApiDestination as a target, you can use this
        /// parameter to specify headers, path parameters, and query string keys/values as part of your target
        /// invoking request. If you&#39;re using ApiDestinations, the corresponding Connection can also have these
        /// values configured. In case of any conflicting keys, values from the Connection take precedence.
        /// Required: No
        /// Type: HttpParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpParameters")]
        public HttpParameters HttpParameters { get; set; }

        /// <summary>
        /// Id
        /// The ID of the target. We recommend using a memorable and unique string.
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
        /// Valid JSON text passed to the target. In this case, nothing from the event itself is passed to the
        /// target. For more information, see The JavaScript Object Notation (JSON) Data Interchange Format.
        /// Required: No
        /// Type: String
        /// Maximum: 8192
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Input")]
        public Union<string, IntrinsicFunction> Input { get; set; }

        /// <summary>
        /// InputPath
        /// The value of the JSONPath that is used for extracting part of the matched event when passing it to
        /// the target. You must use JSON dot notation, not bracket notation. For more information about JSON
        /// paths, see JSONPath.
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
        /// Contains the Amazon Redshift Data API parameters to use when the target is a Amazon Redshift
        /// cluster.
        /// If you specify a Amazon Redshift Cluster as a Target, you can use this to specify parameters to
        /// invoke the Amazon Redshift Data API ExecuteStatement based on EventBridge events.
        /// Required: No
        /// Type: RedshiftDataParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RedshiftDataParameters")]
        public RedshiftDataParameters RedshiftDataParameters { get; set; }

        /// <summary>
        /// RetryPolicy
        /// The RetryPolicy object that contains the retry policy configuration to use for the dead-letter
        /// queue.
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
