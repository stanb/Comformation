using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Association
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-parametervalues.html
    /// </summary>
    public class ParameterValues
    {

        /// <summary>
        /// ParameterValues_
        /// </summary>
        [JsonProperty("ParameterValues")]
        public List<Union<string, IntrinsicFunction>> ParameterValues_ { get; set; }

    }
}
