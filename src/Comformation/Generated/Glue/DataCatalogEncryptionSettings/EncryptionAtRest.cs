using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.DataCatalogEncryptionSettings
{
    /// <summary>
    /// AWS::Glue::DataCatalogEncryptionSettings EncryptionAtRest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-encryptionatrest.html
    /// </summary>
    public class EncryptionAtRest
    {

        /// <summary>
        /// CatalogEncryptionMode
        /// The encryption-at-rest mode for encrypting Data Catalog data.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CatalogEncryptionMode")]
        public Union<string, IntrinsicFunction> CatalogEncryptionMode { get; set; }

        /// <summary>
        /// SseAwsKmsKeyId
        /// The ID of the AWS KMS key to use for encryption at rest.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SseAwsKmsKeyId")]
        public Union<string, IntrinsicFunction> SseAwsKmsKeyId { get; set; }

    }
}
