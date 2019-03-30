using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application PropertyGroup
    /// The PropertyGroup property type specifies property key-value pairs passed into a Java-based Kinesis Data
    /// Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-propertygroup.html
    /// </summary>
    public class PropertyGroup
    {

        /// <summary>
        /// PropertyMap
        /// Describes the value of an application execution property key-value pair.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PropertyMap")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PropertyMap { get; set; }

        /// <summary>
        /// PropertyGroupId
        /// Describes the key of an application execution property key-value pair.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PropertyGroupId")]
        public Union<string, IntrinsicFunction> PropertyGroupId { get; set; }

    }
}