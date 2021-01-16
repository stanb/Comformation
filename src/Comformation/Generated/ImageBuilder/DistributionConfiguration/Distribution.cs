using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.DistributionConfiguration
{
    /// <summary>
    /// AWS::ImageBuilder::DistributionConfiguration Distribution
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-distribution.html
    /// </summary>
    public class Distribution
    {

        /// <summary>
        /// Region
        /// The target Region for the Distribution Configuration. For example, eu-west-1.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

        /// <summary>
        /// AmiDistributionConfiguration
        /// The specific AMI settings, such as launch permissions and AMI tags. For details, see example schema
        /// below.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AmiDistributionConfiguration")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> AmiDistributionConfiguration { get; set; }

        /// <summary>
        /// ContainerDistributionConfiguration
        /// Container distribution settings for encryption, licensing, and sharing in a specific Region.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContainerDistributionConfiguration")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ContainerDistributionConfiguration { get; set; }

        /// <summary>
        /// LicenseConfigurationArns
        /// The License Manager Configuration to associate with the AMI in the specified Region. For more
        /// information, see the LicenseConfiguration API.
        /// Required: No
        /// Type: List of String
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LicenseConfigurationArns")]
        public List<Union<string, IntrinsicFunction>> LicenseConfigurationArns { get; set; }

    }
}
