using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-excludeuseraccountslist.html
    /// </summary>
    public class ExcludeUserAccountsList
    {

        /// <summary>
        /// ExcludeUserAccountsList_
        /// </summary>
        [JsonProperty("ExcludeUserAccountsList")]
        public List<Union<string, IntrinsicFunction>> ExcludeUserAccountsList_ { get; set; }

    }
}
