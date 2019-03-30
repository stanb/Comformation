using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application EnvironmentProperties
    /// The EnvironmentProperties property type specifies execution properties for a Java-based Kinesis Data Analytics
    /// application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-environmentproperties.html
    /// </summary>
    public class EnvironmentProperties
    {

        /// <summary>
        /// PropertyGroups
        /// Describes the execution property groups.
        /// Required: No
        /// Type: List of PropertyGroup
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PropertyGroups")]
        public List<PropertyGroup> PropertyGroups { get; set; }

    }
}
