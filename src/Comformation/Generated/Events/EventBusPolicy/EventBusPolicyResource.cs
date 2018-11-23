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
            /// A JSON string which you can use to limit the event bus permissions you are granting to only accounts
            /// that fulfill the condition. Currently, the only supported condition is membership in a certain AWS
            /// organization. The string must contain Type, Key, and Value fields.
            /// Currently, the Type must be StringEquals, the Key must be aws:PrincipalOrgID, and the Value field
            /// specifies the ID of the AWS organization.
            /// If you specify Condition with an AWS organization ID, you must specify &quot;*&quot; as the value for
            /// Principal. This grants permission to all the accounts in the named organization.
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
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Action { get; set; }

            /// <summary>
            /// StatementId
            /// An identifier string for the external account to which you are granting permissions. To later revoke
            /// the permission for this external account, you need to know this string.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> StatementId { get; set; }

            /// <summary>
            /// Principal
            /// The 12-digit AWS account ID that you are permitting to put events to your default event bus. Specify
            /// * to permit any account to put events to your default event bus, or if you are specifying an
            /// organization ID in the Condition object.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Principal { get; set; }

        }

        public string Type { get; } = "AWS::Events::EventBusPolicy";

        public EventBusPolicyProperties Properties { get; } = new EventBusPolicyProperties();

    }
}
