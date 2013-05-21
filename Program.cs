using GitSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log2Clip
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var repo = new Repository(@".");
            var sb = new StringBuilder();
            //sb.AppendLine(repo.CurrentBranch.CurrentCommit.Message);
            foreach (var commit in repo.CurrentBranch.CurrentCommit.Ancestors)
            {
                sb.Append(commit.Message);
            }

            Console.WriteLine(sb.ToString());
            Clipboard.SetText(sb.ToString());
        }
    }
}
