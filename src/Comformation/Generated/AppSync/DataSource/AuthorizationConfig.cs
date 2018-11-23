using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-authorizationconfig.html
    /// </summary>
    public class AuthorizationConfig
    {

        /// <summary>
        /// AwsIamConfig
        /// </summary>
        [JsonProperty("AwsIamConfig")]
        public AwsIamConfig AwsIamConfig { get; set; }

        /// <summary>
        /// AuthorizationType
        /// </summary>
        [JsonProperty("AuthorizationType")]
        public Union<string, IntrinsicFunction> AuthorizationType { get; set; }

    }
}
