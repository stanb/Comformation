using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.ClusterParameterGroup
{
    /// <summary>
    /// Amazon Redshift Parameter Type
    /// Describes parameters for the AWS::Redshift::ClusterParameterGroup resource type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-property-redshift-clusterparametergroup-parameter.html
    /// </summary>
    public class Parameter
    {

        /// <summary>
        /// ParameterName
        /// The name of the parameter.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("ParameterName")]
        public Union<string, IntrinsicFunction> ParameterName { get; set; }

        /// <summary>
        /// ParameterValue
        /// The value of the parameter.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("ParameterValue")]
        public Union<string, IntrinsicFunction> ParameterValue { get; set; }

    }
}
