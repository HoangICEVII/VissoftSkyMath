using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vissoft.Core.DTOs.Matching
{
    public class MatchingDTO
    {
        public int Id { get; set; }
        public string MatchingASide { get; set; } = string.Empty;
        public string MatchingBSide { get; set; } = string.Empty;
        public int QuizId { get; set; }
    }
}
