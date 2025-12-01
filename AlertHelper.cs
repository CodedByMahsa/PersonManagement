using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagerDGV
{
    internal static class AlertHelper
    {
        public static DialogResult ShowQuestion(string message) 
        {
            return MessageBox.Show(message,"توجه ؟",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        public static DialogResult ShowError(string message)
        {
            return MessageBox.Show(message, "توجه ؟", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
