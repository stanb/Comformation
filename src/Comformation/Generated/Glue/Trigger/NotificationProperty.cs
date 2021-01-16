using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Trigger
{
    /// <summary>
    /// AWS::Glue::Trigger NotificationProperty
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-notificationproperty.html
    /// </summary>
    public class NotificationProperty
    {

        /// <summary>
        /// NotifyDelayAfter
        /// After a job run starts, the number of minutes to wait before sending a job run delay notification
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotifyDelayAfter")]
        public Union<int, IntrinsicFunction> NotifyDelayAfter { get; set; }

    }
}
