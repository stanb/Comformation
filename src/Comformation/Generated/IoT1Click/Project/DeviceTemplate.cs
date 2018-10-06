using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT1Click.Project
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot1click-project-devicetemplate.html
    /// </summary>
    public class DeviceTemplate
    {

        /// <summary>
        /// DeviceType
        /// </summary>
        [JsonProperty("DeviceType")]
        public Union<string, IntrinsicFunction> DeviceType { get; set; }

        /// <summary>
        /// CallbackOverrides
        /// </summary>
        [JsonProperty("CallbackOverrides")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> CallbackOverrides { get; set; }

    }
}
