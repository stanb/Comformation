using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Template
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datasetconfiguration.html
    /// </summary>
    public class DataSetConfiguration
    {

        /// <summary>
        /// Placeholder
        /// </summary>
        [JsonProperty("Placeholder")]
        public Union<string, IntrinsicFunction> Placeholder { get; set; }

        /// <summary>
        /// DataSetSchema
        /// </summary>
        [JsonProperty("DataSetSchema")]
        public DataSetSchema DataSetSchema { get; set; }

        /// <summary>
        /// ColumnGroupSchemaList
        /// </summary>
        [JsonProperty("ColumnGroupSchemaList")]
        public List<ColumnGroupSchema> ColumnGroupSchemaList { get; set; }

    }
}
