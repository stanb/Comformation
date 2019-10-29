using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.DataCatalogEncryptionSettings
{
    /// <summary>
    /// AWS::Glue::DataCatalogEncryptionSettings ConnectionPasswordEncryption
    /// The data structure used by the Data Catalog to encrypt the password as part of CreateConnection or
    /// UpdateConnection and store it in the ENCRYPTED_PASSWORD field in the connection properties. You can enable
    /// catalog encryption or only password encryption.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-connectionpasswordencryption.html
    /// </summary>
    public class ConnectionPasswordEncryption
    {

        /// <summary>
        /// ReturnConnectionPasswordEncrypted
        /// When the ReturnConnectionPasswordEncrypted flag is set to &quot;true&quot;, passwords remain encrypted in the
        /// responses of GetConnection and GetConnections. This encryption takes effect independently from
        /// catalog encryption.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReturnConnectionPasswordEncrypted")]
        public Union<bool, IntrinsicFunction> ReturnConnectionPasswordEncrypted { get; set; }

        /// <summary>
        /// KmsKeyId
        /// An AWS KMS key that is used to encrypt the connection password.
        /// If connection password protection is enabled, the caller of CreateConnection and UpdateConnection
        /// needs at least kms:Encrypt permission on the specified AWS KMS key, to encrypt passwords before
        /// storing them in the Data Catalog. You can set the decrypt permission to enable or restrict access on
        /// the password key according to your security requirements.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

    }
}
