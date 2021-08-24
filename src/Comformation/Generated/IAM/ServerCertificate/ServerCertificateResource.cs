using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.ServerCertificate
{
    /// <summary>
    /// AWS::IAM::ServerCertificate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-servercertificate.html
    /// </summary>
    public class ServerCertificateResource : ResourceBase
    {
        public class ServerCertificateProperties
        {
            /// <summary>
            /// CertificateBody
            /// The contents of the public key certificate.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 16384
            /// Pattern: [\u0009\u000A\u000D\u0020-\u00FF]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CertificateBody { get; set; }

            /// <summary>
            /// CertificateChain
            /// The contents of the public key certificate chain.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2097152
            /// Pattern: [\u0009\u000A\u000D\u0020-\u00FF]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CertificateChain { get; set; }

            /// <summary>
            /// ServerCertificateName
            /// The name for the server certificate. Do not include the path in this value. The name of the
            /// certificate cannot contain any spaces.
            /// This parameter allows (through its regex pattern) a string of characters consisting of upper and
            /// lowercase alphanumeric characters with no spaces. You can also include any of the following
            /// characters: _+=,. @-
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\w+=,. @-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServerCertificateName { get; set; }

            /// <summary>
            /// Path
            /// The path for the server certificate. For more information about paths, see IAM identifiers in the
            /// IAM User Guide.
            /// This parameter is optional. If it is not included, it defaults to a slash (/). This parameter allows
            /// (through its regex pattern) a string of characters consisting of either a forward slash (/) by
            /// itself or a string that must begin and end with forward slashes. In addition, it can contain any
            /// ASCII character from the ! (\u0021) through the DEL character (\u007F), including most punctuation
            /// characters, digits, and upper and lowercased letters.
            /// Note If you are uploading a server certificate specifically for use with Amazon CloudFront
            /// distributions, you must specify a path using the path parameter. The path must begin with
            /// /cloudfront and must include a trailing slash (for example, /cloudfront/test/).
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Pattern: (\u002F)|(\u002F[\u0021-\u007F]+\u002F)
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Path { get; set; }

            /// <summary>
            /// PrivateKey
            /// The contents of the private key in PEM-encoded format.
            /// The regex pattern used to validate this parameter is a string of characters consisting of the
            /// following:
            /// Any printable ASCII character ranging from the space character (\u0020) through the end of the ASCII
            /// character range The printable characters in the Basic Latin and Latin-1 Supplement character set
            /// (through \u00FF) The special characters tab (\u0009), line feed (\u000A), and carriage return
            /// (\u000D)
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 16384
            /// Pattern: [\u0009\u000A\u000D\u0020-\u00FF]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PrivateKey { get; set; }

            /// <summary>
            /// Tags
            /// A list of tags that are attached to the server certificate. For more information about tagging, see
            /// Tagging IAM resources in the IAM User Guide.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IAM::ServerCertificate";

        public ServerCertificateProperties Properties { get; } = new ServerCertificateProperties();

    }

    public static class ServerCertificateAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
