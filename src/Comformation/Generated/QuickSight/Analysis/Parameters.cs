using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Analysis
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-analysis-parameters.html
    /// </summary>
    public class Parameters
    {

        /// <summary>
        /// StringParameters
        /// </summary>
        [JsonProperty("StringParameters")]
        public List<StringParameter> StringParameters { get; set; }

        /// <summary>
        /// DecimalParameters
        /// </summary>
        [JsonProperty("DecimalParameters")]
        public List<DecimalParameter> DecimalParameters { get; set; }

        /// <summary>
        /// IntegerParameters
        /// </summary>
        [JsonProperty("IntegerParameters")]
        public List<IntegerParameter> IntegerParameters { get; set; }

        /// <summary>
        /// DateTimeParameters
        /// </summary>
        [JsonProperty("DateTimeParameters")]
        public List<DateTimeParameter> DateTimeParameters { get; set; }

    }
}
