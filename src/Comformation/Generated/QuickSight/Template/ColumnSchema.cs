using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Template
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-columnschema.html
    /// </summary>
    public class ColumnSchema
    {

        /// <summary>
        /// DataType
        /// </summary>
        [JsonProperty("DataType")]
        public Union<string, IntrinsicFunction> DataType { get; set; }

        /// <summary>
        /// GeographicRole
        /// </summary>
        [JsonProperty("GeographicRole")]
        public Union<string, IntrinsicFunction> GeographicRole { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
