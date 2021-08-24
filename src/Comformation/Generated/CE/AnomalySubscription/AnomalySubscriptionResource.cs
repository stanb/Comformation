using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CE.AnomalySubscription
{
    /// <summary>
    /// AWS::CE::AnomalySubscription
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalysubscription.html
    /// </summary>
    public class AnomalySubscriptionResource : ResourceBase
    {
        public class AnomalySubscriptionProperties
        {
            /// <summary>
            /// SubscriptionName
            /// The name for the subscription.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Pattern: [\S\s]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SubscriptionName { get; set; }

            /// <summary>
            /// MonitorArnList
            /// A list of cost anomaly monitors.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> MonitorArnList { get; set; }

            /// <summary>
            /// Subscribers
            /// A list of subscribers to notify.
            /// Required: Yes
            /// Type: List of Subscriber
            /// Update requires: No interruption
            /// </summary>
            public List<Subscriber> Subscribers { get; set; }

            /// <summary>
            /// Threshold
            /// The dollar value that triggers a notification if the threshold is exceeded.
            /// Required: Yes
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
            public Union<double, IntrinsicFunction> Threshold { get; set; }

            /// <summary>
            /// Frequency
            /// The frequency that anomaly reports are sent over email.
            /// Required: Yes
            /// Type: String
            /// Allowed values: DAILY | IMMEDIATE | WEEKLY
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Frequency { get; set; }

        }

        public string Type { get; } = "AWS::CE::AnomalySubscription";

        public AnomalySubscriptionProperties Properties { get; } = new AnomalySubscriptionProperties();

    }

    public static class AnomalySubscriptionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SubscriptionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("SubscriptionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AccountId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AccountId");
    }
}
