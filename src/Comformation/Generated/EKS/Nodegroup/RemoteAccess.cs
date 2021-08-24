using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Nodegroup
{
    /// <summary>
    /// AWS::EKS::Nodegroup RemoteAccess
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-remoteaccess.html
    /// </summary>
    public class RemoteAccess
    {

        /// <summary>
        /// SourceSecurityGroups
        /// The security groups that are allowed SSH access (port 22) to the nodes. If you specify an Amazon EC2
        /// SSH key but do not specify a source security group when you create a managed node group, then port
        /// 22 on the nodes is opened to the internet (0. 0. 0. 0/0). For more information, see Security Groups
        /// for Your VPC in the Amazon Virtual Private Cloud User Guide.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SourceSecurityGroups")]
        public List<Union<string, IntrinsicFunction>> SourceSecurityGroups { get; set; }

        /// <summary>
        /// Ec2SshKey
        /// The Amazon EC2 SSH key that provides access for SSH communication with the nodes in the managed node
        /// group. For more information, see Amazon EC2 key pairs and Linux instances in the Amazon Elastic
        /// Compute Cloud User Guide for Linux Instances.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Ec2SshKey")]
        public Union<string, IntrinsicFunction> Ec2SshKey { get; set; }

    }
}
