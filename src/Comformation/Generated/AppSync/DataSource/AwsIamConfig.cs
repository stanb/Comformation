using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-awsiamconfig.html
    /// </summary>
    public class AwsIamConfig
    {

        /// <summary>
        /// SigningRegion
        /// </summary>
        [JsonProperty("SigningRegion")]
        public Union<string, IntrinsicFunction> SigningRegion { get; set; }

        /// <summary>
        /// SigningServiceName
        /// </summary>
        [JsonProperty("SigningServiceName")]
        public Union<string, IntrinsicFunction> SigningServiceName { get; set; }

    }
}
