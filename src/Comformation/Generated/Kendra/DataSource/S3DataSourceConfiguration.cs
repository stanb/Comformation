using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource S3DataSourceConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-s3datasourceconfiguration.html
    /// </summary>
    public class S3DataSourceConfiguration
    {

        /// <summary>
        /// BucketName
        /// The name of the bucket that contains the documents.
        /// Required: Yes
        /// Type: String
        /// Minimum: 3
        /// Maximum: 63
        /// Pattern: [a-z0-9][\. \-a-z0-9]{1,61}[a-z0-9]
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

        /// <summary>
        /// InclusionPrefixes
        /// A list of S3 prefixes for the documents that should be included in the index.
        /// Required: No
        /// Type: DataSourceInclusionsExclusionsStrings
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InclusionPrefixes")]
        public DataSourceInclusionsExclusionsStrings InclusionPrefixes { get; set; }

        /// <summary>
        /// InclusionPatterns
        /// A list of glob patterns for documents that should be indexed. If a document that matches an
        /// inclusion pattern also matches an exclusion pattern, the document is not indexed.
        /// For more information about glob patterns, see glob (programming) in Wikipedia.
        /// Required: No
        /// Type: DataSourceInclusionsExclusionsStrings
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InclusionPatterns")]
        public DataSourceInclusionsExclusionsStrings InclusionPatterns { get; set; }

        /// <summary>
        /// ExclusionPatterns
        /// A list of glob patterns for documents that should not be indexed. If a document that matches an
        /// inclusion prefix or inclusion pattern also matches an exclusion pattern, the document is not
        /// indexed.
        /// For more information about glob patterns, see glob (programming) in Wikipedia.
        /// Required: No
        /// Type: DataSourceInclusionsExclusionsStrings
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExclusionPatterns")]
        public DataSourceInclusionsExclusionsStrings ExclusionPatterns { get; set; }

        /// <summary>
        /// DocumentsMetadataConfiguration
        /// Specifies document metadata files that contain information such as the document access control
        /// information, source URI, document author, and custom attributes. Each metadata file contains
        /// metadata about a single document.
        /// Required: No
        /// Type: DocumentsMetadataConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentsMetadataConfiguration")]
        public DocumentsMetadataConfiguration DocumentsMetadataConfiguration { get; set; }

        /// <summary>
        /// AccessControlListConfiguration
        /// Provides the path to the S3 bucket that contains the user context filtering files for the data
        /// source. For the format of the file, see Access control for S3 data sources.
        /// Required: No
        /// Type: AccessControlListConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccessControlListConfiguration")]
        public AccessControlListConfiguration AccessControlListConfiguration { get; set; }

    }
}
