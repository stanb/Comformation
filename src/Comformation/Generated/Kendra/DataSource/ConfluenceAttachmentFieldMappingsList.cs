using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource ConfluenceAttachmentFieldMappingsList
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluenceattachmentfieldmappingslist.html
    /// </summary>
    public class ConfluenceAttachmentFieldMappingsList
    {

        /// <summary>
        /// ConfluenceAttachmentFieldMappingsList_
        /// </summary>
        [JsonProperty("ConfluenceAttachmentFieldMappingsList")]
        public List<ConfluenceAttachmentToIndexFieldMapping> ConfluenceAttachmentFieldMappingsList_ { get; set; }

    }
}
