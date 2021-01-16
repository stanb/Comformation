using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.NotebookInstance
{
    /// <summary>
    /// AWS::SageMaker::NotebookInstance
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-notebookinstance.html
    /// </summary>
    public class NotebookInstanceResource : ResourceBase
    {
        public class NotebookInstanceProperties
        {
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
            /// Note Expect some interruption of service if this parameter is changed as CloudFormation stops a
            /// notebook instance and starts it up again to update it.
            /// Required: No
            /// Type: Integer
            /// Minimum: 5
            /// Maximum: 16384
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> VolumeSizeInGB { get; set; }

            /// <summary>
            /// AdditionalCodeRepositories
            /// An array of up to three Git repositories associated with the notebook instance. These can be either
            /// the names of Git repositories stored as resources in your account, or the URL of Git repositories in
            /// AWS CodeCommit or in any other Git repository. These repositories are cloned at the same level as
            /// the default repository of your notebook instance. For more information, see Associating Git
            /// Repositories with Amazon SageMaker Notebook Instances.
            /// Required: No
            /// Type: List of String
            /// Maximum: 3
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AdditionalCodeRepositories { get; set; }

            /// <summary>
            /// DefaultCodeRepository
            /// The Git repository associated with the notebook instance as its default code repository. This can be
            /// either the name of a Git repository stored as a resource in your account, or the URL of a Git
            /// repository in AWS CodeCommit or in any other Git repository. When you open a notebook instance, it
            /// opens in the directory that contains this repository. For more information, see Associating Git
            /// Repositories with Amazon SageMaker Notebook Instances.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Pattern: ^https://([^/]+)/?(. *)$|^[a-zA-Z0-9](-*[a-zA-Z0-9])*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DefaultCodeRepository { get; set; }

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
            /// Allowed values: Disabled | Enabled
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DirectInternetAccess { get; set; }

            /// <summary>
            /// AcceleratorTypes
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AcceleratorTypes { get; set; }

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
            /// RootAccess
            /// Whether root access is enabled or disabled for users of the notebook instance. The default value is
            /// Enabled.
            /// Note Lifecycle configurations need root access to be able to set up a notebook instance. Because of
            /// this, lifecycle configurations associated with a notebook instance always run with root access even
            /// if you disable root access for users.
            /// Required: No
            /// Type: String
            /// Allowed values: Disabled | Enabled
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RootAccess { get; set; }

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
            /// Note Expect some interruption of service if this parameter is changed as CloudFormation stops a
            /// notebook instance and starts it up again to update it.
            /// Required: Yes
            /// Type: String
            /// Allowed values: ml. c4. 2xlarge | ml. c4. 4xlarge | ml. c4. 8xlarge | ml. c4. xlarge | ml. c5.
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
            /// lifecycle configurations, see Customize a Notebook Instance in the Amazon SageMaker Developer Guide.
            /// Required: No
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9])*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LifecycleConfigName { get; set; }

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
