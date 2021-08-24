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
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InclusionPrefixes")]
        public List<Union<string, IntrinsicFunction>> InclusionPrefixes { get; set; }

        /// <summary>
        /// InclusionPatterns
        /// A list of glob patterns for documents that should be indexed. If a document that matches an
        /// inclusion pattern also matches an exclusion pattern, the document is not indexed.
        /// Some examples are:
        /// *. txt will include all text files in a directory (files with the extension . txt). **/*. txt will
        /// include all text files in a directory and its subdirectories. *tax* will include all files in a
        /// directory that contain &#39;tax&#39; in the file name, such as &#39;tax&#39;, &#39;taxes&#39;, &#39;income_tax&#39;.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InclusionPatterns")]
        public List<Union<string, IntrinsicFunction>> InclusionPatterns { get; set; }

        /// <summary>
        /// ExclusionPatterns
        /// A list of glob patterns for documents that should not be indexed. If a document that matches an
        /// inclusion prefix or inclusion pattern also matches an exclusion pattern, the document is not
        /// indexed.
        /// Some examples are:
        /// *. png , *. jpg will exclude all PNG and JPEG image files in a directory (files with the extensions
        /// . png and . jpg). *internal* will exclude all files in a directory that contain &#39;internal&#39; in the
        /// file name, such as &#39;internal&#39;, &#39;internal_only&#39;, &#39;company_internal&#39;. **/*internal* will exclude all
        /// internal-related files in a directory and its subdirectories.
        /// Required: No
        /// Type: List of String
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExclusionPatterns")]
        public List<Union<string, IntrinsicFunction>> ExclusionPatterns { get; set; }

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
