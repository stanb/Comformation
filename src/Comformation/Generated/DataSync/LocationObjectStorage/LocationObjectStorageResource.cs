using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.LocationObjectStorage
{
    /// <summary>
    /// AWS::DataSync::LocationObjectStorage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationobjectstorage.html
    /// </summary>
    public class LocationObjectStorageResource : ResourceBase
    {
        public class LocationObjectStorageProperties
        {
            /// <summary>
            /// AccessKey
            /// Optional. The access key is used if credentials are required to access the self-managed object
            /// storage server. If your object storage requires a user name and password to authenticate, use
            /// AccessKey and SecretKey to provide the user name and password, respectively.
            /// Required: No
            /// Type: String
            /// Minimum: 8
            /// Maximum: 200
            /// Pattern: ^. +$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AccessKey { get; set; }

            /// <summary>
            /// AgentArns
            /// The Amazon Resource Name (ARN) of the agents associated with the self-managed object storage server
            /// location.
            /// Required: Yes
            /// Type: List of String
            /// Maximum: 4
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AgentArns { get; set; }

            /// <summary>
            /// BucketName
            /// The bucket on the self-managed object storage server that is used to read data from.
            /// Required: Yes
            /// Type: String
            /// Minimum: 3
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9_\-\+\. /\(\)\$\p{Zs}]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> BucketName { get; set; }

            /// <summary>
            /// SecretKey
            /// Optional. The secret key is used if credentials are required to access the self-managed object
            /// storage server. If your object storage requires a user name and password to authenticate, use
            /// AccessKey and SecretKey to provide the user name and password, respectively.
            /// Required: No
            /// Type: String
            /// Minimum: 8
            /// Maximum: 200
            /// Pattern: ^. +$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SecretKey { get; set; }

            /// <summary>
            /// ServerHostname
            /// The name of the self-managed object storage server. This value is the IP address or Domain Name
            /// Service (DNS) name of the object storage server. An agent uses this host name to mount the object
            /// storage server in a network.
            /// Required: Yes
            /// Type: String
            /// Maximum: 255
            /// Pattern: ^(([a-zA-Z0-9\-]*[a-zA-Z0-9])\. )*([A-Za-z0-9\-]*[A-Za-z0-9])$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServerHostname { get; set; }

            /// <summary>
            /// ServerPort
            /// The port that your self-managed object storage server accepts inbound network traffic on. The server
            /// port is set by default to TCP 80 (HTTP) or TCP 443 (HTTPS). You can specify a custom port if your
            /// self-managed object storage server requires one.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 65536
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> ServerPort { get; set; }

            /// <summary>
            /// ServerProtocol
            /// The protocol that the object storage server uses to communicate. Valid values are HTTP or HTTPS.
            /// Required: No
            /// Type: String
            /// Allowed values: HTTP | HTTPS
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ServerProtocol { get; set; }

            /// <summary>
            /// Subdirectory
            /// The subdirectory in the self-managed object storage server that is used to read data from.
            /// Required: No
            /// Type: String
            /// Maximum: 4096
            /// Pattern: ^[a-zA-Z0-9_\-\+\. /\(\)\p{Zs}]*$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Subdirectory { get; set; }

            /// <summary>
            /// Tags
            /// The key-value pair that represents the tag that you want to add to the location. The value can be an
            /// empty string. We recommend using tags to name your resources.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DataSync::LocationObjectStorage";

        public LocationObjectStorageProperties Properties { get; } = new LocationObjectStorageProperties();

    }

    public static class LocationObjectStorageAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LocationArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LocationArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LocationUri = new ResourceAttribute<Union<string, IntrinsicFunction>>("LocationUri");
    }
}
