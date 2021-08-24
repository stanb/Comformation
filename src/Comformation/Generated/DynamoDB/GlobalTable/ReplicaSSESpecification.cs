using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.GlobalTable
{
    /// <summary>
    /// AWS::DynamoDB::GlobalTable ReplicaSSESpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-replicassespecification.html
    /// </summary>
    public class ReplicaSSESpecification
    {

        /// <summary>
        /// KMSMasterKeyId
        /// The AWS KMS customer master key (CMK) that should be used for the AWS KMS encryption. To specify a
        /// CMK, use its key ID, Amazon Resource Name (ARN), alias name, or alias ARN. Note that you should only
        /// provide this parameter if the key is different from the default DynamoDB customer master key
        /// alias/aws/dynamodb.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KMSMasterKeyId")]
        public Union<string, IntrinsicFunction> KMSMasterKeyId { get; set; }

    }
}
