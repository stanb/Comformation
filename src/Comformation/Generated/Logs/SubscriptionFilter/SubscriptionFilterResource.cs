using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Logs.SubscriptionFilter
{
    /// <summary>
    /// AWS::Logs::SubscriptionFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html
    /// </summary>
    public class SubscriptionFilterResource : ResourceBase
    {
        public class SubscriptionFilterProperties
        {
            /// <summary>
            /// DestinationArn
            /// The Amazon Resource Name (ARN) of the destination.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationArn { get; set; }

            /// <summary>
            /// FilterPattern
            /// The filtering expressions that restrict what gets delivered to the destination AWS resource. For
            /// more information about the filter pattern syntax, see Filter and Pattern Syntax.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FilterPattern { get; set; }

            /// <summary>
            /// LogGroupName
            /// The log group to associate with the subscription filter. All log events that are uploaded to this
            /// log group are filtered and delivered to the specified AWS resource if the filter pattern matches the
            /// log events.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Pattern: [\. \-_/#A-Za-z0-9]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> LogGroupName { get; set; }

            /// <summary>
            /// RoleArn
            /// The ARN of an IAM role that grants CloudWatch Logs permissions to deliver ingested log events to the
            /// destination stream. You don&#39;t need to provide the ARN when you are working with a logical
            /// destination for cross-account delivery.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }

        public string Type { get; } = "AWS::Logs::SubscriptionFilter";

        public SubscriptionFilterProperties Properties { get; } = new SubscriptionFilterProperties();

    }
}
