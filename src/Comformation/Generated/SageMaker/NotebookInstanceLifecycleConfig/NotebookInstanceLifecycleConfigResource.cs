using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.NotebookInstanceLifecycleConfig
{
    /// <summary>
    /// AWS::SageMaker::NotebookInstanceLifecycleConfig
    /// The AWS::SageMaker::NotebookInstanceLifecycleConfig resource specifies shell scripts that run when you create
    /// and/or start a notebook instance. For more information, see Customize a Notebook Instance in the Amazon
    /// SageMaker Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstancelifecycleconfig.html
    /// </summary>
    public class NotebookInstanceLifecycleConfigResource : ResourceBase
    {
        public class NotebookInstanceLifecycleConfigProperties
        {
            /// <summary>
            /// OnStart
            /// A shell script that runs once when you create a notebook instance, and then each time you start the
            /// notebook instance.
            /// Required: No
            /// Type: List of Amazon SageMaker NotebookInstanceLifecycleConfig NotebookInstanceLifecycleHook
            /// Update requires: No interruption
            /// </summary>
			public List<NotebookInstanceLifecycleHook> OnStart { get; set; }

            /// <summary>
            /// NotebookInstanceLifecycleConfigName
            /// The name of the lifecycle configuration.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> NotebookInstanceLifecycleConfigName { get; set; }

            /// <summary>
            /// OnCreate
            /// A shell script that runs only once, when you create a notebook instance.
            /// Required: No
            /// Type: List of Amazon SageMaker NotebookInstanceLifecycleConfig NotebookInstanceLifecycleHook
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
