using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.CloudFormationProvisionedProduct
{
    /// <summary>
    /// AWS::ServiceCatalog::CloudFormationProvisionedProduct ProvisioningParameter
    /// Information about a parameter used to provision a product.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationprovisionedproduct-provisioningparameter.html
    /// </summary>
    public class ProvisioningParameter
    {

        /// <summary>
        /// Value
        /// The parameter value.
        /// Required: No
        /// Type: String
        /// Maximum: 4096
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Key
        /// The parameter key.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
