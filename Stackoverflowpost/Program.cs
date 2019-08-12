using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackoverflowpost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var post = new Post("Test Post", "Test Description", DateTime.Now);
                Console.WriteLine($"Votes:{post.VoteCount}");

                post.UpVote();
                post.UpVote();
                post.DownVote();

                Console.WriteLine($"Votes:{post.VoteCount}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
