using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MWAA.Environment
{
    /// <summary>
    /// AWS::MWAA::Environment SecurityGroupList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-securitygrouplist.html
    /// </summary>
    public class SecurityGroupList
    {

        /// <summary>
        /// SecurityGroupList_
        /// </summary>
        [JsonProperty("SecurityGroupList")]
        public List<Union<string, IntrinsicFunction>> SecurityGroupList_ { get; set; }

    }
}
