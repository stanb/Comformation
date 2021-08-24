using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Document
{
    /// <summary>
    /// AWS::SSM::Document AttachmentsSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-document-attachmentssource.html
    /// </summary>
    public class AttachmentsSource
    {

        /// <summary>
        /// Key
        /// The key of a key-value pair that identifies the location of an attachment to a document.
        /// Required: No
        /// Type: String
        /// Allowed values: AttachmentReference | S3FileUrl | SourceUrl
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Values
        /// The value of a key-value pair that identifies the location of an attachment to a document. The
        /// format for Value depends on the type of key you specify.
        /// For the key SourceUrl, the value is an S3 bucket location. For example: &quot;Values&quot;: [
        /// &quot;s3://doc-example-bucket/my-folder&quot; ] For the key S3FileUrl, the value is a file in an S3 bucket.
        /// For example: &quot;Values&quot;: [ &quot;s3://doc-example-bucket/my-folder/my-file. py&quot; ] For the key
        /// AttachmentReference, the value is constructed from the name of another SSM document in your account,
        /// a version number of that document, and a file attached to that document version that you want to
        /// reuse. For example: &quot;Values&quot;: [ &quot;MyOtherDocument/3/my-other-file. py&quot; ] However, if the SSM document
        /// is shared with you from another account, the full SSM document ARN must be specified instead of the
        /// document name only. For example: &quot;Values&quot;: [
        /// &quot;arn:aws:ssm:us-east-2:111122223333:document/OtherAccountDocument/3/their-file. py&quot; ]
        /// Required: No
        /// Type: List of String
        /// Maximum: 1
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

        /// <summary>
        /// Name
        /// The name of the document attachment file.
        /// Required: No
        /// Type: String
        /// Pattern: ^[a-zA-Z0-9_\-. ]{3,128}$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
