using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.CommonModels;

namespace RyderDemo_SpecFlow.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Console.WriteLine($"{nameof(GivenTheFirstNumberIs)} : {number}");
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method.

            //throw new PendingStepException();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Console.WriteLine($"{nameof(GivenTheSecondNumberIs)} : {number}");

            //TODO: implement arrange (precondition) logic

            //throw new PendingStepException();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreAdded)}");

            //TODO: implement act (action) logic

            //throw new PendingStepException();
        }

        [Then(@"the result should ""([^""]*)""")]
        public void ThenTheResultShould(string result)
        {
            Console.WriteLine($"{nameof(ThenTheResultShould)} : {result}");
            //throw new PendingStepException();
        }


        //[Then("the result should be (.*)")]
        //public void ThenTheResultShouldBe(int result)
        //{
        //    //TODO: implement assert (verification) logic

        //    //throw new PendingStepException();
        //}
        [Given(@"I input following numbers to the calculator")]
        public void GivenIInputFollowingNumbersToTheCalculator(Table table)
        {
            //var datas = table.CreateSet<Calculation>();
            ////var datas = table.CreateInstance<Calculation>();
            //foreach (var item in datas)
            //{
            //    Console.WriteLine($"The number is {item.Numbers}"); 
            //}
            ////throw new PendingStepException();
            ///

            dynamic datas = table.CreateDynamicSet();

            foreach (var item in datas)
            {
                Console.WriteLine($"The numbers are {item.Numbers}");
            }

        }

        [Then(@"I see the result and few more details")]
        public void ThenISeeTheResultAndFewMoreDetails(Table table)
        {
            //throw new PendingStepException();
            dynamic data = table.CreateDynamicInstance();

            Console.WriteLine($"The Result is going to hold the Value {data.Results} with logo {data.Logo}");
        }


    }

    //public record Calculation
    //{
    //    public int Numbers { get; set; }
    //}
}