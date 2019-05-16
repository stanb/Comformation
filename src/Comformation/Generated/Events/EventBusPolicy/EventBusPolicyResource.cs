using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.EventBusPolicy
{
    /// <summary>
    /// AWS::Events::EventBusPolicy
    /// The AWS::Events::EventBusPolicy resource creates an event bus policy for Amazon CloudWatch Events. An event
    /// bus policy enables your account to receive events from other AWS accounts. These events can trigger CloudWatch
    /// Events rules created in your account. For more information, see Sending and Receiving Events Between AWS
    /// Accounts in the Amazon CloudWatch Events User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-eventbuspolicy.html
    /// </summary>
    public class EventBusPolicyResource : ResourceBase
    {
        public class EventBusPolicyProperties
        {
            /// <summary>
            /// Condition
            /// Condition is a JSON string that you can use to limit the event bus permissions that you&#39;re granting
            /// only to accounts that fulfill the condition. Currently, the only supported condition is membership
            /// in a certain AWS organization. For more information about AWS Organizations, see What Is AWS
            /// Organizations? in the AWS Organizations User Guide.
            /// Condition is a property of the AWS::Events::EventBusPolicy resource type.
            /// If you specify Condition with an AWS organization ID and specify &quot;*&quot; as the value for Principal, you
            /// grant permission to all the accounts in the named organization.
            /// Required: No
            /// Type: Condition
            /// Update requires: No interruption
            /// </summary>
			public Condition Condition { get; set; }

            /// <summary>
            /// Action
            /// The action that you are enabling the other account to perform. Currently, this must be
            /// events:PutEvents.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: events:[a-zA-Z]+
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Action { get; set; }

            /// <summary>
            /// StatementId
            /// An identifier string for the external account that you&#39;re granting permissions to. If you later want
            /// to revoke the permission for this external account, you must specify this StatementId.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: [a-zA-Z0-9-_]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> StatementId { get; set; }

            /// <summary>
            /// Principal
            /// The 12-digit AWS account ID that you are permitting to put events to your default event bus. Specify
            /// &quot;*&quot; to permit any account to put events to your default event bus.
            /// If you specify &quot;*&quot; without specifying Condition, avoid creating rules that may match undesirable
            /// events. To create more secure rules, make sure that the event pattern for each rule contains an
            /// account field with a specific account ID from which to receive events. Rules with an account field
            /// do not match any events sent from other accounts.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 12
            /// Pattern: (\d{12}|\*)
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Principal { get; set; }

        }

        public string Type { get; } = "AWS::Events::EventBusPolicy";

        public EventBusPolicyProperties Properties { get; } = new EventBusPolicyProperties();

    }
}
