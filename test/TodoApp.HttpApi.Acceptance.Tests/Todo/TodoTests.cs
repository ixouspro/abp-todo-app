//using System.Threading.Tasks;
//using Shouldly;
//using TodoApp.Controllers;
//using TodoApp.Todo;
//using Xunit;

//namespace TodoApp.Pages;

//[Collection(TodoAppTestConsts.CollectionDefinitionName)]
//public class TodoTests : TodoAppHttpApiAcceptanceTestBase
//{
//    [Fact]
//    public async Task CreateTest()
//    {
//        try
//        {
//            var todoAppService = GetRequiredService<TodoAppAppService>();


//            var createUrl = GetUrl<TodoAppAppService>(nameof(TodoAppService.GetListAsync));
//            var response = await GetResponseAsync(createUrl);

//            response.EnsureSuccessStatusCode();
//            //var content = await 

//            //response.ShouldNotBeNull();
//            //response.Content.ShouldNotBeNull();
//            //response.Content.
//        }
//        catch (System.Exception ex)
//        {

//            throw;
//        }
//    }
//}
