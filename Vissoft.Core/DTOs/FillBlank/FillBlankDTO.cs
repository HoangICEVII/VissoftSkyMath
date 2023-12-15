using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.DTOs.FillBlank
{
    public class FillBlankDTO
    {
        public int Id { get; set; }
        public string FillBackAnswer { get; set; } = string.Empty;
        public int QuizId { get; set; }
    }
}
