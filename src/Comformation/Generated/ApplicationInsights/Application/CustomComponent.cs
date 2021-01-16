using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationInsights.Application
{
    /// <summary>
    /// AWS::ApplicationInsights::Application CustomComponent
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-customcomponent.html
    /// </summary>
    public class CustomComponent
    {

        /// <summary>
        /// ComponentName
        /// The name of the component.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[\d\w\-_\. +]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComponentName")]
        public Union<string, IntrinsicFunction> ComponentName { get; set; }

        /// <summary>
        /// ResourceList
        /// The list of resource ARNs that belong to the component.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceList")]
        public List<Union<string, IntrinsicFunction>> ResourceList { get; set; }

    }
}
