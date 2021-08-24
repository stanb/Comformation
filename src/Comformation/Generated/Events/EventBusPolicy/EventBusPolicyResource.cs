using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.EventBusPolicy
{
    /// <summary>
    /// AWS::Events::EventBusPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-eventbuspolicy.html
    /// </summary>
    public class EventBusPolicyResource : ResourceBase
    {
        public class EventBusPolicyProperties
        {
            /// <summary>
            /// EventBusName
            /// The name of the event bus associated with the rule. If you omit this, the default event bus is used.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: [\. \-_A-Za-z0-9]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EventBusName { get; set; }

            /// <summary>
            /// Condition
            /// This parameter enables you to limit the permission to accounts that fulfill a certain condition,
            /// such as being a member of a certain AWS organization. For more information about AWS Organizations,
            /// see What Is AWS Organizations in the AWS Organizations User Guide.
            /// If you specify Condition with an AWS organization ID, and specify &quot;*&quot; as the value for Principal,
            /// you grant permission to all the accounts in the named organization.
            /// The Condition is a JSON string which must contain Type, Key, and Value fields.
            /// Required: No
            /// Type: Condition
            /// Update requires: No interruption
            /// </summary>
            public Condition Condition { get; set; }

            /// <summary>
            /// Action
            /// The action that you are enabling the other account to perform.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: events:[a-zA-Z]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Action { get; set; }

            /// <summary>
            /// StatementId
            /// An identifier string for the external account that you are granting permissions to. If you later
            /// want to revoke the permission for this external account, specify this StatementId when you run
            /// RemovePermission.
            /// Note Each StatementId must be unique.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: [a-zA-Z0-9-_]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StatementId { get; set; }

            /// <summary>
            /// Statement
            /// A JSON string that describes the permission policy statement. You can include a Policy parameter in
            /// the request instead of using the StatementId, Action, Principal, or Condition parameters.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Statement { get; set; }

            /// <summary>
            /// Principal
            /// The 12-digit AWS account ID that you are permitting to put events to your default event bus. Specify
            /// &quot;*&quot; to permit any account to put events to your default event bus.
            /// If you specify &quot;*&quot; without specifying Condition, avoid creating rules that may match undesirable
            /// events. To create more secure rules, make sure that the event pattern for each rule contains an
            /// account field with a specific account ID from which to receive events. Rules with an account field
            /// do not match any events sent from other accounts.
            /// Required: No
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
