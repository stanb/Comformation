using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeStarNotifications.NotificationRule
{
    /// <summary>
    /// AWS::CodeStarNotifications::NotificationRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestarnotifications-notificationrule.html
    /// </summary>
    public class NotificationRuleResource : ResourceBase
    {
        public class NotificationRuleProperties
        {
            /// <summary>
            /// EventTypeIds
            /// A list of event types associated with this notification rule. For a complete list of event types and
            /// IDs, see Notification concepts in the Developer Tools Console User Guide.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> EventTypeIds { get; set; }

            /// <summary>
            /// Status
            /// The status of the notification rule. The default value is ENABLED. If the status is set to DISABLED,
            /// notifications aren&#39;t sent for the notification rule.
            /// Required: No
            /// Type: String
            /// Allowed values: DISABLED | ENABLED
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Status { get; set; }

            /// <summary>
            /// DetailType
            /// The level of detail to include in the notifications for this resource. BASIC will include only the
            /// contents of the event as it would appear in Amazon CloudWatch. FULL will include any supplemental
            /// information provided by AWS CodeStar Notifications and/or the service for the resource for which the
            /// notification is created.
            /// Required: Yes
            /// Type: String
            /// Allowed values: BASIC | FULL
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DetailType { get; set; }

            /// <summary>
            /// Resource
            /// The Amazon Resource Name (ARN) of the resource to associate with the notification rule. Supported
            /// resources include pipelines in AWS CodePipeline, repositories in AWS CodeCommit, and build projects
            /// in AWS CodeBuild.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^arn:aws[^:\s]*:[^:\s]*:[^:\s]*:[0-9]{12}:[^\s]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Resource { get; set; }

            /// <summary>
            /// Targets
            /// A list of Amazon Resource Names (ARNs) of AWS Chatbot topics and AWS Chatbot clients to associate
            /// with the notification rule.
            /// Required: Yes
            /// Type: List of Target
            /// Maximum: 10
            /// Update requires: No interruption
            /// </summary>
            public List<Target> Targets { get; set; }

            /// <summary>
            /// Tags
            /// A list of tags to apply to this notification rule. Key names cannot start with &quot;aws&quot;.
            /// Required: No
            /// Type: Json
            /// Update requires: Replacement
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name for the notification rule. Notification rule names must be unique in your AWS account.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: [A-Za-z0-9\-_ ]+$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::CodeStarNotifications::NotificationRule";

        public NotificationRuleProperties Properties { get; } = new NotificationRuleProperties();

    }
}
