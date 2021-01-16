using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.EventStream
{
    /// <summary>
    /// AWS::Pinpoint::EventStream
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-eventstream.html
    /// </summary>
    public class EventStreamResource : ResourceBase
    {
        public class EventStreamProperties
        {
            /// <summary>
            /// ApplicationId
            /// The unique identifier for the Amazon Pinpoint application that you want to publish event data for.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationId { get; set; }

            /// <summary>
            /// DestinationStreamArn
            /// The Amazon Resource Name (ARN) of the Amazon Kinesis data stream or Amazon Kinesis Data Firehose
            /// delivery stream that you want to publish event data to.
            /// For a Kinesis data stream, the ARN format is: arn:aws:kinesis:region:account-id:stream/stream_name
            /// For a Kinesis Data Firehose delivery stream, the ARN format is:
            /// arn:aws:firehose:region:account-id:deliverystream/stream_name
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationStreamArn { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role that authorizes
            /// Amazon Pinpoint to publish event data to the stream in your AWS account.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::EventStream";

        public EventStreamProperties Properties { get; } = new EventStreamProperties();

    }
}
