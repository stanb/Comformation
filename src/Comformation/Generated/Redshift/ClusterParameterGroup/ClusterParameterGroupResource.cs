using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.ClusterParameterGroup
{
    /// <summary>
    /// AWS::Redshift::ClusterParameterGroup
    /// Creates an Amazon Redshift parameter group that you can associate with an Amazon Redshift cluster. The
    /// parameters in the group apply to all the databases that you create in the cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clusterparametergroup.html
    /// </summary>
    public class ClusterParameterGroupResource : ResourceBase
    {
        public class ClusterParameterGroupProperties
        {
            /// <summary>
            /// Description
            /// A description of the parameter group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ParameterGroupFamily
            /// The Amazon Redshift engine version that applies to this cluster parameter group. The cluster engine
            /// version determines the set of parameters that you can specify in the Parameters property.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ParameterGroupFamily { get; set; }

            /// <summary>
            /// Parameters
            /// A list of parameter names and values that are allowed by the Amazon Redshift engine version that you
            /// specified in the ParameterGroupFamily property. For more information, see Amazon Redshift Parameter
            /// Groups in the Amazon Redshift Cluster Management Guide.
            /// Required: No
            /// Type: Amazon Redshift Parameter Type
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Parameter>, IntrinsicFunction> Parameters { get; set; }

            /// <summary>
            /// Tags
            /// Specifies an arbitrary set of tags (key–value pairs) to associate with this parameter group. Use
            /// tags to manage your resources.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::Redshift::ClusterParameterGroup";
        
        public ClusterParameterGroupProperties Properties { get; } = new ClusterParameterGroupProperties();
    }
}
