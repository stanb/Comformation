using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-cloudwatchalarm
        /// </summary>
        [JsonProperty("CloudwatchAlarm")]
        public Union<CloudwatchAlarmAction, IntrinsicFunction> CloudwatchAlarm { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-cloudwatchmetric
        /// </summary>
        [JsonProperty("CloudwatchMetric")]
        public Union<CloudwatchMetricAction, IntrinsicFunction> CloudwatchMetric { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-dynamodb
        /// </summary>
        [JsonProperty("DynamoDB")]
        public Union<DynamoDBAction, IntrinsicFunction> DynamoDB { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-dynamodbv2
        /// </summary>
        [JsonProperty("DynamoDBv2")]
        public Union<DynamoDBv2Action, IntrinsicFunction> DynamoDBv2 { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-elasticsearch
        /// </summary>
        [JsonProperty("Elasticsearch")]
        public Union<ElasticsearchAction, IntrinsicFunction> Elasticsearch { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-firehose
        /// </summary>
        [JsonProperty("Firehose")]
        public Union<FirehoseAction, IntrinsicFunction> Firehose { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-kinesis
        /// </summary>
        [JsonProperty("Kinesis")]
        public Union<KinesisAction, IntrinsicFunction> Kinesis { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-lambda
        /// </summary>
        [JsonProperty("Lambda")]
        public Union<LambdaAction, IntrinsicFunction> Lambda { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-republish
        /// </summary>
        [JsonProperty("Republish")]
        public Union<RepublishAction, IntrinsicFunction> Republish { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-s3
        /// </summary>
        [JsonProperty("S3")]
        public Union<S3Action, IntrinsicFunction> S3 { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-sns
        /// </summary>
        [JsonProperty("Sns")]
        public Union<SnsAction, IntrinsicFunction> Sns { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-sqs
        /// </summary>
        [JsonProperty("Sqs")]
        public Union<SqsAction, IntrinsicFunction> Sqs { get; set; }

    }
}
