using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kinesissettings.html
    /// </summary>
    public class KinesisSettings
    {

        /// <summary>
        /// MessageFormat
        /// </summary>
        [JsonProperty("MessageFormat")]
        public Union<string, IntrinsicFunction> MessageFormat { get; set; }

        /// <summary>
        /// StreamArn
        /// </summary>
        [JsonProperty("StreamArn")]
        public Union<string, IntrinsicFunction> StreamArn { get; set; }

        /// <summary>
        /// ServiceAccessRoleArn
        /// </summary>
        [JsonProperty("ServiceAccessRoleArn")]
        public Union<string, IntrinsicFunction> ServiceAccessRoleArn { get; set; }

    }
}
