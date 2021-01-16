using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ConfluenceSpaceFieldMappingsList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencespacefieldmappingslist.html
    /// </summary>
    public class ConfluenceSpaceFieldMappingsList
    {

        /// <summary>
        /// ConfluenceSpaceFieldMappingsList_
        /// </summary>
        [JsonProperty("ConfluenceSpaceFieldMappingsList")]
        public List<ConfluenceSpaceToIndexFieldMapping> ConfluenceSpaceFieldMappingsList_ { get; set; }

    }
}
