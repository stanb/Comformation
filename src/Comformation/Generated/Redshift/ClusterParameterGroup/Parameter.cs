using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.ClusterParameterGroup
{
    /// <summary>
    /// AWS::Redshift::ClusterParameterGroup Parameter
    /// Describes a parameter in a cluster parameter group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-property-redshift-clusterparametergroup-parameter.html
    /// </summary>
    public class Parameter
    {

        /// <summary>
        /// ParameterName
        /// The name of the parameter.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParameterName")]
        public Union<string, IntrinsicFunction> ParameterName { get; set; }

        /// <summary>
        /// ParameterValue
        /// The value of the parameter.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParameterValue")]
        public Union<string, IntrinsicFunction> ParameterValue { get; set; }

    }
}
