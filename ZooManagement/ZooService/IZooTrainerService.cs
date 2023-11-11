using BusinessObject.DTO.ZooTrainer;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooService
{
    public interface IZooTrainerService
    {
        public User UpdateProfile(UpdateZooTrainer update);
        //animal
        public List<Animal> GetAnimals();
        public Animal GetAnimalById(string id);
        public Animal Add(Animal animal);
        public Animal UpdateAnimal(Animal update);
        public Animal Remove(string id);
        //species
        public List<AnimalSpecies> GetAnimalSpecies();
        public AnimalSpecies GetSpeciesById(string id);
        public AnimalSpecies AddSpecies(AnimalSpecies add);
        public AnimalSpecies RemoveSpecies(string id);
        public AnimalSpecies UpdateSpecies(AnimalSpecies update);
        //food
        public List<Food> GetAllFood();
        public Food GetFoodById(string id);
        public Food RemoveFood(string id);
        public Food CreateFood(Food food);
        public Food UpdateFood(Food food);

        public List<ZooTrainerAnimal> GetAllSchedule();
        public ZooTrainerAnimal Checked(string id);
        public ZooTrainerAnimal CreateSchedule(string userid, string animalId, string foodId, string Date);
    }
}
