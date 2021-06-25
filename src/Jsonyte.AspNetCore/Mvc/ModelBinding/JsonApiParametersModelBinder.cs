using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Jsonyte.AspNetCore.Mvc.ModelBinding
{
    public class JsonApiParametersModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var query = bindingContext.ValueProvider.GetValue("includes");

            bindingContext.Result = ModelBindingResult.Success(new JsonApiParametersModelBinder());

            return Task.CompletedTask;
        }
    }
}
