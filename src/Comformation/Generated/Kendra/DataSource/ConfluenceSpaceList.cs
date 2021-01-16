using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ConfluenceSpaceList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencespacelist.html
    /// </summary>
    public class ConfluenceSpaceList
    {

        /// <summary>
        /// ConfluenceSpaceList_
        /// </summary>
        [JsonProperty("ConfluenceSpaceList")]
        public List<Union<string, IntrinsicFunction>> ConfluenceSpaceList_ { get; set; }

    }
}
