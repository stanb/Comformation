using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// AWS::DynamoDB::Table SSESpecification
    /// Represents the settings used to enable server-side encryption.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-ssespecification.html
    /// </summary>
    public class SSESpecification
    {

        /// <summary>
        /// KMSMasterKeyId
        /// The KMS customer master key (CMK) that should be used for the AWS KMS encryption. To specify a CMK,
        /// use its key ID, Amazon Resource Name (ARN), alias name, or alias ARN. Note that you should only
        /// provide this parameter if the key is different from the default DynamoDB customer master key
        /// alias/aws/dynamodb.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KMSMasterKeyId")]
        public Union<string, IntrinsicFunction> KMSMasterKeyId { get; set; }

        /// <summary>
        /// SSEEnabled
        /// Indicates whether server-side encryption is done using an AWS managed CMK or an AWS owned CMK. If
        /// enabled (true), server-side encryption type is set to KMS and an AWS managed CMK is used (AWS KMS
        /// charges apply). If disabled (false) or not specified, server-side encryption is set to AWS owned
        /// CMK.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SSEEnabled")]
        public Union<bool, IntrinsicFunction> SSEEnabled { get; set; }

        /// <summary>
        /// SSEType
        /// Server-side encryption type. The only supported value is:
        /// 		 KMS - Server-side encryption that uses AWS Key Management Service. The key is stored in your
        /// account and is managed by AWS KMS (AWS KMS charges apply).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SSEType")]
        public Union<string, IntrinsicFunction> SSEType { get; set; }

    }
}
