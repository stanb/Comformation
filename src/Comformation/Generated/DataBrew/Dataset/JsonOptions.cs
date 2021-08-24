using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Dataset
{
    /// <summary>
    /// AWS::DataBrew::Dataset JsonOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-jsonoptions.html
    /// </summary>
    public class JsonOptions
    {

        /// <summary>
        /// MultiLine
        /// A value that specifies whether JSON input contains embedded new line characters.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MultiLine")]
        public Union<bool, IntrinsicFunction> MultiLine { get; set; }

    }
}
