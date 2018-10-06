using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.ClusterSecurityGroupIngress
{
    /// <summary>
    /// AWS::Redshift::ClusterSecurityGroupIngress
    /// Specifies inbound (ingress) rules for an Amazon Redshift security group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroupingress.html
    /// </summary>
    public class ClusterSecurityGroupIngressResource : ResourceBase
    {
        public class ClusterSecurityGroupIngressProperties
        {
            /// <summary>
            /// CIDRIP
            /// The IP address range that has inbound access to the Amazon Redshift security group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CIDRIP { get; set; }

            /// <summary>
            /// ClusterSecurityGroupName
            /// The name of the Amazon Redshift security group that will be associated with the ingress rule.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterSecurityGroupName { get; set; }

            /// <summary>
            /// EC2SecurityGroupName
            /// The Amazon EC2 security group that will be added the Amazon Redshift security group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EC2SecurityGroupName { get; set; }

            /// <summary>
            /// EC2SecurityGroupOwnerId
            /// The 12-digit AWS account number of the owner of the Amazon EC2 security group that is specified by
            /// the EC2SecurityGroupName parameter.
            /// Required: Conditional. If you specify the EC2SecurityGroupName property, you must specify this
            /// property.
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EC2SecurityGroupOwnerId { get; set; }

        }
    
        public string Type { get; } = "AWS::Redshift::ClusterSecurityGroupIngress";
        
        public ClusterSecurityGroupIngressProperties Properties { get; } = new ClusterSecurityGroupIngressProperties();

    }
}
