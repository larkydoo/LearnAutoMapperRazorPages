using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;

namespace LearnAutoMapper.Pages
{
    public abstract class BasePageModel : PageModel
    {

        private IMapper _mapper;

        public IMappingExpression _createMap;

        protected IMapper Mapper => _mapper ?? (_mapper = HttpContext.RequestServices.GetService<IMapper>());
        protected IMappingExpression CreateMap => _createMap ?? (_createMap = HttpContext.RequestServices.GetService<IMappingExpression>());
    }
}
