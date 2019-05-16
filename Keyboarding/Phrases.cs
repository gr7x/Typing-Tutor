using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboarding
{
    public class Phrases
    {
        private string[] sentences;
        public Phrases()
        {
            
            this.sentences = new string[10];
        }
        public string this[int p]
        {
            get {
                return sentences[p];
            }
            set { sentences[p] = value; }
        }
  
    }
    public static class Count
    {
        public static int last { get; set; }
        private static int _count = 0;
        public static int count
        {
            get { return _count; }
            set { _count = value; }
        }

        public static void plusCount(){
            // loop back around
            last = _count;
            _count = _count % 10;
            _count += 1;
            
            
        }
    }
}
