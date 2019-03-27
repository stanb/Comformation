using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.Stack
{
    /// <summary>
    /// AWS::AppStream::Stack
    /// The AWS::AppStream::Stack resource creates a stack to start streaming applications to Amazon AppStream 2. 0
    /// users. For more information, see CreateStack in the Amazon AppStream 2. 0 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html
    /// </summary>
    public class StackResource : ResourceBase
    {
        public class StackProperties
        {
            /// <summary>
            /// ApplicationSettings
            /// The persistent application settings for users of a stack. When these settings are enabled, changes
            /// that users make to applications and Windows settings are automatically saved after each session and
            /// applied to the next session.
            /// Required: No
            /// Type: ApplicationSettings
            /// Update requires: No interruption
            /// </summary>
			public ApplicationSettings ApplicationSettings { get; set; }

            /// <summary>
            /// Description
            /// The description to display.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// StorageConnectors
            /// The storage connectors to enable.
            /// Required: No
            /// Type: List of StorageConnector property types
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
            /// UserSettings
            /// The actions that are enabled or disabled for users during their streaming sessions. By default,
            /// these actions are enabled.
            /// Required: No
            /// Type: List of UserSetting property types
            /// Update requires: No interruption
            /// </summary>
			public List<UserSetting> UserSettings { get; set; }

            /// <summary>
            /// AttributesToDelete
            /// The stack attributes to delete.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AttributesToDelete { get; set; }

            /// <summary>
            /// DisplayName
            /// The stack name to display.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DisplayName { get; set; }

            /// <summary>
            /// RedirectURL
            /// The URL that users are redirected to after their streaming session ends.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RedirectURL { get; set; }

            /// <summary>
            /// Tags
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the stack.
            /// Required: True
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// FeedbackURL
            /// The URL that users are redirected to after they choose the Send Feedback link. If no URL is
            /// specified, no Send Feedback link is displayed.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> FeedbackURL { get; set; }

        }

        public string Type { get; } = "AWS::AppStream::Stack";

        public StackProperties Properties { get; } = new StackProperties();

    }
}
