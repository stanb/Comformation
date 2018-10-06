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
        public CloudwatchAlarmAction CloudwatchAlarm { get; set; }

        /// <summary>
        /// CloudwatchMetric
        /// Captures a CloudWatch metric.
        /// Required: No
        /// Type: AWS IoT TopicRule CloudwatchMetricAction
        /// </summary>
        [JsonProperty("CloudwatchMetric")]
        public CloudwatchMetricAction CloudwatchMetric { get; set; }

        /// <summary>
        /// DynamoDB
        /// Writes data to a DynamoDB table.
        /// Required: No
        /// Type: AWS IoT TopicRule DynamoDBAction
        /// </summary>
        [JsonProperty("DynamoDB")]
        public DynamoDBAction DynamoDB { get; set; }

        /// <summary>
        /// DynamoDBv2
        /// Writes data to a DynamoDB table.
        /// Required: No
        /// Type: AWS IoT TopicRule DynamoDBv2Action
        /// </summary>
        [JsonProperty("DynamoDBv2")]
        public DynamoDBv2Action DynamoDBv2 { get; set; }

        /// <summary>
        /// Elasticsearch
        /// Writes data to an Elasticsearch domain.
        /// Required: No
        /// Type: AWS IoT TopicRule ElasticsearchAction
        /// </summary>
        [JsonProperty("Elasticsearch")]
        public ElasticsearchAction Elasticsearch { get; set; }

        /// <summary>
        /// Firehose
        /// Writes data to a Kinesis Data Firehose stream.
        /// Required: No
        /// Type: AWS IoT TopicRule FirehoseAction
        /// </summary>
        [JsonProperty("Firehose")]
        public FirehoseAction Firehose { get; set; }

        /// <summary>
        /// Kinesis
        /// Writes data to an Kinesis stream.
        /// Required: No
        /// Type: AWS IoT TopicRule KinesisAction
        /// </summary>
        [JsonProperty("Kinesis")]
        public KinesisAction Kinesis { get; set; }

        /// <summary>
        /// Lambda
        /// Invokes a Lambda function.
        /// Required: No
        /// Type: AWS IoT TopicRule LambdaAction
        /// </summary>
        [JsonProperty("Lambda")]
        public LambdaAction Lambda { get; set; }

        /// <summary>
        /// Republish
        /// Publishes data to an MQ Telemetry Transport (MQTT) topic different from the one currently specified.
        /// Required: No
        /// Type: AWS IoT TopicRule RepublishAction
        /// </summary>
        [JsonProperty("Republish")]
        public RepublishAction Republish { get; set; }

        /// <summary>
        /// S3
        /// Writes data to an S3 bucket.
        /// Required: No
        /// Type: AWS IoT TopicRule S3Action
        /// </summary>
        [JsonProperty("S3")]
        public S3Action S3 { get; set; }

        /// <summary>
        /// Sns
        /// Publishes data to an SNS topic.
        /// Required: No
        /// Type: AWS IoT TopicRule SnsAction
        /// </summary>
        [JsonProperty("Sns")]
        public SnsAction Sns { get; set; }

        /// <summary>
        /// Sqs
        /// Publishes data to an SQS queue.
        /// Required: No
        /// Type: AWS IoT TopicRule SqsAction
        /// </summary>
        [JsonProperty("Sqs")]
        public SqsAction Sqs { get; set; }

    }
}
