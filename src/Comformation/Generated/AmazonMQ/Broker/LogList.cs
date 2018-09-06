using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AmazonMQ.Broker
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-broker-loglist.html
    /// </summary>
    public class LogList
    {

        /// <summary>
        /// Audit
        /// </summary>
        [JsonProperty("Audit")]
        public Union<bool, IntrinsicFunction> Audit { get; set; }

        /// <summary>
        /// General
        /// </summary>
        [JsonProperty("General")]
        public Union<bool, IntrinsicFunction> General { get; set; }

    }
}
