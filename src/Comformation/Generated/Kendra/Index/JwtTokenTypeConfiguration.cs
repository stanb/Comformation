using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.Index
{
    /// <summary>
    /// AWS::Kendra::Index JwtTokenTypeConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-jwttokentypeconfiguration.html
    /// </summary>
    public class JwtTokenTypeConfiguration
    {

        /// <summary>
        /// KeyLocation
        /// The location of the key.
        /// Required: Yes
        /// Type: String
        /// Allowed values: SECRET_MANAGER | URL
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyLocation")]
        public Union<string, IntrinsicFunction> KeyLocation { get; set; }

        /// <summary>
        /// URL
        /// The signing key URL.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: ^(https?|ftp|file):\/\/([^\s]*)
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("URL")]
        public Union<string, IntrinsicFunction> URL { get; set; }

        /// <summary>
        /// SecretManagerArn
        /// The Amazon Resource Name (arn) of the secret.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1284
        /// Pattern: arn:[a-z0-9-\. ]{1,63}:[a-z0-9-\. ]{0,63}:[a-z0-9-\. ]{0,63}:[a-z0-9-\. ]{0,63}:[^/].
        /// {0,1023}
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecretManagerArn")]
        public Union<string, IntrinsicFunction> SecretManagerArn { get; set; }

        /// <summary>
        /// UserNameAttributeField
        /// The user name attribute field.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^\P{C}*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserNameAttributeField")]
        public Union<string, IntrinsicFunction> UserNameAttributeField { get; set; }

        /// <summary>
        /// GroupAttributeField
        /// The group attribute field.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^\P{C}*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GroupAttributeField")]
        public Union<string, IntrinsicFunction> GroupAttributeField { get; set; }

        /// <summary>
        /// Issuer
        /// The issuer of the token.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 65
        /// Pattern: ^\P{C}*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Issuer")]
        public Union<string, IntrinsicFunction> Issuer { get; set; }

        /// <summary>
        /// ClaimRegex
        /// The regular expression that identifies the claim.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^\P{C}*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClaimRegex")]
        public Union<string, IntrinsicFunction> ClaimRegex { get; set; }

    }
}
