using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.EventSubscription
{
    /// <summary>
    /// AWS::DMS::EventSubscription
    /// Use the AWS::DMS::EventSubscription resource to get notifications for AWS Database Migration Service events
    /// through the Amazon Simple Notification Service. For more information, see Using AWS DMS Event Notification in
    /// the AWS Database Migration Service User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-eventsubscription.html
    /// </summary>
    public class EventSubscriptionResource : ResourceBase
    {
        public class EventSubscriptionProperties
        {
            /// <summary>
            /// SourceType
            /// The type of AWS DMS resource that generates the events. For example, if you want to be notified of
            /// events generated by a replication instance, you set this parameter to replication-instance. If this
            /// value is not specified, all events are returned.
            /// Valid values: replication-instance | replication-task
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SourceType { get; set; }

            /// <summary>
            /// EventCategories
            /// A list of event categories for a source type that you want to subscribe to. If you don&#39;t specify
            /// this property, you are notified about all event categories. For more information, see Working with
            /// Events and Notifications in the AWS Database Migration Service User Guide.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> EventCategories { get; set; }

            /// <summary>
            /// Enabled
            /// Indicates whether to activate the subscription. If you don&#39;t specify this property, AWS
            /// CloudFormation activates the subscription.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// SubscriptionName
            /// The name of the AWS DMS event notification subscription. This name must be less than 255 characters.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubscriptionName { get; set; }

            /// <summary>
            /// SnsTopicArn
            /// The Amazon Resource Name (ARN) of the Amazon SNS topic created for event notification. The ARN is
            /// created by Amazon SNS when you create a topic and subscribe to it.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> SnsTopicArn { get; set; }

            /// <summary>
            /// SourceIds
            /// A list of identifiers for which AWS DMS provides notification events.
            /// If you don&#39;t specify a value, notifications are provided for all sources.
            /// If you specify multiple values, they must be of the same type. For example, if you specify a
            /// database instance ID, then all of the other values must be database instance IDs.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SourceIds { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags to be assigned to the event subscription.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DMS::EventSubscription";

        public EventSubscriptionProperties Properties { get; } = new EventSubscriptionProperties();

    }
}
