using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain SnapshotOptions
    /// The automated snapshot configuration for the Amazon ES domain indices.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-snapshotoptions.html
    /// </summary>
    public class SnapshotOptions
    {

        /// <summary>
        /// AutomatedSnapshotStartHour
        /// The hour in UTC during which the service takes an automated daily snapshot of the indices in the
        /// Amazon ES domain. For example, if you specify 0, Amazon ES takes an automated snapshot everyday
        /// between midnight and 1 am. You can specify a value between 0 and 23.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AutomatedSnapshotStartHour")]
        public Union<int, IntrinsicFunction> AutomatedSnapshotStartHour { get; set; }

    }
}
