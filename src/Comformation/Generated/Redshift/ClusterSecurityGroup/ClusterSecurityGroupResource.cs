using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.ClusterSecurityGroup
{
    /// <summary>
    /// AWS::Redshift::ClusterSecurityGroup
    /// Creates an Amazon Redshift security group. You use security groups to control access to Amazon Redshift
    /// clusters that are not in a VPC.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroup.html
    /// </summary>
    public class ClusterSecurityGroupResource : ResourceBase
    {
        public class ClusterSecurityGroupProperties
        {
            /// <summary>
            /// Description
            /// A description of the security group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroup.html#cfn-redshift-clustersecuritygroup-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// Specifies an arbitrary set of tags (key–value pairs) to associate with this security group. Use tags
            /// to manage your resources.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroup.html#cfn-redshift-clustersecuritygroup-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::Redshift::ClusterSecurityGroup";
        
        public ClusterSecurityGroupProperties Properties { get; } = new ClusterSecurityGroupProperties();
    }
}
