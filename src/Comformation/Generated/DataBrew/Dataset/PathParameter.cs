using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Dataset
{
    /// <summary>
    /// AWS::DataBrew::Dataset PathParameter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-pathparameter.html
    /// </summary>
    public class PathParameter
    {

        /// <summary>
        /// PathParameterName
        /// The name of the path parameter.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PathParameterName")]
        public Union<string, IntrinsicFunction> PathParameterName { get; set; }

        /// <summary>
        /// DatasetParameter
        /// The path parameter definition.
        /// Required: Yes
        /// Type: DatasetParameter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatasetParameter")]
        public DatasetParameter DatasetParameter { get; set; }

    }
}
