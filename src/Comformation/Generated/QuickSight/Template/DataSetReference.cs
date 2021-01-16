using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Template
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-template-datasetreference.html
    /// </summary>
    public class DataSetReference
    {

        /// <summary>
        /// DataSetArn
        /// </summary>
        [JsonProperty("DataSetArn")]
        public Union<string, IntrinsicFunction> DataSetArn { get; set; }

        /// <summary>
        /// DataSetPlaceholder
        /// </summary>
        [JsonProperty("DataSetPlaceholder")]
        public Union<string, IntrinsicFunction> DataSetPlaceholder { get; set; }

    }
}
