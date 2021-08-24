using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.MitigationAction
{
    /// <summary>
    /// AWS::IoT::MitigationAction ReplaceDefaultPolicyVersionParams
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-replacedefaultpolicyversionparams.html
    /// </summary>
    public class ReplaceDefaultPolicyVersionParams
    {

        /// <summary>
        /// TemplateName
        /// The name of the template to be applied. The only supported value is BLANK_POLICY.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TemplateName")]
        public Union<string, IntrinsicFunction> TemplateName { get; set; }

    }
}
