using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS IoT Analytics Dataset Variable
    /// The Variable property type specifies the values of variables used within the context of the execution of the
    /// containerized application for an AWS IoT Analytics dataset.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-variable.html
    /// </summary>
    public class Variable
    {

        /// <summary>
        /// DatasetContentVersionValue
        /// The value of the variable as a structure that specifies a data set content version.
        /// Required: No
        /// Type: DatasetContentVersionValue
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatasetContentVersionValue")]
        public DatasetContentVersionValue DatasetContentVersionValue { get; set; }

        /// <summary>
        /// DoubleValue
        /// The value of the variable as a Java &quot;double&quot; type.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DoubleValue")]
        public Union<double, IntrinsicFunction> DoubleValue { get; set; }

        /// <summary>
        /// OutputFileUriValue
        /// The value of the variable as a structure that specifies an output file URI.
        /// Required: No
        /// Type: OutputFileUriValue
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputFileUriValue")]
        public OutputFileUriValue OutputFileUriValue { get; set; }

        /// <summary>
        /// VariableName
        /// The name of the variable.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VariableName")]
        public Union<string, IntrinsicFunction> VariableName { get; set; }

        /// <summary>
        /// StringValue
        /// The value of the variable as a Java &quot;string&quot; type.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StringValue")]
        public Union<string, IntrinsicFunction> StringValue { get; set; }

    }
}
