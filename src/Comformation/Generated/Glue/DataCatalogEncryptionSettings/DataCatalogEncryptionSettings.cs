using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.DataCatalogEncryptionSettings
{
    /// <summary>
    /// AWS::Glue::DataCatalogEncryptionSettings DataCatalogEncryptionSettings
    /// Contains configuration information for maintaining Data Catalog security.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-datacatalogencryptionsettings.html
    /// </summary>
    public class DataCatalogEncryptionSettings
    {

        /// <summary>
        /// ConnectionPasswordEncryption
        /// When connection password protection is enabled, the Data Catalog uses a customer-provided key to
        /// encrypt the password as part of CreateConnection or UpdateConnection and store it in the
        /// ENCRYPTED_PASSWORD field in the connection properties. You can enable catalog encryption or only
        /// password encryption.
        /// Required: No
        /// Type: ConnectionPasswordEncryption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionPasswordEncryption")]
        public ConnectionPasswordEncryption ConnectionPasswordEncryption { get; set; }

        /// <summary>
        /// EncryptionAtRest
        /// Specifies the encryption-at-rest configuration for the Data Catalog.
        /// Required: No
        /// Type: EncryptionAtRest
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionAtRest")]
        public EncryptionAtRest EncryptionAtRest { get; set; }

    }
}
