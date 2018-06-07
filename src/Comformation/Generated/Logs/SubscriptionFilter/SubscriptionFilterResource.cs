using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.SubscriptionFilter
{
    /// <summary>
    /// AWS::Logs::SubscriptionFilter
    /// The AWS::Logs::SubscriptionFilter resource creates an Amazon CloudWatch Logs (CloudWatch Logs) subscription
    /// filter that defines which log events are delivered to your Kinesis stream or AWS Lambda (Lambda) function and
    /// where to send them.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html
    /// </summary>
    public class SubscriptionFilterResource : ResourceBase
    {
        public class SubscriptionFilterProperties
        {
            /// <summary>
            /// DestinationArn
            /// The Amazon Resource Name (ARN) of the Kinesis stream, Kinesis Data Firehose delivery stream, or
            /// Lambda function that you want to use as the subscription feed destination.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html#cfn-cwl-subscriptionfilter-destinationarn
            /// </summary>
			public Union<string, IntrinsicFunction> DestinationArn { get; set; }

            /// <summary>
            /// FilterPattern
            /// The filtering expressions that restrict what gets delivered to the destination AWS resource. For
            /// more information about the filter pattern syntax, see Filter and Pattern Syntax in the Amazon
            /// CloudWatch User Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html#cfn-cwl-subscriptionfilter-filterpattern
            /// </summary>
			public Union<string, IntrinsicFunction> FilterPattern { get; set; }

            /// <summary>
            /// LogGroupName
            /// The log group to associate with the subscription filter. All log events that are uploaded to this
            /// log group are filtered and delivered to the specified AWS resource if the filter pattern matches the
            /// log events.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html#cfn-cwl-subscriptionfilter-loggroupname
            /// </summary>
			public Union<string, IntrinsicFunction> LogGroupName { get; set; }

            /// <summary>
            /// RoleArn
            /// An IAM role that grants CloudWatch Logs permission to put data into the specified Kinesis stream.
            /// For Lambda and CloudWatch Logs destinations, don't specify this property because CloudWatch Logs
            /// gets the necessary permissions from the destination resource.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html#cfn-cwl-subscriptionfilter-rolearn
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }
    
        public string Type { get; } = "AWS::Logs::SubscriptionFilter";
        
        public SubscriptionFilterProperties Properties { get; } = new SubscriptionFilterProperties();
    }
}
