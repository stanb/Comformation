using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudTrail.Trail
{
    /// <summary>
    /// AWS CloudTrail Trail EventSelector
    /// The EventSelector property type configures logging of management events and data events for an AWS CloudTrail
    /// trail. For more information, see PutEventSelectors in the AWS CloudTrail API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-eventselector.html
    /// </summary>
    public class EventSelector
    {

        /// <summary>
        /// DataResources
        /// The resources for data events. CloudTrail supports logging data events for Amazon S3 objects and AWS
        /// Lambda functions. For more information, see Data Events in the AWS CloudTrail User Guide.
        /// Required: No
        /// Type: List of CloudTrail Trail DataResource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataResources")]
        public List<DataResource> DataResources { get; set; }

        /// <summary>
        /// IncludeManagementEvents
        /// Specifies whether the event selector includes management events for the trail. The default value is
        /// true. For more information, see Management Events in the AWS CloudTrail User Guide.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeManagementEvents")]
        public Union<bool, IntrinsicFunction> IncludeManagementEvents { get; set; }

        /// <summary>
        /// ReadWriteType
        /// Specifies whether to log read-only events, write-only events, or all events. The default value is
        /// All.
        /// Required: No
        /// Type: String
        /// Valid values: ReadOnly | WriteOnly | All
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReadWriteType")]
        public Union<string, IntrinsicFunction> ReadWriteType { get; set; }

    }
}
