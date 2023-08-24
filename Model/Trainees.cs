using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueriesProject.Model
{
    public class Trainees
    {
        public int TraineesId { get; set; }

        public string TraineesName { get; set; }

        public int TrainerId { get; set; }

        public virtual Trainer Trainer { get; set; }

    }
}
