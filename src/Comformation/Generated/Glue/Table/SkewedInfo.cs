using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Table
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-skewedinfo.html
    /// </summary>
    public class SkewedInfo
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-skewedinfo.html#cfn-glue-table-skewedinfo-skewedcolumnnames
        /// </summary>
        [JsonProperty("SkewedColumnNames")]
        public Union<List<string>, IntrinsicFunction> SkewedColumnNames { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-skewedinfo.html#cfn-glue-table-skewedinfo-skewedcolumnvalues
        /// </summary>
        [JsonProperty("SkewedColumnValues")]
        public Union<List<string>, IntrinsicFunction> SkewedColumnValues { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-skewedinfo.html#cfn-glue-table-skewedinfo-skewedcolumnvaluelocationmaps
        /// </summary>
        [JsonProperty("SkewedColumnValueLocationMaps")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SkewedColumnValueLocationMaps { get; set; }

    }
}
