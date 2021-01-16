using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Detector
{
    /// <summary>
    /// AWS::GuardDuty::Detector CFNDataSourceConfigurations
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfndatasourceconfigurations.html
    /// </summary>
    public class CFNDataSourceConfigurations
    {

        /// <summary>
        /// S3Logs
        /// Describes whether S3 data event logs are enabled as a data source.
        /// Required: No
        /// Type: CFNS3LogsConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Logs")]
        public CFNS3LogsConfiguration S3Logs { get; set; }

    }
}
