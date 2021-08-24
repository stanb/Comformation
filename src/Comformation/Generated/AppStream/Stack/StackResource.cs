using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.Stack
{
    /// <summary>
    /// AWS::AppStream::Stack
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html
    /// </summary>
    public class StackResource : ResourceBase
    {
        public class StackProperties
        {
            /// <summary>
            /// Description
            /// The description to display.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// StorageConnectors
            /// The storage connectors to enable.
            /// Required: No
            /// Type: List of StorageConnector
            /// Update requires: No interruption
            /// </summary>
            public List<StorageConnector> StorageConnectors { get; set; }

            /// <summary>
            /// DeleteStorageConnectors
            /// This parameter has been deprecated.
            /// Deletes the storage connectors currently enabled for the stack.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DeleteStorageConnectors { get; set; }

            /// <summary>
            /// EmbedHostDomains
            /// The domains where AppStream 2. 0 streaming sessions can be embedded in an iframe. You must approve
            /// the domains that you want to host embedded AppStream 2. 0 streaming sessions.
            /// Required: No
            /// Type: List of String
            /// Maximum: 20
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> EmbedHostDomains { get; set; }

            /// <summary>
            /// UserSettings
            /// The actions that are enabled or disabled for users during their streaming sessions. By default,
            /// these actions are enabled.
            /// Required: No
            /// Type: List of UserSetting
            /// Update requires: No interruption
            /// </summary>
            public List<UserSetting> UserSettings { get; set; }

            /// <summary>
            /// AttributesToDelete
            /// The stack attributes to delete.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AttributesToDelete { get; set; }

            /// <summary>
            /// RedirectURL
            /// The URL that users are redirected to after their streaming session ends.
            /// Required: No
            /// Type: String
            /// Maximum: 1000
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RedirectURL { get; set; }

            /// <summary>
            /// Name
            /// The name of the stack.
            /// Required: No
            /// Type: String
            /// Pattern: ^[a-zA-Z0-9][a-zA-Z0-9_. -]{0,100}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// FeedbackURL
            /// The URL that users are redirected to after they click the Send Feedback link. If no URL is
            /// specified, no Send Feedback link is displayed.
            /// Required: No
            /// Type: String
            /// Maximum: 1000
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FeedbackURL { get; set; }

            /// <summary>
            /// ApplicationSettings
            /// The persistent application settings for users of the stack. When these settings are enabled, changes
            /// that users make to applications and Windows settings are automatically saved after each session and
            /// applied to the next session.
            /// Required: No
            /// Type: ApplicationSettings
            /// Update requires: No interruption
            /// </summary>
            public ApplicationSettings ApplicationSettings { get; set; }

            /// <summary>
            /// DisplayName
            /// The stack name to display.
            /// Required: No
            /// Type: String
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DisplayName { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// AccessEndpoints
            /// The list of virtual private cloud (VPC) interface endpoint objects. Users of the stack can connect
            /// to AppStream 2. 0 only through the specified endpoints.
            /// Required: No
            /// Type: List of AccessEndpoint
            /// Maximum: 4
            /// Update requires: No interruption
            /// </summary>
            public List<AccessEndpoint> AccessEndpoints { get; set; }

        }

        public string Type { get; } = "AWS::AppStream::Stack";

        public StackProperties Properties { get; } = new StackProperties();

    }
}
