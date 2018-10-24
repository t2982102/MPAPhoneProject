using System.Collections.Generic;
using MPAPhoneProject.Roles.Dto;

namespace MPAPhoneProject.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}