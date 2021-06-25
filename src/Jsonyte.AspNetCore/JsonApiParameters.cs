using Jsonyte.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;

namespace Jsonyte.AspNetCore
{
    [ModelBinder(typeof(JsonApiParametersModelBinder))]
    public class JsonApiParameters
    {
        
    }
}
