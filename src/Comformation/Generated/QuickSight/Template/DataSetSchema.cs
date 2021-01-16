using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Template
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datasetschema.html
    /// </summary>
    public class DataSetSchema
    {

        /// <summary>
        /// ColumnSchemaList
        /// </summary>
        [JsonProperty("ColumnSchemaList")]
        public List<ColumnSchema> ColumnSchemaList { get; set; }

    }
}
