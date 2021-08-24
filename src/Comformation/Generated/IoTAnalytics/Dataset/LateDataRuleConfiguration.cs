using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset LateDataRuleConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-latedataruleconfiguration.html
    /// </summary>
    public class LateDataRuleConfiguration
    {

        /// <summary>
        /// DeltaTimeSessionWindowConfiguration
        /// The information needed to configure a delta time session window.
        /// Required: No
        /// Type: DeltaTimeSessionWindowConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeltaTimeSessionWindowConfiguration")]
        public DeltaTimeSessionWindowConfiguration DeltaTimeSessionWindowConfiguration { get; set; }

    }
}
