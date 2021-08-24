using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule Action
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// S3
        /// Write to an Amazon S3 bucket.
        /// Required: No
        /// Type: S3Action
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3")]
        public S3Action S3 { get; set; }

        /// <summary>
        /// CloudwatchAlarm
        /// Change the state of a CloudWatch alarm.
        /// Required: No
        /// Type: CloudwatchAlarmAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudwatchAlarm")]
        public CloudwatchAlarmAction CloudwatchAlarm { get; set; }

        /// <summary>
        /// CloudwatchLogs
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: CloudwatchLogsAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudwatchLogs")]
        public CloudwatchLogsAction CloudwatchLogs { get; set; }

        /// <summary>
        /// IotEvents
        /// Sends an input to an AWS IoT Events detector.
        /// Required: No
        /// Type: IotEventsAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IotEvents")]
        public IotEventsAction IotEvents { get; set; }

        /// <summary>
        /// Firehose
        /// Write to an Amazon Kinesis Firehose stream.
        /// Required: No
        /// Type: FirehoseAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Firehose")]
        public FirehoseAction Firehose { get; set; }

        /// <summary>
        /// Republish
        /// Publish to another MQTT topic.
        /// Required: No
        /// Type: RepublishAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Republish")]
        public RepublishAction Republish { get; set; }

        /// <summary>
        /// StepFunctions
        /// Starts execution of a Step Functions state machine.
        /// Required: No
        /// Type: StepFunctionsAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StepFunctions")]
        public StepFunctionsAction StepFunctions { get; set; }

        /// <summary>
        /// DynamoDB
        /// Write to a DynamoDB table.
        /// Required: No
        /// Type: DynamoDBAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DynamoDB")]
        public DynamoDBAction DynamoDB { get; set; }

        /// <summary>
        /// Http
        /// Send data to an HTTPS endpoint.
        /// Required: No
        /// Type: HttpAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Http")]
        public HttpAction Http { get; set; }

        /// <summary>
        /// DynamoDBv2
        /// Write to a DynamoDB table. This is a new version of the DynamoDB action. It allows you to write each
        /// attribute in an MQTT message payload into a separate DynamoDB column.
        /// Required: No
        /// Type: DynamoDBv2Action
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DynamoDBv2")]
        public DynamoDBv2Action DynamoDBv2 { get; set; }

        /// <summary>
        /// CloudwatchMetric
        /// Capture a CloudWatch metric.
        /// Required: No
        /// Type: CloudwatchMetricAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudwatchMetric")]
        public CloudwatchMetricAction CloudwatchMetric { get; set; }

        /// <summary>
        /// IotSiteWise
        /// Sends data from the MQTT message that triggered the rule to AWS IoT SiteWise asset properties.
        /// Required: No
        /// Type: IotSiteWiseAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IotSiteWise")]
        public IotSiteWiseAction IotSiteWise { get; set; }

        /// <summary>
        /// Elasticsearch
        /// Write data to an Amazon Elasticsearch Service domain.
        /// Required: No
        /// Type: ElasticsearchAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Elasticsearch")]
        public ElasticsearchAction Elasticsearch { get; set; }

        /// <summary>
        /// Sqs
        /// Publish to an Amazon SQS queue.
        /// Required: No
        /// Type: SqsAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sqs")]
        public SqsAction Sqs { get; set; }

        /// <summary>
        /// Kinesis
        /// Write data to an Amazon Kinesis stream.
        /// Required: No
        /// Type: KinesisAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Kinesis")]
        public KinesisAction Kinesis { get; set; }

        /// <summary>
        /// IotAnalytics
        /// Sends message data to an AWS IoT Analytics channel.
        /// Required: No
        /// Type: IotAnalyticsAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IotAnalytics")]
        public IotAnalyticsAction IotAnalytics { get; set; }

        /// <summary>
        /// Sns
        /// Publish to an Amazon SNS topic.
        /// Required: No
        /// Type: SnsAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sns")]
        public SnsAction Sns { get; set; }

        /// <summary>
        /// Lambda
        /// Invoke a Lambda function.
        /// Required: No
        /// Type: LambdaAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Lambda")]
        public LambdaAction Lambda { get; set; }

        /// <summary>
        /// Timestream
        /// Writes attributes from an MQTT message.
        /// Required: No
        /// Type: TimestreamAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Timestream")]
        public TimestreamAction Timestream { get; set; }

        /// <summary>
        /// Kafka
        /// Send messages to an Amazon Managed Streaming for Apache Kafka (Amazon MSK) or self-managed Apache
        /// Kafka cluster.
        /// Required: No
        /// Type: KafkaAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Kafka")]
        public KafkaAction Kafka { get; set; }

    }
}
