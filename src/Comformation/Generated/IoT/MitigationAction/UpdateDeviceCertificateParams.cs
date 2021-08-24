using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.MitigationAction
{
    /// <summary>
    /// AWS::IoT::MitigationAction UpdateDeviceCertificateParams
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-updatedevicecertificateparams.html
    /// </summary>
    public class UpdateDeviceCertificateParams
    {

        /// <summary>
        /// Action
        /// The action that you want to apply to the device certificate. The only supported value is DEACTIVATE.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public Union<string, IntrinsicFunction> Action { get; set; }

    }
}
