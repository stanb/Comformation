using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudTrail.Trail
{
    /// <summary>
    /// AWS::CloudTrail::Trail EventSelector
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-eventselector.html
    /// </summary>
    public class EventSelector
    {

        /// <summary>
        /// DataResources
        /// CloudTrail supports data event logging for Amazon S3 objects and AWS Lambda functions. You can
        /// specify up to 250 resources for an individual event selector, but the total number of data resources
        /// cannot exceed 250 across all event selectors in a trail. This limit does not apply if you configure
        /// resource logging for all data events.
        /// For more information, see Data Events and Limits in AWS CloudTrail in the AWS CloudTrail User Guide.
        /// Required: Conditional
        /// Type: List of DataResource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataResources")]
        public List<DataResource> DataResources { get; set; }

        /// <summary>
        /// IncludeManagementEvents
        /// Specify if you want your event selector to include management events for your trail.
        /// For more information, see Management Events in the AWS CloudTrail User Guide.
        /// By default, the value is true.
        /// The first copy of management events is free. You are charged for additional copies of management
        /// events that you are logging on any subsequent trail in the same region. For more information about
        /// CloudTrail pricing, see AWS CloudTrail Pricing.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeManagementEvents")]
        public Union<bool, IntrinsicFunction> IncludeManagementEvents { get; set; }

        /// <summary>
        /// ReadWriteType
        /// Specify if you want your trail to log read-only events, write-only events, or all. For example, the
        /// EC2 GetConsoleOutput is a read-only API operation and RunInstances is a write-only API operation.
        /// By default, the value is All.
        /// Required: No
        /// Type: String
        /// Allowed values: All | ReadOnly | WriteOnly
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReadWriteType")]
        public Union<string, IntrinsicFunction> ReadWriteType { get; set; }

    }
}
