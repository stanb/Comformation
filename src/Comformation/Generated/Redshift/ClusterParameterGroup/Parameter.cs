using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.ClusterParameterGroup
{
    /// <summary>
    /// AWS::Redshift::ClusterParameterGroup Parameter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-property-redshift-clusterparametergroup-parameter.html
    /// </summary>
    public class Parameter
    {

        /// <summary>
        /// ParameterName
        /// The name of the parameter.
        /// Required: Yes
        /// Type: String
        /// Maximum: 2147483647
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParameterName")]
        public Union<string, IntrinsicFunction> ParameterName { get; set; }

        /// <summary>
        /// ParameterValue
        /// The value of the parameter. If ParameterName is wlm_json_configuration, then the maximum size of
        /// ParameterValue is 8000 characters.
        /// Required: Yes
        /// Type: String
        /// Maximum: 2147483647
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParameterValue")]
        public Union<string, IntrinsicFunction> ParameterValue { get; set; }

    }
}
