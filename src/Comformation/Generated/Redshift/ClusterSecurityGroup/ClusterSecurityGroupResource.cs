using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.ClusterSecurityGroup
{
    /// <summary>
    /// AWS::Redshift::ClusterSecurityGroup
    /// Specifies a new Amazon Redshift security group. You use security groups to control access to non-VPC clusters.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroup.html
    /// </summary>
    public class ClusterSecurityGroupResource : ResourceBase
    {
        public class ClusterSecurityGroupProperties
        {
            /// <summary>
            /// Description
            /// A description for the security group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Tags
            /// Specifies an arbitrary set of tags (key–value pairs) to associate with this security group. Use tags
            /// to manage your resources.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Redshift::ClusterSecurityGroup";

        public ClusterSecurityGroupProperties Properties { get; } = new ClusterSecurityGroupProperties();

    }
}
