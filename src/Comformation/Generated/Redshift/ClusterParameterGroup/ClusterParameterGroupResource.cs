using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.ClusterParameterGroup
{
    /// <summary>
    /// AWS::Redshift::ClusterParameterGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clusterparametergroup.html
    /// </summary>
    public class ClusterParameterGroupResource : ResourceBase
    {
        public class ClusterParameterGroupProperties
        {
            /// <summary>
            /// Description
            /// The description of the parameter group.
            /// Required: Yes
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ParameterGroupFamily
            /// The name of the cluster parameter group family that this cluster parameter group is compatible with.
            /// Required: Yes
            /// Type: String
            /// Maximum: 2147483647
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ParameterGroupFamily { get; set; }

            /// <summary>
            /// Parameters
            /// An array of parameters to be modified. A maximum of 20 parameters can be modified in a single
            /// request.
            /// For each parameter to be modified, you must supply at least the parameter name and parameter value;
            /// other name-value pairs of the parameter are optional.
            /// For the workload management (WLM) configuration, you must supply all the name-value pairs in the
            /// wlm_json_configuration parameter.
            /// Required: No
            /// Type: List of Parameter
            /// Update requires: No interruption
            /// </summary>
            public List<Parameter> Parameters { get; set; }

            /// <summary>
            /// Tags
            /// The list of tags for the cluster parameter group.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Redshift::ClusterParameterGroup";

        public ClusterParameterGroupProperties Properties { get; } = new ClusterParameterGroupProperties();

    }
}
