using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3ObjectLambda.AccessPoint
{
    /// <summary>
    /// AWS::S3ObjectLambda::AccessPoint ObjectLambdaConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3objectlambda-accesspoint-objectlambdaconfiguration.html
    /// </summary>
    public class ObjectLambdaConfiguration
    {

        /// <summary>
        /// SupportingAccessPoint
        /// Standard access point associated with the Object Lambda Access Point.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SupportingAccessPoint")]
        public Union<string, IntrinsicFunction> SupportingAccessPoint { get; set; }

        /// <summary>
        /// AllowedFeatures
        /// A container for allowed features. Valid inputs are GetObject-Range and GetObject-PartNumber.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowedFeatures")]
        public List<Union<string, IntrinsicFunction>> AllowedFeatures { get; set; }

        /// <summary>
        /// CloudWatchMetricsEnabled
        /// A container for whether the CloudWatch metrics configuration is enabled.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchMetricsEnabled")]
        public Union<bool, IntrinsicFunction> CloudWatchMetricsEnabled { get; set; }

        /// <summary>
        /// TransformationConfigurations
        /// A container for transformation configurations for an Object Lambda Access Point.
        /// Required: Yes
        /// Type: List of TransformationConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TransformationConfigurations")]
        public List<TransformationConfiguration> TransformationConfigurations { get; set; }

    }
}
