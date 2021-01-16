using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT1Click.Project
{
    /// <summary>
    /// AWS::IoT1Click::Project DeviceTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot1click-project-devicetemplate.html
    /// </summary>
    public class DeviceTemplate
    {

        /// <summary>
        /// DeviceType
        /// The device type, which currently must be &quot;button&quot;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceType")]
        public Union<string, IntrinsicFunction> DeviceType { get; set; }

        /// <summary>
        /// CallbackOverrides
        /// An optional AWS Lambda function to invoke instead of the default AWS Lambda function provided by the
        /// placement template.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CallbackOverrides")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> CallbackOverrides { get; set; }

    }
}
