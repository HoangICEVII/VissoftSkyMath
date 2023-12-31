﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs;

namespace Vissoft.Core.Interfaces.IService.IAdminService
{
    public interface IAdminGradeService
    {
        Task<List<GradeDto>> GetAllGrade();
        Task CreateGrade(GradeCreateDto gradeCreateDto);
        Task DeleteGrade(int gradeId);
    }
}
