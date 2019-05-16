using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Pipeline
{
    /// <summary>
    /// AWS::IoTAnalytics::Pipeline Datastore
    /// The &#39;datastore&#39; activity that specifies where to store the processed data.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-pipeline-datastore.html
    /// </summary>
    public class Datastore
    {

        /// <summary>
        /// DatastoreName
        /// The name of the data store where processed messages are stored.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[a-zA-Z0-9_]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatastoreName")]
        public Union<string, IntrinsicFunction> DatastoreName { get; set; }

        /// <summary>
        /// Name
        /// The name of the &#39;datastore&#39; activity.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
