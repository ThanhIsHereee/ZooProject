using BusinessObject.DTO.ZooTrainer;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooDAO;

namespace ZooRepo
{
    public class ZooTrainerRepository : IZooTrainerRepository
    {
        public User UpdateProfile(UpdateZooTrainer update) => ZooTrainerDAO.Instance.UpdateProfile(update);
        public List<Animal> GetAnimals() => ZooTrainerDAO.Instance.GetAll();
        public Animal GetAnimalById(string id) => ZooTrainerDAO.Instance.GetById(id);
        public Animal Add(Animal animal) => ZooTrainerDAO.Instance.Add(animal);
        public Animal UpdateAnimal(Animal update) => ZooTrainerDAO.Instance.UpdateAnimal(update);
        public Animal Remove(string id) => ZooTrainerDAO.Instance.Remove(id);

        public List<AnimalSpecies> GetAnimalSpecies() => ZooTrainerDAO.Instance.GetAllSpecies();
        public AnimalSpecies GetSpeciesById(string id) => ZooTrainerDAO.Instance.GetSpeciesById(id);
        public AnimalSpecies AddSpecies(AnimalSpecies add) => ZooTrainerDAO.Instance.AddSpecies(add);
        public AnimalSpecies RemoveSpecies(string id) => ZooTrainerDAO.Instance.RemoveSpecies(id);
        public AnimalSpecies UpdateSpecies(AnimalSpecies update) => ZooTrainerDAO.Instance.UpdateSpecies(update);

        public List<Food> GetAllFood() => ZooTrainerDAO.Instance.GetAllFood();
        public Food GetFoodById(string id) => ZooTrainerDAO.Instance.GetFoodById(id);
        public Food RemoveFood(string id) => ZooTrainerDAO.Instance.RemoveFood(id);
        public Food CreateFood(Food food) => ZooTrainerDAO.Instance.CreateFood(food);
        public Food UpdateFood(Food food) => ZooTrainerDAO.Instance.UpdateFood(food);

        public List<ZooTrainerAnimal> GetAllSchedule() => ZooTrainerDAO.Instance.GetAllSchedule();
        public ZooTrainerAnimal Checked(string id) => ZooTrainerDAO.Instance.Checked(id);
        public ZooTrainerAnimal CreateSchedule(string userid, string animalId, string foodId, string Date) => ZooTrainerDAO.Instance.CreateSchedule(userid, animalId, foodId, Date);

    }
}
