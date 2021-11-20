using System;
using System.Collections.Generic;

namespace Api.Controllers
{
    public class Match
    {
        public Pair Pair1 { get; set; }
        public Pair Pair2 { get; set; }
        public DateTime MatchDate { get; set; }
        public List<Result> Result { get; set; }
    }
}
