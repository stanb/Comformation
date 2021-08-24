using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppIntegrations.EventIntegration
{
    /// <summary>
    /// AWS::AppIntegrations::EventIntegration EventFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-eventintegration-eventfilter.html
    /// </summary>
    public class EventFilter
    {

        /// <summary>
        /// Source
        /// The source of the events.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Source")]
        public Union<string, IntrinsicFunction> Source { get; set; }

    }
}
