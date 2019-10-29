using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolRiskConfigurationAttachment
{
    /// <summary>
    /// AWS::Cognito::UserPoolRiskConfigurationAttachment AccountTakeoverActionType
    /// Account takeover action type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-accounttakeoveractiontype.html
    /// </summary>
    public class AccountTakeoverActionType
    {

        /// <summary>
        /// Notify
        /// Flag specifying whether to send a notification.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Notify")]
        public Union<bool, IntrinsicFunction> Notify { get; set; }

        /// <summary>
        /// EventAction
        /// The event action.
        /// BLOCK Choosing this action will block the request. MFA_IF_CONFIGURED Throw MFA challenge if user has
        /// configured it, else allow the request. MFA_REQUIRED Throw MFA challenge if user has configured it,
        /// else block the request. NO_ACTION Allow the user sign-in.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: BLOCK | MFA_IF_CONFIGURED | MFA_REQUIRED | NO_ACTION
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventAction")]
        public Union<string, IntrinsicFunction> EventAction { get; set; }

    }
}
