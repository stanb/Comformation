using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.GlobalTable
{
    /// <summary>
    /// AWS::DynamoDB::GlobalTable SSESpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-ssespecification.html
    /// </summary>
    public class SSESpecification
    {

        /// <summary>
        /// SSEEnabled
        /// Indicates whether server-side encryption is performed using an AWS managed key or an AWS owned key.
        /// If disabled (false) or not specified, server-side encryption uses an AWS owned key. If enabled
        /// (true), the server-side encryption type is set to KMS and an AWS managed key is used (AWS KMS
        /// charges apply). If you choose to use KMS encryption, you can also use customer managed KMS keys by
        /// specifying them in the ReplicaSpecification. SSESpecification object. You cannot mix AWS managed and
        /// customer managed KMS keys.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SSEEnabled")]
        public Union<bool, IntrinsicFunction> SSEEnabled { get; set; }

        /// <summary>
        /// SSEType
        /// Server-side encryption type. The only supported value is:
        /// KMS - Server-side encryption that uses AWS Key Management Service. The key is stored in your account
        /// and is managed by AWS KMS (AWS KMS charges apply).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SSEType")]
        public Union<string, IntrinsicFunction> SSEType { get; set; }

    }
}
