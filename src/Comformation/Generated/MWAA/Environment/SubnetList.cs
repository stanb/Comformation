using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MWAA.Environment
{
    /// <summary>
    /// AWS::MWAA::Environment SubnetList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-subnetlist.html
    /// </summary>
    public class SubnetList
    {

        /// <summary>
        /// SubnetList_
        /// </summary>
        [JsonProperty("SubnetList")]
        public List<Union<string, IntrinsicFunction>> SubnetList_ { get; set; }

    }
}
