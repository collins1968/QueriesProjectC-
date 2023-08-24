using QueriesProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueriesProject
{
    public class Queries
    {
        private MyDbContext context = new MyDbContext();
        public void AddTrainer()
        {
            var newTrainer = new Trainer[]
            {
                new Trainer(){TrainerName = "Trainer 1"},
                new Trainer(){TrainerName = "Trainer 2"},
                new Trainer(){TrainerName = "Trainer 3"},
                new Trainer(){TrainerName = "Trainer 4"},
                new Trainer(){TrainerName = "Trainer 5"},
                new Trainer(){TrainerName = "Trainer 6"},
                new Trainer(){TrainerName = "Trainer 7"},
            };
                context.Trainers.AddRange(newTrainer);
                context.SaveChanges();
        }
        public void getAllTrainers()
        {
            var trainers = context.Trainers.ToList();
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.TrainerId}: {trainer.TrainerName}");
            }
        }

        public void getTrainer() {
            Console.WriteLine( "input the id of the user you want to retreive:");
            var TrainerId = Convert.ToInt32(Console.ReadLine());
             var trainer = context.Trainers.Where(t => t.TrainerId == TrainerId).FirstOrDefault();
            if (trainer != null) { 
                Console.WriteLine($"{trainer.TrainerId}: {trainer.TrainerName}");
            }
            else
            {
                Console.WriteLine("That user is not available in the database");
            }  
        }

        public void deleteTainer()
        {
            Console.WriteLine("enter the id of the user you want to delete:");
            var TrainerId = Convert.ToInt32(Console.ReadLine());
            var trainer = context.Trainers.Where(t => t.TrainerId == TrainerId).FirstOrDefault();
            if(trainer != null)
            {
                context.Trainers.Remove(trainer);
                context.SaveChanges();
                Console.WriteLine("user deleted successfully");
            }
            else
            {
                Console.WriteLine("That user is not available in the database");
            }
        }

        public void updateTrainer()
        {
            Console.WriteLine("input the id of the user you want to update:");
            var TrainerId = Convert.ToInt32(Console.ReadLine());
            var trainer = context.Trainers.Where(t => t.TrainerId == TrainerId).FirstOrDefault();
            if (trainer != null)
            {
                Console.WriteLine("input the new name of the user:");
                var TrainerName = Console.ReadLine();
                trainer.TrainerName = TrainerName;
                context.SaveChanges();
                Console.WriteLine("user updated successfully");
            }
            else
            {
                Console.WriteLine("That user is not available in the database");
            }

    }
        }
    }


