using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html
    /// </summary>
    public class RuleResource : ResourceBase
    {
        public class RuleProperties
        {
            /// <summary>
            /// Description
            /// The description of the rule.
            /// Required: No
            /// Type: String
            /// Maximum: 512
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EventBusName
            /// The name or ARN of the event bus associated with the rule. If you omit this, the default event bus
            /// is used.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: [/\. \-_A-Za-z0-9]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EventBusName { get; set; }

            /// <summary>
            /// EventPattern
            /// The event pattern of the rule. For more information, see Events and Event Patterns in the Amazon
            /// EventBridge User Guide.
            /// Required: Conditional
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> EventPattern { get; set; }

            /// <summary>
            /// Name
            /// The name of the rule.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: [\. \-_A-Za-z0-9]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the role that is used for target invocation.
            /// If you&#39;re setting an event bus in another account as the target and that account granted permission
            /// to your account through an organization instead of directly by the account ID, you must specify a
            /// RoleArn with proper permissions in the Target structure, instead of here in this parameter.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1600
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// ScheduleExpression
            /// The scheduling expression. For example, &quot;cron(0 20 * * ? *)&quot;, &quot;rate(5 minutes)&quot;. For more
            /// information, see Creating an Amazon EventBridge rule that runs on a schedule.
            /// Required: Conditional
            /// Type: String
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ScheduleExpression { get; set; }

            /// <summary>
            /// State
            /// The state of the rule.
            /// Required: No
            /// Type: String
            /// Allowed values: DISABLED | ENABLED
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> State { get; set; }

            /// <summary>
            /// Targets
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: List of Target
            /// Update requires: No interruption
            /// </summary>
            public List<Target> Targets { get; set; }

        }

        public string Type { get; } = "AWS::Events::Rule";

        public RuleProperties Properties { get; } = new RuleProperties();

    }

    public static class RuleAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
