using System.Collections.Generic;
using Amazon;
using Amazon.CloudFormation.Model;
using Comformation.IntrinsicFunctions;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Comformation.Tests
{
    public class FnShould
    {
        [Fact]
        public void CreateBase64()
        {
            var target = Fn.Base64("some text");
            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{\"Fn::Base64\": \"some text\"}");
            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void CreateCidr()
        {
            var target = Fn.Cidr("some value", Fn.Ref("count"), Fn.Ref("maskSizeForIPv6"));

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{\"Fn::Cidr\": [\"some value\", { \"Ref\": \"count\" }, { \"Ref\": \"maskSizeForIPv6\" } ] }");

            Assert.True(JToken.DeepEquals(actual, expected));
        }
        
        [Fact]
        public void CreateFindInMap()
        {
            var target = Fn.FindInMap("RegionMap", Fn.Ref(PseudoParameter.Region), "32");

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{ \"Fn::FindInMap\" : [ \"RegionMap\", { \"Ref\" : \"AWS::Region\" }, \"32\"]}");

            Assert.True(JToken.DeepEquals(actual, expected));
        }


        [Fact]
        public void CreateGetAtt1()
        {
            var target = Fn.GetAtt("myELB", ElasticLoadBalancing.LoadBalancer.LoadBalancerAttributes.SourceSecurityGroup_GroupName);
            
            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{\"Fn::GetAtt\": [ \"myELB\", \"SourceSecurityGroup\", \"GroupName\" ] }");
            
            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void CreateGetAtt2()
        {
            var target = Fn.GetAtt("myELB", Fn.Ref("DNSName"));

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{\"Fn::GetAtt\": [ \"myELB\", {\"Ref\": \"DNSName\"} ] }");
            
            Assert.True(JToken.DeepEquals(actual, expected));
        }
        
        [Fact]
        public void CreateGetAZs1()
        {
            var target = Fn.GetAZs(Fn.Ref(PseudoParameter.Region));

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{\"Fn::GetAZs\": {\"Ref\": \"AWS::Region\"} }");
            
            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void CreateGetAZs2()
        {
            var target = Fn.GetAZs("us-east-1");

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{\"Fn::GetAZs\": \"us-east-1\" }");
            
            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void CreateGetAZs3()
        {
            var target = Fn.GetAZs(RegionEndpoint.USEast1);

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{\"Fn::GetAZs\": \"us-east-1\" }");
            
            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void CreateGetAZs4()
        {
            var target = Fn.GetAZs();

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{\"Fn::GetAZs\": \"\" }");
            
            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void CreateImportValue()
        {
            var target = Fn.ImportValue(Fn.Sub("${NetworkStackNameParameter}-SecurityGroupID"));

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{\"Fn::ImportValue\" : {\"Fn::Sub\" : \"${NetworkStackNameParameter}-SecurityGroupID\"}}");
            
            Assert.True(JToken.DeepEquals(actual, expected));
        }
        
        [Fact]
        public void CreateJoin1()
        {
            var target = Fn.Join(":", new Union<string, IntrinsicFunction> [] {"a", "b", "c"});

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{\"Fn::Join\" : [ \":\", [ \"a\", \"b\", \"c\" ] ]}");
            
            Assert.True(JToken.DeepEquals(actual, expected));
        }
        
        [Fact]
        public void CreateJoin2()
        {
            var target = Fn.Join("",
                // TODO: Find a way to simplify it
                new Union<string, IntrinsicFunction> []
                {
                    "arn:", 
                    Fn.Ref("Partition"), 
                    ":s3:::elasticbeanstalk-*-", 
                    Fn.Ref(PseudoParameter.AccountId)
                });

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{\"Fn::Join\": [\"\", [\"arn:\",{\"Ref\": \"Partition\"},\":s3:::elasticbeanstalk-*-\",{\"Ref\": \"AWS::AccountId\"}]]}");
            
            Assert.True(JToken.DeepEquals(actual, expected));
        }

        
        [Fact]
        public void CreateSelect1()
        {
            var target = Fn.Select("1", new [] {"apples", "grapes", "oranges", "mangoes"});

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{ \"Fn::Select\" : [ \"1\", [ \"apples\", \"grapes\", \"oranges\", \"mangoes\" ] ] }");

            Assert.True(JToken.DeepEquals(actual, expected));
        }
        
        [Fact]
        public void CreateSelect2()
        {
            var target = Fn.Select("0", Fn.Ref("DbSubnetIpBlocks"));

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{ \"Fn::Select\" : [ \"0\", {\"Ref\": \"DbSubnetIpBlocks\"} ] }");

            Assert.True(JToken.DeepEquals(actual, expected));
        }
        
        [Fact]
        public void CreateSelect3()
        {
            var target = Fn.Select(Fn.Ref("Index"), Fn.Ref("DbSubnetIpBlocks"));

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{ \"Fn::Select\" : [ {\"Ref\": \"Index\"}, {\"Ref\": \"DbSubnetIpBlocks\"} ] }");

            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void CreateSplit1()
        {
            var target = Fn.Split("|", "a|b|c");

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{ \"Fn::Split\" : [ \"|\" , \"a|b|c\" ] }");

            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void CreateSplit2()
        {
            var target = Fn.Split(",", Fn.Ref("CommaDelimitedParam"));

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{ \"Fn::Split\" : [ \",\" , { \"Ref\": \"CommaDelimitedParam\"} ] }");

            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void CreateSub1()
        {
            var target = Fn.Sub("arn:aws:ec2:${AWS::Region}:${AWS::AccountId}:vpc/${vpc}");

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{ \"Fn::Sub\": \"arn:aws:ec2:${AWS::Region}:${AWS::AccountId}:vpc/${vpc}\" }");

            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void CreateSub2()
        {
            var target = Fn.Sub("www.${Domain}", new Sub.Item("Domain", Fn.Ref("RootDomainName")));

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{ \"Fn::Sub\": [ \"www.${Domain}\", { \"Domain\": {\"Ref\" : \"RootDomainName\" }} ]}");

            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void CreateRef()
        {
            var target = Fn.Ref("MyVPC");

            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{\"Ref\": \"MyVPC\"}");

            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void CreateAnd()
        {
            var target = Fn.And(
                Fn.Equals("sg-mysggroup", Fn.Ref("ASecurityGroup")),
                new ConditionRef {Condition = "SomeOtherCondition"});
            
            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{\"Fn::And\": [{\"Fn::Equals\": [\"sg-mysggroup\", {\"Ref\": \"ASecurityGroup\"}]},{\"Condition\": \"SomeOtherCondition\"}]}");

            Assert.True(JToken.DeepEquals(actual, expected));
        }

        [Fact]
        public void CreateIf()
        {
            var target = Fn.If("CreateNewSecurityGroup", Fn.Ref("NewSecurityGroup"), Fn.Ref("ExistingSecurityGroup"));
            
            var actual = JToken.FromObject(target);
            var expected = JToken.Parse("{\"Fn::If\":[\"CreateNewSecurityGroup\",{\"Ref\" : \"NewSecurityGroup\"},{\"Ref\" : \"ExistingSecurityGroup\"}]}");
            
            Assert.True(JToken.DeepEquals(actual, expected));
        }
    }
}
