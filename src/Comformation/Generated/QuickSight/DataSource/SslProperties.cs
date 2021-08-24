using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.DataSource
{
    /// <summary>
    /// AWS::QuickSight::DataSource SslProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-datasource-sslproperties.html
    /// </summary>
    public class SslProperties
    {

        /// <summary>
        /// DisableSsl
        /// A Boolean option to control whether SSL should be disabled.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisableSsl")]
        public Union<bool, IntrinsicFunction> DisableSsl { get; set; }

    }
}
