using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.EventSubscription
{
    /// <summary>
    /// AWS::RDS::EventSubscription
    /// Use the AWS::RDS::EventSubscription resource to get notifications for Amazon Relational Database Service
    /// events through the Amazon Simple Notification Service. For more information, see Using Amazon RDS Event
    /// Notification in the Amazon RDS User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-eventsubscription.html
    /// </summary>
    public class EventSubscriptionResource : ResourceBase
    {
        public class EventSubscriptionProperties
        {
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
            /// EventCategories
            /// A list of event categories that you want to subscribe to for a given source type. If you don&#39;t
            /// specify this property, you are notified about all event categories. For more information, see Using
            /// Amazon RDS Event Notification in the Amazon RDS User Guide.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> EventCategories { get; set; }

            /// <summary>
            /// SnsTopicArn
            /// The Amazon Resource Name (ARN) of an Amazon SNS topic that you want to send event notifications to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SnsTopicArn { get; set; }

            /// <summary>
            /// SourceIds
            /// A list of identifiers for which Amazon RDS provides notification events.
            /// If you don&#39;t specify a value, notifications are provided for all sources. If you specify multiple
            /// values, they must be of the same type. For example, if you specify a database instance ID, all other
            /// values must be database instance IDs.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SourceIds { get; set; }

            /// <summary>
            /// SourceType
            /// The type of source for which Amazon RDS provides notification events. For example, if you want to be
            /// notified of events generated by a database instance, set this parameter to db-instance. If you don&#39;t
            /// specify a value, notifications are provided for all source types. For valid values, see the
            /// SourceType parameter for the CreateEventSubscription action in the Amazon RDS API Reference.
            /// Required: Conditional. If you specify the SourceIds or EventCategories property, you must specify
            /// this property.
            /// Type: String
            /// Update requires: Replacement if you&#39;re removing this property after it was previously specified. All
            /// other updates require no interruption.
            /// </summary>
			public Union<string, IntrinsicFunction> SourceType { get; set; }

        }
    
        public string Type { get; } = "AWS::RDS::EventSubscription";
        
        public EventSubscriptionProperties Properties { get; } = new EventSubscriptionProperties();

    }
}
