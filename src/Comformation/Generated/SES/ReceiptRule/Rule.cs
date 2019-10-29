using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// AWS::SES::ReceiptRule Rule
    /// Receipt rules enable you to specify which actions Amazon SES should take when it receives mail on behalf of
    /// one or more email addresses or domains that you own.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-rule.html
    /// </summary>
    public class Rule
    {

        /// <summary>
        /// ScanEnabled
        /// If true, then messages that this receipt rule applies to are scanned for spam and viruses. The
        /// default value is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScanEnabled")]
        public Union<bool, IntrinsicFunction> ScanEnabled { get; set; }

        /// <summary>
        /// Recipients
        /// Contains the recipient domains and email addresses that the receipt rule applies to. If this field
        /// isn&#39;t specified, this rule matches all recipients on all verified domains.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Recipients")]
        public List<Union<string, IntrinsicFunction>> Recipients { get; set; }

        /// <summary>
        /// Actions
        /// An ordered list of actions to perform on messages that match at least one of the recipient email
        /// addresses or domains specified in the receipt rule.
        /// Required: No
        /// Type: List of Action
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Actions")]
        public List<Action> Actions { get; set; }

        /// <summary>
        /// Enabled
        /// If true, the receipt rule is active. The default value is false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// Name
        /// The name of the receipt rule. The name must:
        /// This value can only contain ASCII letters (a–z, A–Z), numbers (0–9), underscores (_), or dashes (-).
        /// Start and end with a letter or number. Contain fewer than 64 characters.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// TlsPolicy
        /// Specifies whether Amazon SES should require that incoming email is delivered over a connection
        /// encrypted with Transport Layer Security (TLS). If this parameter is set to Require, Amazon SES
        /// bounces emails that are not received over TLS. The default is Optional.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TlsPolicy")]
        public Union<string, IntrinsicFunction> TlsPolicy { get; set; }

    }
}
