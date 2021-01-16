using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-googledriveconfiguration.html
    /// </summary>
    public class GoogleDriveConfiguration
    {

        /// <summary>
        /// SecretArn
        /// </summary>
        [JsonProperty("SecretArn")]
        public Union<string, IntrinsicFunction> SecretArn { get; set; }

        /// <summary>
        /// InclusionPatterns
        /// </summary>
        [JsonProperty("InclusionPatterns")]
        public DataSourceInclusionsExclusionsStrings InclusionPatterns { get; set; }

        /// <summary>
        /// ExclusionPatterns
        /// </summary>
        [JsonProperty("ExclusionPatterns")]
        public DataSourceInclusionsExclusionsStrings ExclusionPatterns { get; set; }

        /// <summary>
        /// FieldMappings
        /// </summary>
        [JsonProperty("FieldMappings")]
        public DataSourceToIndexFieldMappingList FieldMappings { get; set; }

        /// <summary>
        /// ExcludeMimeTypes
        /// </summary>
        [JsonProperty("ExcludeMimeTypes")]
        public ExcludeMimeTypesList ExcludeMimeTypes { get; set; }

        /// <summary>
        /// ExcludeUserAccounts
        /// </summary>
        [JsonProperty("ExcludeUserAccounts")]
        public ExcludeUserAccountsList ExcludeUserAccounts { get; set; }

        /// <summary>
        /// ExcludeSharedDrives
        /// </summary>
        [JsonProperty("ExcludeSharedDrives")]
        public ExcludeSharedDrivesList ExcludeSharedDrives { get; set; }

    }
}
