using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.StepFunctions.Activity
{
    /// <summary>
    /// AWS::StepFunctions::Activity
    /// An activity is a task that you write in any programming language and host on any machine that has access to
    /// AWS Step Functions. Activities must poll Step Functions using the GetActivityTask API action and respond using
    /// SendTask* API actions. This function lets Step Functions know the existence of your activity and returns an
    /// identifier for use in a state machine and when polling from the activity.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-activity.html
    /// </summary>
    public class ActivityResource : ResourceBase
    {
        public class ActivityProperties
        {
            /// <summary>
            /// Tags
            /// The list of tags to add to a resource.
            /// Tags may only contain unicode letters, digits, whitespace, or these symbols: _ . : / = + - @.
            /// Required: No
            /// Type: List of TagsEntry
            /// Update requires: No interruption
            /// </summary>
			public List<TagsEntry> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the activity.
            /// A name must not contain:
            /// whitespace brackets &amp;lt; &amp;gt; { } [ ] wildcard characters ? * special characters &quot; # % \ ^ | ~ ` $
            /// &amp;amp; , ; : / control characters (U+0000-001F, U+007F-009F)
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::StepFunctions::Activity";

        public ActivityProperties Properties { get; } = new ActivityProperties();

    }

	public static class ActivityAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
