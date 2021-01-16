using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConvert.JobTemplate
{
    /// <summary>
    /// AWS::MediaConvert::JobTemplate HopDestination
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconvert-jobtemplate-hopdestination.html
    /// </summary>
    public class HopDestination
    {

        /// <summary>
        /// WaitMinutes
        /// Required for setting up a job to use queue hopping. Minimum wait time in minutes until the job can
        /// hop to the destination queue. Valid range is 1 to 1440 minutes, inclusive.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WaitMinutes")]
        public Union<int, IntrinsicFunction> WaitMinutes { get; set; }

        /// <summary>
        /// Priority
        /// Optional. When you set up a job to use queue hopping, you can specify a different relative priority
        /// for the job in the destination queue. If you don&#39;t specify, the relative priority will remain the
        /// same as in the previous queue.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Priority")]
        public Union<int, IntrinsicFunction> Priority { get; set; }

        /// <summary>
        /// Queue
        /// Optional unless the job is submitted on the default queue. When you set up a job to use queue
        /// hopping, you can specify a destination queue. This queue cannot be the original queue to which the
        /// job is submitted. If the original queue isn&#39;t the default queue and you don&#39;t specify the
        /// destination queue, the job will move to the default queue.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Queue")]
        public Union<string, IntrinsicFunction> Queue { get; set; }

    }
}
