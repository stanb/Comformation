using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Cluster
{
    /// <summary>
    /// AWS::EKS::Cluster Provider
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-provider.html
    /// </summary>
    public class Provider
    {

        /// <summary>
        /// KeyArn
        /// Amazon Resource Name (ARN) or alias of the KMS key. The KMS key must be symmetric, created in the
        /// same region as the cluster, and if the KMS key was created in a different account, the user must
        /// have access to the KMS key. For more information, see Allowing Users in Other Accounts to Use a KMS
        /// key in the AWS Key Management Service Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyArn")]
        public Union<string, IntrinsicFunction> KeyArn { get; set; }

    }
}
