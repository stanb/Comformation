using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Athena.WorkGroup
{
    /// <summary>
    /// AWS::Athena::WorkGroup EncryptionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-encryptionconfiguration.html
    /// </summary>
    public class EncryptionConfiguration
    {

        /// <summary>
        /// EncryptionOption
        /// Indicates whether Amazon S3 server-side encryption with Amazon S3-managed keys (SSE-S3), server-side
        /// encryption with KMS-managed keys (SSE-KMS), or client-side encryption with KMS-managed keys
        /// (CSE-KMS) is used.
        /// If a query runs in a workgroup and the workgroup overrides client-side settings, then the
        /// workgroup&#39;s setting for encryption is used. It specifies whether query results must be encrypted,
        /// for all queries that run in this workgroup.
        /// Required: Yes
        /// Type: String
        /// Allowed values: CSE_KMS | SSE_KMS | SSE_S3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionOption")]
        public Union<string, IntrinsicFunction> EncryptionOption { get; set; }

        /// <summary>
        /// KmsKey
        /// For SSE-KMS and CSE-KMS, this is the KMS key ARN or ID.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KmsKey")]
        public Union<string, IntrinsicFunction> KmsKey { get; set; }

    }
}
