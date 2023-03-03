using AutoMapper;
using CustomsAttire.Core.Domain.Models;
using CustomsAttire.Core.Data;
using FluentValidation;
namespace CustomsAttire.API.Controllers
{
    public class EmployeeController : EntityControllerBase<CustomsAttire.Core.Data.Entities.Employee, EmployeeReadModel, EmployeeCreateModel, EmployeeUpdateModel>
    {
        public EmployeeController(CustomsAttire.Core.Data.CustomsAttireContext dataContext, IMapper mapper, IValidator<EmployeeCreateModel> createValidator, IValidator<EmployeeUpdateModel> updateValidator) : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
