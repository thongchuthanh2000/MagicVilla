using MagicVilla_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicVilla_Web.Services.IServices
{
    public interface IBaseService
    {
        APIResponse ResponseModel { get; set; }

        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
