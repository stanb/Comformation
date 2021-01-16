using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolRiskConfigurationAttachment
{
    /// <summary>
    /// AWS::Cognito::UserPoolRiskConfigurationAttachment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolriskconfigurationattachment.html
    /// </summary>
    public class UserPoolRiskConfigurationAttachmentResource : ResourceBase
    {
        public class UserPoolRiskConfigurationAttachmentProperties
        {
            /// <summary>
            /// CompromisedCredentialsRiskConfiguration
            /// The compromised credentials risk configuration object including the EventFilter and the EventAction
            /// Required: No
            /// Type: CompromisedCredentialsRiskConfigurationType
            /// Update requires: No interruption
            /// </summary>
            public CompromisedCredentialsRiskConfigurationType CompromisedCredentialsRiskConfiguration { get; set; }

            /// <summary>
            /// UserPoolId
            /// The user pool ID.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 55
            /// Pattern: [\w-]+_[0-9a-zA-Z]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> UserPoolId { get; set; }

            /// <summary>
            /// ClientId
            /// The app client ID. You can specify the risk configuration for a single client (with a specific
            /// ClientId) or for all clients (by setting the ClientId to ALL).
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\w+]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClientId { get; set; }

            /// <summary>
            /// AccountTakeoverRiskConfiguration
            /// The account takeover risk configuration object including the NotifyConfiguration object and Actions
            /// to take in the case of an account takeover.
            /// Required: No
            /// Type: AccountTakeoverRiskConfigurationType
            /// Update requires: No interruption
            /// </summary>
            public AccountTakeoverRiskConfigurationType AccountTakeoverRiskConfiguration { get; set; }

            /// <summary>
            /// RiskExceptionConfiguration
            /// The configuration to override the risk decision.
            /// Required: No
            /// Type: RiskExceptionConfigurationType
            /// Update requires: No interruption
            /// </summary>
            public RiskExceptionConfigurationType RiskExceptionConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::Cognito::UserPoolRiskConfigurationAttachment";

        public UserPoolRiskConfigurationAttachmentProperties Properties { get; } = new UserPoolRiskConfigurationAttachmentProperties();

    }
}
