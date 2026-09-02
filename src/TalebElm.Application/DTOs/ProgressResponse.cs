using System;
using System.Collections.Generic;
using System.Text;

namespace TalebElm.Application.DTOs
{
    public record ProgressResponse(Guid ModuleId, bool IsUnlocked, bool PassedExam, int Score);
}
