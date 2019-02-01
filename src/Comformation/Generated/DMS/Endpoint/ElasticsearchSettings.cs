using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-elasticsearchsettings.html
    /// </summary>
    public class ElasticsearchSettings
    {

        /// <summary>
        /// EndpointUri
        /// </summary>
        [JsonProperty("EndpointUri")]
        public Union<string, IntrinsicFunction> EndpointUri { get; set; }

        /// <summary>
        /// FullLoadErrorPercentage
        /// </summary>
        [JsonProperty("FullLoadErrorPercentage")]
        public Union<int, IntrinsicFunction> FullLoadErrorPercentage { get; set; }

        /// <summary>
        /// ErrorRetryDuration
        /// </summary>
        [JsonProperty("ErrorRetryDuration")]
        public Union<int, IntrinsicFunction> ErrorRetryDuration { get; set; }

        /// <summary>
        /// ServiceAccessRoleArn
        /// </summary>
        [JsonProperty("ServiceAccessRoleArn")]
        public Union<string, IntrinsicFunction> ServiceAccessRoleArn { get; set; }

    }
}
