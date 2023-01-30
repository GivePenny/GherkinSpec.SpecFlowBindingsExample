using GherkinSpec.SpecFlowBindingsExample.Tests;
using GherkinSpec.TestModel;
using BindingAttribute = TechTalk.SpecFlow.BindingAttribute;
using GivenAttribute = TechTalk.SpecFlow.GivenAttribute;
using WhenAttribute = TechTalk.SpecFlow.WhenAttribute;
using ThenAttribute = TechTalk.SpecFlow.ThenAttribute;

[assembly: BindingTypes(
    typeof(BindingAttribute),
    typeof(GivenAttribute),
    typeof(WhenAttribute),
    typeof(ThenAttribute),
    typeof(SpecFlowStepAttributeMatchExpressionSelector))]