using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.NotebookInstance
{
    /// <summary>
    /// AWS::SageMaker::NotebookInstance
    /// The AWS::SageMaker::NotebookInstance resource Creates an Amazon SageMaker notebook instance. A notebook
    /// instance is a machine learning (ML) compute instance running on a Jupyter notebook. For more information, see
    /// Using Notebook Instances in the Amazon SageMaker Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html
    /// </summary>
    public class NotebookInstanceResource : ResourceBase
    {
        public class NotebookInstanceProperties
        {
            /// <summary>
            /// KmsKeyId
            /// If you provide a AWS KMS key ID, Amazon SageMaker uses it to encrypt data at rest on the ML storage
            /// volume that is attached to your notebook instance.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// DirectInternetAccess
            /// Sets whether Amazon SageMaker provides internet access to the notebook instance. If you set this to
            /// Disabled this notebook instance will be able to access resources only in your VPC, and will not be
            /// able to connect to Amazon SageMaker training and endpoint services unless your configure a NAT
            /// Gateway in your VPC. For more information, see Notebook Instances Are Enabled with Internet Access
            /// by Default. You can set the value of this parameter to Disabled only if you set a value for the
            /// SubnetId parameter.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DirectInternetAccess { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID of the subnet in a VPC to which you would like to have a connectivity from your ML compute
            /// instance.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// NotebookInstanceName
            /// The name of the notebook instance.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> NotebookInstanceName { get; set; }

            /// <summary>
            /// InstanceType
            /// The type of ML compute instance to launch for the notebook instance.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// LifecycleConfigName
            /// The name of a lifecycle configuration to associate with the notebook instance. For information about
            /// lifestyle configurations, see Customize a Notebook Instance in the Amazon SageMaker Developer Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LifecycleConfigName { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// The VPC security group IDs, in the form sg-xxxxxxxx. The security groups must be for the same VPC as
            /// specified in the subnet.
            /// Required: No
            /// Type: List of Strings
            /// Update requires: Replacement
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroupIds { get; set; }

            /// <summary>
            /// RoleArn
            /// When you send any requests to AWS resources from the notebook instance, Amazon SageMaker assumes
            /// this role to perform tasks on your behalf. You must grant this role necessary permissions so Amazon
            /// SageMaker can perform these tasks. The policy must allow the Amazon SageMaker service principal
            /// (sagemaker. amazonaws. com) permissions to assume this role. For more information, see Amazon
            /// SageMaker Roles.
            /// Required: Yes
            /// Type:
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// A list of tags to associate with the notebook instance.
            /// Required: No
            /// Type: List of Amazon SageMaker NotebookInstance Tag
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::SageMaker::NotebookInstance";
        
        public NotebookInstanceProperties Properties { get; } = new NotebookInstanceProperties();
    }

	public static class NotebookInstanceAttributes
	{
        public static readonly ResourceAttribute<string> NotebookInstanceName = new ResourceAttribute<string>("NotebookInstanceName");
	}
}
