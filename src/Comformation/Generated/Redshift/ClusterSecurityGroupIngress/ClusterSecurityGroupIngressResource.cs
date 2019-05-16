using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.ClusterSecurityGroupIngress
{
    /// <summary>
    /// AWS::Redshift::ClusterSecurityGroupIngress
    /// Adds an inbound (ingress) rule to an Amazon Redshift security group. Depending on whether the application
    /// accessing your cluster is running on the Internet or an Amazon EC2 instance, you can authorize inbound access
    /// to either a Classless Interdomain Routing (CIDR)/Internet Protocol (IP) range or to an Amazon EC2 security
    /// group. You can add as many as 20 ingress rules to an Amazon Redshift security group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroupingress.html
    /// </summary>
    public class ClusterSecurityGroupIngressResource : ResourceBase
    {
        public class ClusterSecurityGroupIngressProperties
        {
            /// <summary>
            /// CIDRIP
            /// The IP range to be added the Amazon Redshift security group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CIDRIP { get; set; }

            /// <summary>
            /// ClusterSecurityGroupName
            /// The name of the security group to which the ingress rule is added.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterSecurityGroupName { get; set; }

            /// <summary>
            /// EC2SecurityGroupName
            /// The EC2 security group to be added the Amazon Redshift security group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EC2SecurityGroupName { get; set; }

            /// <summary>
            /// EC2SecurityGroupOwnerId
            /// The AWS account number of the owner of the security group specified by the EC2SecurityGroupName
            /// parameter. The AWS Access Key ID is not an acceptable value.
            /// Example: 111122223333
            /// Conditional. If you specify the EC2SecurityGroupName property, you must specify this property.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EC2SecurityGroupOwnerId { get; set; }

        }

        public string Type { get; } = "AWS::Redshift::ClusterSecurityGroupIngress";

        public ClusterSecurityGroupIngressProperties Properties { get; } = new ClusterSecurityGroupIngressProperties();

    }
}
