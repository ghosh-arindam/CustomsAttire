using AutoMapper;
using CustomsAttire.Core.Domain.Models;
using CustomsAttire.Core.Data;
using FluentValidation;
namespace CustomsAttire.API.Controllers
{
    public class POSReportController : EntityControllerBase<CustomsAttire.Core.Data.Entities.POSReport, POSReportReadModel, POSReportCreateModel, POSReportUpdateModel>
    {
        public POSReportController(CustomsAttire.Core.Data.CustomsAttireContext dataContext, IMapper mapper, IValidator<POSReportCreateModel> createValidator, IValidator<POSReportUpdateModel> updateValidator) : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
