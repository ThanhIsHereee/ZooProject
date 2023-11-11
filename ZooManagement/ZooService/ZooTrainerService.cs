using BusinessObject.DTO.ZooTrainer;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooRepo;

namespace ZooService
{
    public class ZooTrainerService : IZooTrainerService
    {
        private ZooTrainerRepository _repository;
        public ZooTrainerService()
        {
            _repository = new ZooTrainerRepository();
        }

        public User UpdateProfile(UpdateZooTrainer update) => _repository.UpdateProfile(update);
        public List<Animal> GetAnimals() => _repository.GetAnimals();
        public Animal GetAnimalById(string id) => _repository.GetAnimalById(id);
        public Animal Add(Animal animal) => _repository.Add(animal);
        public Animal UpdateAnimal(Animal update) => _repository.UpdateAnimal(update);
        public Animal Remove(string id) => _repository.Remove(id);

        public List<AnimalSpecies> GetAnimalSpecies() => _repository.GetAnimalSpecies();
        public AnimalSpecies GetSpeciesById(string id) => _repository.GetSpeciesById(id);
        public AnimalSpecies AddSpecies(AnimalSpecies add) => _repository.AddSpecies(add);
        public AnimalSpecies RemoveSpecies(string id) => _repository.RemoveSpecies(id);
        public AnimalSpecies UpdateSpecies(AnimalSpecies update) => _repository.UpdateSpecies(update);

        public List<Food> GetAllFood() => _repository.GetAllFood();
        public Food GetFoodById(string id) => _repository.GetFoodById(id);
        public Food RemoveFood(string id) => _repository.RemoveFood(id);
        public Food CreateFood(Food food) => _repository.CreateFood(food);
        public Food UpdateFood(Food food) => _repository.UpdateFood(food);

        public List<ZooTrainerAnimal> GetAllSchedule() => _repository.GetAllSchedule();
        public ZooTrainerAnimal Checked(string id) => _repository.Checked(id);
        public ZooTrainerAnimal CreateSchedule(string userid, string animalId, string foodId, string Date) => _repository.CreateSchedule(userid, animalId, foodId, Date);         
    }
}
