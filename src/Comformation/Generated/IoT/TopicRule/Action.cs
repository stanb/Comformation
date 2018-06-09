using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS IoT TopicRule Action
    /// Action is a property of the TopicRulePayload property that describes an action associated with an AWS IoT
    /// rule. For more information, see Rules for AWS IoT.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// CloudwatchAlarm
        /// Changes the state of a CloudWatch alarm.
        /// Required: No
        /// Type: AWS IoT TopicRule CloudwatchAlarmAction
        /// </summary>
        [JsonProperty("CloudwatchAlarm")]
        public Union<CloudwatchAlarmAction, IntrinsicFunction> CloudwatchAlarm { get; set; }

        /// <summary>
        /// CloudwatchMetric
        /// Captures a CloudWatch metric.
        /// Required: No
        /// Type: AWS IoT TopicRule CloudwatchMetricAction
        /// </summary>
        [JsonProperty("CloudwatchMetric")]
        public Union<CloudwatchMetricAction, IntrinsicFunction> CloudwatchMetric { get; set; }

        /// <summary>
        /// DynamoDB
        /// Writes data to a DynamoDB table.
        /// Required: No
        /// Type: AWS IoT TopicRule DynamoDBAction
        /// </summary>
        [JsonProperty("DynamoDB")]
        public Union<DynamoDBAction, IntrinsicFunction> DynamoDB { get; set; }

        /// <summary>
        /// DynamoDBv2
        /// Writes data to a DynamoDB table.
        /// Required: No
        /// Type: AWS IoT TopicRule DynamoDBv2Action
        /// </summary>
        [JsonProperty("DynamoDBv2")]
        public Union<DynamoDBv2Action, IntrinsicFunction> DynamoDBv2 { get; set; }

        /// <summary>
        /// Elasticsearch
        /// Writes data to an Elasticsearch domain.
        /// Required: No
        /// Type: AWS IoT TopicRule ElasticsearchAction
        /// </summary>
        [JsonProperty("Elasticsearch")]
        public Union<ElasticsearchAction, IntrinsicFunction> Elasticsearch { get; set; }

        /// <summary>
        /// Firehose
        /// Writes data to a Kinesis Data Firehose stream.
        /// Required: No
        /// Type: AWS IoT TopicRule FirehoseAction
        /// </summary>
        [JsonProperty("Firehose")]
        public Union<FirehoseAction, IntrinsicFunction> Firehose { get; set; }

        /// <summary>
        /// Kinesis
        /// Writes data to an Kinesis stream.
        /// Required: No
        /// Type: AWS IoT TopicRule KinesisAction
        /// </summary>
        [JsonProperty("Kinesis")]
        public Union<KinesisAction, IntrinsicFunction> Kinesis { get; set; }

        /// <summary>
        /// Lambda
        /// Invokes a Lambda function.
        /// Required: No
        /// Type: AWS IoT TopicRule LambdaAction
        /// </summary>
        [JsonProperty("Lambda")]
        public Union<LambdaAction, IntrinsicFunction> Lambda { get; set; }

        /// <summary>
        /// Republish
        /// Publishes data to an MQ Telemetry Transport (MQTT) topic different from the one currently specified.
        /// Required: No
        /// Type: AWS IoT TopicRule RepublishAction
        /// </summary>
        [JsonProperty("Republish")]
        public Union<RepublishAction, IntrinsicFunction> Republish { get; set; }

        /// <summary>
        /// S3
        /// Writes data to an S3 bucket.
        /// Required: No
        /// Type: AWS IoT TopicRule S3Action
        /// </summary>
        [JsonProperty("S3")]
        public Union<S3Action, IntrinsicFunction> S3 { get; set; }

        /// <summary>
        /// Sns
        /// Publishes data to an SNS topic.
        /// Required: No
        /// Type: AWS IoT TopicRule SnsAction
        /// </summary>
        [JsonProperty("Sns")]
        public Union<SnsAction, IntrinsicFunction> Sns { get; set; }

        /// <summary>
        /// Sqs
        /// Publishes data to an SQS queue.
        /// Required: No
        /// Type: AWS IoT TopicRule SqsAction
        /// </summary>
        [JsonProperty("Sqs")]
        public Union<SqsAction, IntrinsicFunction> Sqs { get; set; }

    }
}
