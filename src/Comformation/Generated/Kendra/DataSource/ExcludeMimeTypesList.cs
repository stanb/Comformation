using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-excludemimetypeslist.html
    /// </summary>
    public class ExcludeMimeTypesList
    {

        /// <summary>
        /// ExcludeMimeTypesList_
        /// </summary>
        [JsonProperty("ExcludeMimeTypesList")]
        public List<Union<string, IntrinsicFunction>> ExcludeMimeTypesList_ { get; set; }

    }
}
