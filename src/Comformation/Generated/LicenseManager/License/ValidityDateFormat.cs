using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LicenseManager.License
{
    /// <summary>
    /// AWS::LicenseManager::License ValidityDateFormat
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-validitydateformat.html
    /// </summary>
    public class ValidityDateFormat
    {

        /// <summary>
        /// Begin
        /// Start of the time range.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Begin")]
        public Union<string, IntrinsicFunction> Begin { get; set; }

        /// <summary>
        /// End
        /// End of the time range.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("End")]
        public Union<string, IntrinsicFunction> End { get; set; }

    }
}
