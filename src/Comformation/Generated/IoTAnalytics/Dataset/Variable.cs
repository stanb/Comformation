using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset Variable
    /// An instance of a variable to be passed to the &quot;containerAction&quot; execution. Each variable must have a name and
    /// a value given by one of &quot;stringValue&quot;, &quot;datasetContentVersionValue&quot;, or &quot;outputFileUriValue&quot;.
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
        /// The value of the variable as a double (numeric).
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
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VariableName")]
        public Union<string, IntrinsicFunction> VariableName { get; set; }

        /// <summary>
        /// StringValue
        /// The value of the variable as a string.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StringValue")]
        public Union<string, IntrinsicFunction> StringValue { get; set; }

    }
}
