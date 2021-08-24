using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cassandra.Table
{
    /// <summary>
    /// AWS::Cassandra::Table EncryptionSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-table-encryptionspecification.html
    /// </summary>
    public class EncryptionSpecification
    {

        /// <summary>
        /// EncryptionType
        /// The encryption at rest options for the table.
        /// AWS owned key (default) - AWS_OWNED_KMS_KEY Customer managed key - CUSTOMER_MANAGED_KMS_KEY
        /// Important If you choose CUSTOMER_MANAGED_KMS_KEY, a kms_key_identifier in the format of a key ARN is
        /// required.
        /// Valid values: CUSTOMER_MANAGED_KMS_KEY | AWS_OWNED_KMS_KEY.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionType")]
        public Union<string, IntrinsicFunction> EncryptionType { get; set; }

        /// <summary>
        /// KmsKeyIdentifier
        /// Requires a kms_key_identifier in the format of a key ARN.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KmsKeyIdentifier")]
        public Union<string, IntrinsicFunction> KmsKeyIdentifier { get; set; }

    }
}
