using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleQuiz.Models
{
    public class Question
    {
        public string Title { get; set; }
        public string CorrectAnswer { get; set; }
        public Image? Picture { get; set; }
    }
}
