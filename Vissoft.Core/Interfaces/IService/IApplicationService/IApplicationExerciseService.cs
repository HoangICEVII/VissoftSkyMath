using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.Exercise;

namespace Vissoft.Core.Interfaces.IService.IApplicationService
{
    public interface IApplicationExerciseService
    {
        Task<List<ExerciseDTO>> ReadAllExerciseByLessonId(int lessonId);
        Task<ExerciseDTO> ReadById(int id);
    }
}
