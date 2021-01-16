using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolRiskConfigurationAttachment
{
    /// <summary>
    /// AWS::Cognito::UserPoolRiskConfigurationAttachment CompromisedCredentialsActionsType
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-compromisedcredentialsactionstype.html
    /// </summary>
    public class CompromisedCredentialsActionsType
    {

        /// <summary>
        /// EventAction
        /// The event action.
        /// Required: Yes
        /// Type: String
        /// Allowed values: BLOCK | NO_ACTION
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventAction")]
        public Union<string, IntrinsicFunction> EventAction { get; set; }

    }
}
