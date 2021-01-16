using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ConfluenceBlogFieldMappingsList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceblogfieldmappingslist.html
    /// </summary>
    public class ConfluenceBlogFieldMappingsList
    {

        /// <summary>
        /// ConfluenceBlogFieldMappingsList_
        /// </summary>
        [JsonProperty("ConfluenceBlogFieldMappingsList")]
        public List<ConfluenceBlogToIndexFieldMapping> ConfluenceBlogFieldMappingsList_ { get; set; }

    }
}
