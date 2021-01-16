using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Template
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columngroupschema.html
    /// </summary>
    public class ColumnGroupSchema
    {

        /// <summary>
        /// ColumnGroupColumnSchemaList
        /// </summary>
        [JsonProperty("ColumnGroupColumnSchemaList")]
        public List<ColumnGroupColumnSchema> ColumnGroupColumnSchemaList { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
