using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-excludeshareddriveslist.html
    /// </summary>
    public class ExcludeSharedDrivesList
    {

        /// <summary>
        /// ExcludeSharedDrivesList_
        /// </summary>
        [JsonProperty("ExcludeSharedDrivesList")]
        public List<Union<string, IntrinsicFunction>> ExcludeSharedDrivesList_ { get; set; }

    }
}
