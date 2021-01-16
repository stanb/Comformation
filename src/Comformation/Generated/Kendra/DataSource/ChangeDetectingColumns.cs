using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ChangeDetectingColumns
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-changedetectingcolumns.html
    /// </summary>
    public class ChangeDetectingColumns
    {

        /// <summary>
        /// ChangeDetectingColumns_
        /// </summary>
        [JsonProperty("ChangeDetectingColumns")]
        public List<Union<string, IntrinsicFunction>> ChangeDetectingColumns_ { get; set; }

    }
}
