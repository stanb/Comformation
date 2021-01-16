using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Alias
{
    /// <summary>
    /// AWS::Lambda::Alias ProvisionedConcurrencyConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-provisionedconcurrencyconfiguration.html
    /// </summary>
    public class ProvisionedConcurrencyConfiguration
    {

        /// <summary>
        /// ProvisionedConcurrentExecutions
        /// The amount of provisioned concurrency to allocate for the alias.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProvisionedConcurrentExecutions")]
        public Union<int, IntrinsicFunction> ProvisionedConcurrentExecutions { get; set; }

    }
}
