using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Jsonyte.AspNetCore.Mvc.ApplicationModels
{
    public class JsonApiModelConvention : IApplicationModelConvention
    {
        public void Apply(ApplicationModel application)
        {
            foreach (var controller in application.Controllers)
            {
                var name = controller.ControllerName;
            }
        }
    }
}
