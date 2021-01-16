using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudWatch.CompositeAlarm
{
    /// <summary>
    /// AWS::CloudWatch::CompositeAlarm
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html
    /// </summary>
    public class CompositeAlarmResource : ResourceBase
    {
        public class CompositeAlarmProperties
        {
            /// <summary>
            /// AlarmName
            /// The name for the composite alarm. This name must be unique within your AWS account.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AlarmName { get; set; }

            /// <summary>
            /// AlarmRule
            /// An expression that specifies which other alarms are to be evaluated to determine this composite
            /// alarm&#39;s state. For each alarm that you reference, you designate a function that specifies whether
            /// that alarm needs to be in ALARM state, OK state, or INSUFFICIENT_DATA state. You can use operators
            /// (AND, OR and NOT) to combine multiple functions in a single expression. You can use parenthesis to
            /// logically group the functions in your expression.
            /// You can use either alarm names or ARNs to reference the other alarms that are to be evaluated.
            /// Functions can include the following:
            /// ALARM(&quot;alarm-name or alarm-ARN&quot;) is TRUE if the named alarm is in ALARM state. OK(&quot;alarm-name or
            /// alarm-ARN&quot;) is TRUE if the named alarm is in OK state. INSUFFICIENT_DATA(&quot;alarm-name or alarm-ARN&quot;)
            /// is TRUE if the named alarm is in INSUFFICIENT_DATA state. TRUE always evaluates to TRUE. FALSE
            /// always evaluates to FALSE.
            /// TRUE and FALSE are useful for testing a complex AlarmRule structure, and for testing your alarm
            /// actions.
            /// For more information about AlarmRule syntax, see PutCompositeAlarm in the Amazon CloudWatch API
            /// Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AlarmRule { get; set; }

            /// <summary>
            /// AlarmDescription
            /// The description for the composite alarm.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AlarmDescription { get; set; }

            /// <summary>
            /// ActionsEnabled
            /// Indicates whether actions should be executed during any changes to the alarm state of the composite
            /// alarm. The default is TRUE.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> ActionsEnabled { get; set; }

            /// <summary>
            /// OKActions
            /// The actions to execute when this alarm transitions to the OK state from any other state. Each action
            /// is specified as an Amazon Resource Name (ARN). For more information about creating alarms and the
            /// actions that you can specify, see PutCompositeAlarm in the Amazon CloudWatch API Reference.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> OKActions { get; set; }

            /// <summary>
            /// AlarmActions
            /// The actions to execute when this alarm transitions to the ALARM state from any other state. Each
            /// action is specified as an Amazon Resource Name (ARN). For more information about creating alarms and
            /// the actions that you can specify, see PutCompositeAlarm in the Amazon CloudWatch API Reference.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AlarmActions { get; set; }

            /// <summary>
            /// InsufficientDataActions
            /// The actions to execute when this alarm transitions to the INSUFFICIENT_DATA state from any other
            /// state. Each action is specified as an Amazon Resource Name (ARN). For more information about
            /// creating alarms and the actions that you can specify, see PutCompositeAlarm in the Amazon CloudWatch
            /// API Reference.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> InsufficientDataActions { get; set; }

        }

        public string Type { get; } = "AWS::CloudWatch::CompositeAlarm";

        public CompositeAlarmProperties Properties { get; } = new CompositeAlarmProperties();

    }

    public static class CompositeAlarmAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
