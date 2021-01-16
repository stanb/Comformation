using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaStore.Container
{
    /// <summary>
    /// AWS::MediaStore::Container MetricPolicyRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-metricpolicyrule.html
    /// </summary>
    public class MetricPolicyRule
    {

        /// <summary>
        /// ObjectGroup
        /// A path or file name that defines which objects to include in the group. Wildcards (*) are
        /// acceptable.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 900
        /// Pattern: /?(?:[A-Za-z0-9_=:\. \-\~\*]+/){0,10}(?:[A-Za-z0-9_=:\. \-\~\*]+)?/?
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ObjectGroup")]
        public Union<string, IntrinsicFunction> ObjectGroup { get; set; }

        /// <summary>
        /// ObjectGroupName
        /// A name that allows you to refer to the object group.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 30
        /// Pattern: [a-zA-Z0-9_]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ObjectGroupName")]
        public Union<string, IntrinsicFunction> ObjectGroupName { get; set; }

    }
}
