using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Version
{
    /// <summary>
    /// AWS::Lambda::Version ProvisionedConcurrencyConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-version-provisionedconcurrencyconfiguration.html
    /// </summary>
    public class ProvisionedConcurrencyConfiguration
    {

        /// <summary>
        /// ProvisionedConcurrentExecutions
        /// The amount of provisioned concurrency to allocate for the version.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProvisionedConcurrentExecutions")]
        public Union<int, IntrinsicFunction> ProvisionedConcurrentExecutions { get; set; }

    }
}
