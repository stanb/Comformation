using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ConfluencePageFieldMappingsList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencepagefieldmappingslist.html
    /// </summary>
    public class ConfluencePageFieldMappingsList
    {

        /// <summary>
        /// ConfluencePageFieldMappingsList_
        /// </summary>
        [JsonProperty("ConfluencePageFieldMappingsList")]
        public List<ConfluencePageToIndexFieldMapping> ConfluencePageFieldMappingsList_ { get; set; }

    }
}
