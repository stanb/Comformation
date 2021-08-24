using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CertificateManager.Account
{
    /// <summary>
    /// AWS::CertificateManager::Account ExpiryEventsConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-account-expiryeventsconfiguration.html
    /// </summary>
    public class ExpiryEventsConfiguration
    {

        /// <summary>
        /// DaysBeforeExpiry
        /// This option specifies the number of days prior to certificate expiration when ACM starts generating
        /// EventBridge events. ACM sends one event per day per certificate until the certificate expires. By
        /// default, accounts receive events starting 45 days before certificate expiration.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DaysBeforeExpiry")]
        public Union<int, IntrinsicFunction> DaysBeforeExpiry { get; set; }

    }
}
