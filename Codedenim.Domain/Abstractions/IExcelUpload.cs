using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace Codedenim.Domain.Abstractions
{
    public interface IExcelUpload
    {
        string ExcelUpload(IFormFileCollection upload);
    }
}
