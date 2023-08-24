using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueriesProject.Model
{
    public class Trainer
    {
        public Trainer()
        {
            this.Trainees = new HashSet<Trainees>();
        }

        public int TrainerId { get; set; }

        public string TrainerName { get; set; }

        public virtual ICollection<Trainees> Trainees { get; set; }


    }
}
