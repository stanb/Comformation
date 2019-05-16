using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Association
{
    /// <summary>
    /// AWS::SSM::Association ParameterValues
    /// ParameterValues is a property of the AWS::SSM::Association resource that specifies the parameters for the
    /// runtime configuration of the document.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-parametervalues.html
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
