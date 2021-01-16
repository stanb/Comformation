using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel Action
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html
    /// </summary>
    public class Action
    {

        /// <summary>
        /// IotEvents
        /// Sends AWS IoT Events input, which passes information about the detector model instance and the event
        /// that triggered the action.
        /// Required: No
        /// Type: IotEvents
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IotEvents")]
        public IotEvents IotEvents { get; set; }

        /// <summary>
        /// Firehose
        /// Sends information about the detector model instance and the event that triggered the action to an
        /// Amazon Kinesis Data Firehose delivery stream.
        /// Required: No
        /// Type: Firehose
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Firehose")]
        public Firehose Firehose { get; set; }

        /// <summary>
        /// IotTopicPublish
        /// Publishes an MQTT message with the given topic to the AWS IoT message broker.
        /// Required: No
        /// Type: IotTopicPublish
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IotTopicPublish")]
        public IotTopicPublish IotTopicPublish { get; set; }

        /// <summary>
        /// DynamoDB
        /// Writes to the DynamoDB table that you created. The default action payload contains all
        /// attribute-value pairs that have the information about the detector model instance and the event that
        /// triggered the action. You can customize the payload. One column of the DynamoDB table receives all
        /// attribute-value pairs in the payload that you specify. For more information, see Actions in AWS IoT
        /// Events Developer Guide.
        /// Required: No
        /// Type: DynamoDB
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DynamoDB")]
        public DynamoDB DynamoDB { get; set; }

        /// <summary>
        /// DynamoDBv2
        /// Writes to the DynamoDB table that you created. The default action payload contains all
        /// attribute-value pairs that have the information about the detector model instance and the event that
        /// triggered the action. You can customize the payload. A separate column of the DynamoDB table
        /// receives one attribute-value pair in the payload that you specify. For more information, see Actions
        /// in AWS IoT Events Developer Guide.
        /// Required: No
        /// Type: DynamoDBv2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DynamoDBv2")]
        public DynamoDBv2 DynamoDBv2 { get; set; }

        /// <summary>
        /// IotSiteWise
        /// Sends information about the detector model instance and the event that triggered the action to an
        /// asset property in AWS IoT SiteWise .
        /// Required: No
        /// Type: IotSiteWise
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IotSiteWise")]
        public IotSiteWise IotSiteWise { get; set; }

        /// <summary>
        /// ResetTimer
        /// Information needed to reset the timer.
        /// Required: No
        /// Type: ResetTimer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResetTimer")]
        public ResetTimer ResetTimer { get; set; }

        /// <summary>
        /// Sqs
        /// Sends an Amazon SNS message.
        /// Required: No
        /// Type: Sqs
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sqs")]
        public Sqs Sqs { get; set; }

        /// <summary>
        /// Sns
        /// Sends an Amazon SNS message.
        /// Required: No
        /// Type: Sns
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sns")]
        public Sns Sns { get; set; }

        /// <summary>
        /// SetTimer
        /// Information needed to set the timer.
        /// Required: No
        /// Type: SetTimer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SetTimer")]
        public SetTimer SetTimer { get; set; }

        /// <summary>
        /// ClearTimer
        /// Information needed to clear the timer.
        /// Required: No
        /// Type: ClearTimer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClearTimer")]
        public ClearTimer ClearTimer { get; set; }

        /// <summary>
        /// Lambda
        /// Calls a Lambda function, passing in information about the detector model instance and the event that
        /// triggered the action.
        /// Required: No
        /// Type: Lambda
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Lambda")]
        public Lambda Lambda { get; set; }

        /// <summary>
        /// SetVariable
        /// Sets a variable to a specified value.
        /// Required: No
        /// Type: SetVariable
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SetVariable")]
        public SetVariable SetVariable { get; set; }

    }
}
