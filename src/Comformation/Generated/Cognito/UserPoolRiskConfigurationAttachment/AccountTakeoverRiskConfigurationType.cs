using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolRiskConfigurationAttachment
{
    /// <summary>
    /// AWS::Cognito::UserPoolRiskConfigurationAttachment AccountTakeoverRiskConfigurationType
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-accounttakeoverriskconfigurationtype.html
    /// </summary>
    public class AccountTakeoverRiskConfigurationType
    {

        /// <summary>
        /// Actions
        /// Account takeover risk configuration actions
        /// Required: Yes
        /// Type: AccountTakeoverActionsType
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Actions")]
        public AccountTakeoverActionsType Actions { get; set; }

        /// <summary>
        /// NotifyConfiguration
        /// The notify configuration used to construct email notifications.
        /// Required: No
        /// Type: NotifyConfigurationType
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotifyConfiguration")]
        public NotifyConfigurationType NotifyConfiguration { get; set; }

    }
}
