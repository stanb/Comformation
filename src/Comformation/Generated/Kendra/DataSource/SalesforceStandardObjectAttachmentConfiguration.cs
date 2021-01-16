using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource SalesforceStandardObjectAttachmentConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforcestandardobjectattachmentconfiguration.html
    /// </summary>
    public class SalesforceStandardObjectAttachmentConfiguration
    {

        /// <summary>
        /// DocumentTitleFieldName
        /// The name of the field used for the document title.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9_. ]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentTitleFieldName")]
        public Union<string, IntrinsicFunction> DocumentTitleFieldName { get; set; }

        /// <summary>
        /// FieldMappings
        /// One or more objects that map fields in attachments to Amazon Kendra index fields.
        /// Required: No
        /// Type: DataSourceToIndexFieldMappingList
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldMappings")]
        public DataSourceToIndexFieldMappingList FieldMappings { get; set; }

    }
}
