using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.EventSourceMapping
{
    /// <summary>
    /// AWS::Lambda::EventSourceMapping
    /// The AWS::Lambda::EventSourceMapping resource specifies a stream as an event source for an AWS Lambda (Lambda)
    /// function. The stream can be an Kinesis stream or an Amazon DynamoDB (DynamoDB) stream. Lambda invokes the
    /// associated function when records are posted to the stream. For more information, see CreateEventSourceMapping
    /// in the AWS Lambda Developer Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html
    /// </summary>
    public class EventSourceMappingResource : ResourceBase
    {
        public class EventSourceMappingProperties
        {
            /// <summary>
            /// BatchSize
            /// The largest number of records that Lambda retrieves from your event source when invoking your
            /// function. Your function receives an event with all the retrieved records. For the default and valid
            /// values, see CreateEventSourceMapping in the AWS Lambda Developer Guide.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-batchsize
            /// </summary>
			public Union<int, IntrinsicFunction> BatchSize { get; set; }

            /// <summary>
            /// Enabled
            /// Indicates whether Lambda begins polling the event source.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-enabled
            /// </summary>
			public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// EventSourceArn
            /// The Amazon Resource Name (ARN) of the Kinesis or DynamoDB stream that is the source of events. Any
            /// record added to this stream can invoke the Lambda function. For more information, see
            /// CreateEventSourceMapping in the AWS Lambda Developer Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-eventsourcearn
            /// </summary>
			public Union<string, IntrinsicFunction> EventSourceArn { get; set; }

            /// <summary>
            /// FunctionName
            /// The name or ARN of a Lambda function to invoke when Lambda detects an event on the stream.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-functionname
            /// </summary>
			public Union<string, IntrinsicFunction> FunctionName { get; set; }

            /// <summary>
            /// StartingPosition
            /// The position in the stream where Lambda starts reading. For valid values, see
            /// CreateEventSourceMapping in the AWS Lambda Developer Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-startingposition
            /// </summary>
			public Union<string, IntrinsicFunction> StartingPosition { get; set; }

        }
    
        public string Type { get; } = "AWS::Lambda::EventSourceMapping";
        
        public EventSourceMappingProperties Properties { get; } = new EventSourceMappingProperties();
    }
}
