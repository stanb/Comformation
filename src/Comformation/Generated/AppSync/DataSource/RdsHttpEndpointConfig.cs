using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-rdshttpendpointconfig.html
    /// </summary>
    public class RdsHttpEndpointConfig
    {

        /// <summary>
        /// AwsRegion
        /// </summary>
        [JsonProperty("AwsRegion")]
        public Union<string, IntrinsicFunction> AwsRegion { get; set; }

        /// <summary>
        /// Schema
        /// </summary>
        [JsonProperty("Schema")]
        public Union<string, IntrinsicFunction> Schema { get; set; }

        /// <summary>
        /// DatabaseName
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// DbClusterIdentifier
        /// </summary>
        [JsonProperty("DbClusterIdentifier")]
        public Union<string, IntrinsicFunction> DbClusterIdentifier { get; set; }

        /// <summary>
        /// AwsSecretStoreArn
        /// </summary>
        [JsonProperty("AwsSecretStoreArn")]
        public Union<string, IntrinsicFunction> AwsSecretStoreArn { get; set; }

    }
}
