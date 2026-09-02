using System;
using System.Collections.Generic;
using System.Text;

namespace TalebElm.Application.DTOs
{
    public record CreateExamRequest(Guid ModuleId, string Title, int PassThreshold);
}
