using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class Shure : Microphone
    {
        public int FrequencyResponseLow { get; set; }
        public int FrequencyResponseHigh { get; set; }
    }
}