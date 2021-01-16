using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolRiskConfigurationAttachment
{
    /// <summary>
    /// AWS::Cognito::UserPoolRiskConfigurationAttachment AccountTakeoverActionsType
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-accounttakeoveractionstype.html
    /// </summary>
    public class AccountTakeoverActionsType
    {

        /// <summary>
        /// HighAction
        /// Action to take for a high risk.
        /// Required: No
        /// Type: AccountTakeoverActionType
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HighAction")]
        public AccountTakeoverActionType HighAction { get; set; }

        /// <summary>
        /// LowAction
        /// Action to take for a low risk.
        /// Required: No
        /// Type: AccountTakeoverActionType
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LowAction")]
        public AccountTakeoverActionType LowAction { get; set; }

        /// <summary>
        /// MediumAction
        /// Action to take for a medium risk.
        /// Required: No
        /// Type: AccountTakeoverActionType
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MediumAction")]
        public AccountTakeoverActionType MediumAction { get; set; }

    }
}
