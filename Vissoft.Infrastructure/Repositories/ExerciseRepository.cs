using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.Exercise;
using Vissoft.Core.DTOs.QuizType;
using Vissoft.Core.Entities.SkyMathEntities;
using Vissoft.Core.Entities.SkyMathEntities.RelationalEntities;
using Vissoft.Core.Helper;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Infrastructure.Data;

namespace Vissoft.Infrastructure.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly VissoftDatabaseContext _dbContext;
        private readonly IMapper _mapper; 
        public ExerciseRepository(VissoftDatabaseContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task CreateExercise(int lessonId, ExerciseCreateDTO obj)
        {
            try
            {
                Exercise exercise = new Exercise()
                {
                    Name = obj.Name,
                    LessonId = lessonId,
                };
                await _dbContext.Exercises.AddAsync(exercise);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task DeleteExercise(int id)
        {
            try
            {
                Exercise? exercise = await _dbContext.Exercises.FindAsync(id);
                if (exercise == null)
                {
                    throw new CustomException("Found nothing to delete", 404);
                }
                _dbContext.Exercises.Remove(exercise);
                await _dbContext.SaveChangesAsync();
            }
            catch (CustomException e)
            {
                throw new CustomException(e.Message, e.StatusCode);
            }
            catch (Exception)
            {
                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task<List<ExerciseDTO>> ReadAllExerciseByLessonId(int lessonId)
        {
            try
            {
                return _mapper.Map<List<ExerciseDTO>>(await _dbContext.Exercises.Where(x => x.LessonId == lessonId).ToListAsync());
            }
            catch (Exception)
            {

                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task<ExerciseDTO> ReadById(int id)
        {
            try
            {
                Exercise? exercise = await _dbContext.Exercises.FindAsync(id);
                if (exercise == null)
                {
                    throw new CustomException("Found nothing", 404);
                }
                return _mapper.Map<ExerciseDTO>(exercise);
            }
            catch (CustomException e)
            {
                throw new CustomException(e.Message, e.StatusCode);
            }
            catch (Exception)
            {

                throw new CustomException("An error occurred", 500);
            }
        }

        public async Task UpdateExercise(int id, ExerciseUpdateDTO obj)
        {
            try
            {
                Exercise? exercise = await _dbContext.Exercises.FindAsync(id);
                if (exercise == null)
                {
                    throw new CustomException("Found nothing to update", 404);
                }
                exercise.Name = obj.Name;
                _dbContext.Exercises.Update(exercise);
                await _dbContext.SaveChangesAsync();
            }
            catch (CustomException e)
            {
                throw new CustomException(e.Message, e.StatusCode);
            }
            catch (Exception)
            {
                throw new CustomException("An error occurred", 500);
            }
        }
    }
}
