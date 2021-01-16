using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.EventSubscription
{
    /// <summary>
    /// AWS::RDS::EventSubscription
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-eventsubscription.html
    /// </summary>
    public class EventSubscriptionResource : ResourceBase
    {
        public class EventSubscriptionProperties
        {
            /// <summary>
            /// Enabled
            /// A value that indicates whether to activate the subscription. If the event notification subscription
            /// isn&#39;t activated, the subscription is created but not active.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// EventCategories
            /// A list of event categories for a particular source type (SourceType) that you want to subscribe to.
            /// You can see a list of the categories for a given source type in Events in the Amazon RDS User Guide
            /// or by using the DescribeEventCategories operation.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> EventCategories { get; set; }

            /// <summary>
            /// SnsTopicArn
            /// The Amazon Resource Name (ARN) of the SNS topic created for event notification. The ARN is created
            /// by Amazon SNS when you create a topic and subscribe to it.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SnsTopicArn { get; set; }

            /// <summary>
            /// SourceIds
            /// The list of identifiers of the event sources for which events are returned. If not specified, then
            /// all sources are included in the response. An identifier must begin with a letter and must contain
            /// only ASCII letters, digits, and hyphens. It can&#39;t end with a hyphen or contain two consecutive
            /// hyphens.
            /// Constraints:
            /// If a SourceIds value is supplied, SourceType must also be provided. If the source type is a DB
            /// instance, a DBInstanceIdentifier value must be supplied. If the source type is a DB cluster, a
            /// DBClusterIdentifier value must be supplied. If the source type is a DB parameter group, a
            /// DBParameterGroupName value must be supplied. If the source type is a DB security group, a
            /// DBSecurityGroupName value must be supplied. If the source type is a DB snapshot, a
            /// DBSnapshotIdentifier value must be supplied. If the source type is a DB cluster snapshot, a
            /// DBClusterSnapshotIdentifier value must be supplied.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SourceIds { get; set; }

            /// <summary>
            /// SourceType
            /// The type of source that is generating the events. For example, if you want to be notified of events
            /// generated by a DB instance, set this parameter to db-instance. If this value isn&#39;t specified, all
            /// events are returned.
            /// Valid values: db-instance | db-cluster | db-parameter-group | db-security-group | db-snapshot |
            /// db-cluster-snapshot
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
            public Union<string, IntrinsicFunction> SourceType { get; set; }

        }

        public string Type { get; } = "AWS::RDS::EventSubscription";

        public EventSubscriptionProperties Properties { get; } = new EventSubscriptionProperties();

    }
}
