using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AmazonMQ.ConfigurationAssociation
{
    /// <summary>
    /// ConfigurationAssociation ConfigurationId
    /// The ConfigurationId property type specifies a configuration Id and the revision of a configuration.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-configurationassociation-configurationid.html
    /// </summary>
    public class ConfigurationId
    {

        /// <summary>
        /// Revision
        /// The revision number of the configuration.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Revision")]
        public Union<int, IntrinsicFunction> Revision { get; set; }

        /// <summary>
        /// Id
        /// The Id of the configuration.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

    }
}
