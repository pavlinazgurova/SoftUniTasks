using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            var lists = Console.ReadLine().
                Split(new char[] { '|'}, StringSplitOptions.RemoveEmptyEntries).                
                ToList();
            var newList = new List<string>();
            var n = lists.Count;
            lists.Reverse();
            
            for (int i = 0; i < n; i++)
            {
                newList.Add(lists[i].Trim());
                //List<String> temp = lists[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                //foreach (var item in temp)
                //{
                //    newList.Add(item);
                //}
            }
            Console.WriteLine(string.Join(" ",newList));
        }
    }
}
