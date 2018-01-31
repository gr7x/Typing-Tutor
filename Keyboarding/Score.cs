using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboarding
{
    public class Score
    {
        public Score()
        {
            _score = 0;
        }
        double _score;
        public double score
        {
            get { return this._score; }
            set { this._score = value; }
        }
        public void addToScore(double points)
        {
            score += points;
        }
    }
}
