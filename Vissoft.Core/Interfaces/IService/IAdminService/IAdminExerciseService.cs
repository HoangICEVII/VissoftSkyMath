using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.Exercise;

namespace Vissoft.Core.Interfaces.IService.IAdminService
{
    public interface IAdminExerciseService
    {
        Task<List<ExerciseDTO>> ReadAllExerciseByLessonId(int lessonId);
        Task<ExerciseDTO> ReadById(int id);
        Task CreateExercise(int lessonId, ExerciseCreateDTO obj);
        Task UpdateExercise(int id, ExerciseUpdateDTO obj);
        Task DeleteExercise(int id);
    }
}

