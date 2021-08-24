using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Dataset
{
    /// <summary>
    /// AWS::DataBrew::Dataset DatasetParameter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datasetparameter.html
    /// </summary>
    public class DatasetParameter
    {

        /// <summary>
        /// Name
        /// The name of the parameter that is used in the dataset&#39;s Amazon S3 path.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Type
        /// The type of the dataset parameter, can be one of a &#39;String&#39;, &#39;Number&#39; or &#39;Datetime&#39;.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// DatetimeOptions
        /// Additional parameter options such as a format and a timezone. Required for datetime parameters.
        /// Required: No
        /// Type: DatetimeOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatetimeOptions")]
        public DatetimeOptions DatetimeOptions { get; set; }

        /// <summary>
        /// CreateColumn
        /// Optional boolean value that defines whether the captured value of this parameter should be loaded as
        /// an additional column in the dataset.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreateColumn")]
        public Union<bool, IntrinsicFunction> CreateColumn { get; set; }

        /// <summary>
        /// Filter
        /// The optional filter expression structure to apply additional matching criteria to the parameter.
        /// Required: No
        /// Type: FilterExpression
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Filter")]
        public FilterExpression Filter { get; set; }

    }
}
