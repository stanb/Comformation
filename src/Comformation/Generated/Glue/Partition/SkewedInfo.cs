using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Partition
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-skewedinfo.html
    /// </summary>
    public class SkewedInfo
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-skewedinfo.html#cfn-glue-partition-skewedinfo-skewedcolumnnames
        /// </summary>
        [JsonProperty("SkewedColumnNames")]
        public Union<List<string>, IntrinsicFunction> SkewedColumnNames { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-skewedinfo.html#cfn-glue-partition-skewedinfo-skewedcolumnvalues
        /// </summary>
        [JsonProperty("SkewedColumnValues")]
        public Union<List<string>, IntrinsicFunction> SkewedColumnValues { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-skewedinfo.html#cfn-glue-partition-skewedinfo-skewedcolumnvaluelocationmaps
        /// </summary>
        [JsonProperty("SkewedColumnValueLocationMaps")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SkewedColumnValueLocationMaps { get; set; }

    }
}
