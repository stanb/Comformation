using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CertificateManager.Account
{
    /// <summary>
    /// AWS::CertificateManager::Account
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-account.html
    /// </summary>
    public class AccountResource : ResourceBase
    {
        public class AccountProperties
        {
            /// <summary>
            /// ExpiryEventsConfiguration
            /// Object containing expiration events options associated with an AWS account. For more information,
            /// see ExpiryEventsConfiguration in the API reference.
            /// Required: Yes
            /// Type: ExpiryEventsConfiguration
            /// Update requires: No interruption
            /// </summary>
            public ExpiryEventsConfiguration ExpiryEventsConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::CertificateManager::Account";

        public AccountProperties Properties { get; } = new AccountProperties();

    }

    public static class AccountAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AccountId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AccountId");
    }
}
