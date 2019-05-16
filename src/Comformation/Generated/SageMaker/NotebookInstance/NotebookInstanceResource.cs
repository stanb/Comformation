using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.NotebookInstance
{
    /// <summary>
    /// AWS::SageMaker::NotebookInstance
    /// The AWS::SageMaker::NotebookInstance resource creates an Amazon SageMaker notebook instance. A notebook
    /// instance is a machine learning (ML) compute instance running on a Jupyter notebook. For more information, see
    /// Use Notebook Instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html
    /// </summary>
    public class NotebookInstanceResource : ResourceBase
    {
        public class NotebookInstanceProperties
        {
            /// <summary>
            /// RootAccess
            /// Whether root access is enabled or disabled for users of the notebook instance. The default value is
            /// Enabled.
            /// Note Lifecycle configurations need root access to be able to set up a notebook instance. Because of
            /// this, lifecycle configurations associated with a notebook instance always run with root access even
            /// if you disable root access for users.
            /// Required: No
            /// Type: String
            /// Allowed Values: Disabled | Enabled
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RootAccess { get; set; }

            /// <summary>
            /// KmsKeyId
            /// The Amazon Resource Name (ARN) of a AWS Key Management Service key that Amazon SageMaker uses to
            /// encrypt data on the storage volume attached to your notebook instance. The KMS key you provide must
            /// be enabled. For information, see Enabling and Disabling Keys in the AWS Key Management Service
            /// Developer Guide.
            /// Required: No
            /// Type: String
            /// Maximum: 2048
            /// Pattern: . *
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// VolumeSizeInGB
            /// The size, in GB, of the ML storage volume to attach to the notebook instance. The default value is 5
            /// GB.
            /// Required: No
            /// Type: Integer
            /// Minimum: 5
            /// Maximum: 16384
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> VolumeSizeInGB { get; set; }

            /// <summary>
            /// DirectInternetAccess
            /// Sets whether Amazon SageMaker provides internet access to the notebook instance. If you set this to
            /// Disabled this notebook instance will be able to access resources only in your VPC, and will not be
            /// able to connect to Amazon SageMaker training and endpoint services unless your configure a NAT
            /// Gateway in your VPC.
            /// For more information, see Notebook Instances Are Internet-Enabled by Default. You can set the value
            /// of this parameter to Disabled only if you set a value for the SubnetId parameter.
            /// Required: No
            /// Type: String
            /// Allowed Values: Disabled | Enabled
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DirectInternetAccess { get; set; }

            /// <summary>
            /// SubnetId
            /// The ID of the subnet in a VPC to which you would like to have a connectivity from your ML compute
            /// instance.
            /// Required: No
            /// Type: String
            /// Maximum: 32
            /// Pattern: [-0-9a-zA-Z]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// NotebookInstanceName
            /// The name of the new notebook instance.
            /// Required: No
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9])*
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> NotebookInstanceName { get; set; }

            /// <summary>
            /// InstanceType
            /// The type of ML compute instance to launch for the notebook instance.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: ml. c4. 2xlarge | ml. c4. 4xlarge | ml. c4. 8xlarge | ml. c4. xlarge | ml. c5.
            /// 18xlarge | ml. c5. 2xlarge | ml. c5. 4xlarge | ml. c5. 9xlarge | ml. c5. xlarge | ml. c5d. 18xlarge
            /// | ml. c5d. 2xlarge | ml. c5d. 4xlarge | ml. c5d. 9xlarge | ml. c5d. xlarge | ml. m4. 10xlarge | ml.
            /// m4. 16xlarge | ml. m4. 2xlarge | ml. m4. 4xlarge | ml. m4. xlarge | ml. m5. 12xlarge | ml. m5.
            /// 24xlarge | ml. m5. 2xlarge | ml. m5. 4xlarge | ml. m5. xlarge | ml. p2. 16xlarge | ml. p2. 8xlarge |
            /// ml. p2. xlarge | ml. p3. 16xlarge | ml. p3. 2xlarge | ml. p3. 8xlarge | ml. t2. 2xlarge | ml. t2.
            /// large | ml. t2. medium | ml. t2. xlarge | ml. t3. 2xlarge | ml. t3. large | ml. t3. medium | ml. t3.
            /// xlarge
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// LifecycleConfigName
            /// The name of a lifecycle configuration to associate with the notebook instance. For information about
            /// lifestyle configurations, see Customize a Notebook Instance in the Amazon SageMaker Developer Guide.
            /// Required: No
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9])*
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> LifecycleConfigName { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// The VPC security group IDs, in the form sg-xxxxxxxx. The security groups must be for the same VPC as
            /// specified in the subnet.
            /// Required: No
            /// Type: List of String
            /// Maximum: 5
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// RoleArn
            /// When you send any requests to AWS resources from the notebook instance, Amazon SageMaker assumes
            /// this role to perform tasks on your behalf. You must grant this role necessary permissions so Amazon
            /// SageMaker can perform these tasks. The policy must allow the Amazon SageMaker service principal
            /// (sagemaker. amazonaws. com) permissions to assume this role. For more information, see Amazon
            /// SageMaker Roles.
            /// Note To be able to pass this role to Amazon SageMaker, the caller of this API must have the
            /// iam:PassRole permission.
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: ^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,. @\-_/]+$
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// A list of key-value pairs to apply to this resource.
            /// For more information, see Resource Tag and Using Cost Allocation Tags.
            /// You can add tags later by using the CreateTags API.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::NotebookInstance";

        public NotebookInstanceProperties Properties { get; } = new NotebookInstanceProperties();

    }

	public static class NotebookInstanceAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> NotebookInstanceName = new ResourceAttribute<Union<string, IntrinsicFunction>>("NotebookInstanceName");
	}
}
