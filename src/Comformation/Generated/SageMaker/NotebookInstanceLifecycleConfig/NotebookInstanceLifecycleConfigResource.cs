using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.NotebookInstanceLifecycleConfig
{
    /// <summary>
    /// AWS::SageMaker::NotebookInstanceLifecycleConfig
    /// The AWS::SageMaker::NotebookInstanceLifecycleConfig resource creates shell scripts that run when you create
    /// and/or start a notebook instance. For information about notebook instance lifestyle configurations, see
    /// Customize a Notebook Instance in the Amazon SageMaker Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstancelifecycleconfig.html
    /// </summary>
    public class NotebookInstanceLifecycleConfigResource : ResourceBase
    {
        public class NotebookInstanceLifecycleConfigProperties
        {
            /// <summary>
            /// OnStart
            /// A shell script that runs every time you start a notebook instance, including when you create the
            /// notebook instance. The shell script must be a base64-encoded string.
            /// Required: No
            /// Type: List of NotebookInstanceLifecycleHook
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
			public List<NotebookInstanceLifecycleHook> OnStart { get; set; }

            /// <summary>
            /// NotebookInstanceLifecycleConfigName
            /// The name of the lifecycle configuration.
            /// Required: No
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9])*
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> NotebookInstanceLifecycleConfigName { get; set; }

            /// <summary>
            /// OnCreate
            /// A shell script that runs only once, when you create a notebook instance. The shell script must be a
            /// base64-encoded string.
            /// Required: No
            /// Type: List of NotebookInstanceLifecycleHook
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
			public List<NotebookInstanceLifecycleHook> OnCreate { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::NotebookInstanceLifecycleConfig";

        public NotebookInstanceLifecycleConfigProperties Properties { get; } = new NotebookInstanceLifecycleConfigProperties();

    }

	public static class NotebookInstanceLifecycleConfigAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> NotebookInstanceLifecycleConfigName = new ResourceAttribute<Union<string, IntrinsicFunction>>("NotebookInstanceLifecycleConfigName");
	}
}
