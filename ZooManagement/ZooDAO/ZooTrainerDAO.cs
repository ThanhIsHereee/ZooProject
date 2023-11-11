using BusinessObject.DTO.ZooTrainer;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZooDAO
{
    public class ZooTrainerDAO
    {
        private static ZooTrainerDAO instance = null;
        private readonly PRN211_ZOOContext _context;
        private ZooTrainerDAO()
        {
            _context = new PRN211_ZOOContext();
        }
        public static ZooTrainerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ZooTrainerDAO();
                }
                return instance;
            }
        }

        public User UpdateProfile(UpdateZooTrainer update)
        {
            var foundUpdate = this._context.User.Where(x => x.UserId.Equals(update.UserId)).FirstOrDefault();
            if (foundUpdate == null)
                return null;
            foundUpdate.Fullname = update.Fullname ?? foundUpdate.Fullname;
            foundUpdate.Username = update.Username ?? foundUpdate.Username;
            foundUpdate.Pasword = update.Password ?? foundUpdate.Pasword;
            foundUpdate.Phonenumber = update.Phonenumber ?? foundUpdate.Phonenumber;
            foundUpdate.Address = update.Address ?? foundUpdate.Address;
            foundUpdate.Experience = update.Experience ?? foundUpdate.Experience;
            this._context.User.Update(foundUpdate);
            this._context.SaveChangesAsync();
            return foundUpdate;
        }

        //animal
        public List<Animal> GetAll()
        {
            var list = this._context.Animal.AsNoTracking().Select(a => new Animal
            {
                AnimailId = a.AnimailId,
                AnimalName = a.AnimalName,
                AnimalGender = a.AnimalGender,
                AnimalDob = a.AnimalDob,
                AnimalDescription = a.AnimalDescription,
                AnimalSpeciesId = a.AnimalSpeciesId,
                FoodId = a.FoodId
            }).ToList();
            return list;
        }

        public Animal Add(Animal add)
        {
            var db = new PRN211_ZOOContext();
            db.Animal.Add(add);
            db.SaveChanges();
            return add;
        }

        public Animal Remove(string id)
        {
            var db = new PRN211_ZOOContext();
            var animal = db.Animal.AsNoTracking().Where(x => x.AnimailId.Equals(id)).FirstOrDefault();
            db.Animal.Remove(animal);
            db.SaveChanges();
            return animal;
        }

        public Animal GetById(string id) => this._context.Animal.AsNoTracking().Where(x => x.AnimailId.Equals(id)).FirstOrDefault();

        public Animal UpdateAnimal(Animal update)
        {
            var db = new PRN211_ZOOContext();
            db.Animal.Update(update);
            db.SaveChanges();
            return update;
        }
        //species
        public List<AnimalSpecies> GetAllSpecies() => _context.AnimalSpecies.AsNoTracking().ToList();
        public AnimalSpecies GetSpeciesById(string id)
        {
            return this._context.AnimalSpecies.AsNoTracking().Where(x => x.AnimalSpeciesId.Equals(id)).FirstOrDefault();
        }
        public AnimalSpecies AddSpecies(AnimalSpecies add)
        {
            var db = new PRN211_ZOOContext();
            db.AnimalSpecies.Add(add);
            db.SaveChanges();
            return add;
        }
        public AnimalSpecies RemoveSpecies(string id)
        {
            var db = new PRN211_ZOOContext();
            var animal = db.AnimalSpecies.AsNoTracking().Where(x => x.AnimalSpeciesId.Equals(id)).FirstOrDefault();
            db.AnimalSpecies.Remove(animal);
            db.SaveChanges();
            return animal;
        }
        public AnimalSpecies UpdateSpecies(AnimalSpecies update)
        {
            var db = new PRN211_ZOOContext();
            db.AnimalSpecies.Update(update);
            //this._context.AnimalSpecies.Attach(update);
            //this._context.Entry(update).State = EntityState.Modified;
            db.SaveChanges();
            return update;
        }

        //food
        public List<Food> GetAllFood() => this._context.Food.ToList();
        public Food GetFoodById(string id) => this._context.Food.Where(x => x.FoodId.Equals(id)).FirstOrDefault();
        public Food RemoveFood(string id)
        {
            var db = new PRN211_ZOOContext();
            var foundRemove = db.Food.Where(x => x.FoodId.Equals(id)).FirstOrDefault();
            if (foundRemove != null)
            {
                db.Food.Remove(foundRemove);
                db.SaveChanges();
                return foundRemove;
            }
            return null;
        }
        public Food CreateFood(Food food)
        {
            var db = new PRN211_ZOOContext();
            if (food != null)
            {
                db.Food.Add(food);
                db.SaveChanges();
                return food;
            }
            return null;
        }
        public Food UpdateFood(Food food)
        {
            var db = new PRN211_ZOOContext();
            db.Food.Update(food);
            db.SaveChanges();
            return food;
        }

        //feed schedule 
        public List<ZooTrainerAnimal> GetAllSchedule()
        {
            var db = new PRN211_ZOOContext();
            return db.ZooTrainerAnimal.Include(x => x.User).ToList();

        }
        public ZooTrainerAnimal Checked(string id)
        {
            var db = new PRN211_ZOOContext();
            var found = db.ZooTrainerAnimal.Where(x => x.Id.Equals(id)).FirstOrDefault();
            if(found != null)
            {
                found.Status = "Have Feed";
                db.ZooTrainerAnimal.Update(found);
                db.SaveChanges();
                return found;
            }
            return null;
        }
        public ZooTrainerAnimal CreateSchedule(string userid, string animalId, string foodId, string Date)
        {
            var add = new ZooTrainerAnimal();
            var db = new PRN211_ZOOContext();
            add.Id = Guid.NewGuid().ToString().Substring(0, 1);
            add.UserId = userid;
            add.AnimalId = animalId;
            add.FoodId = foodId; 
            add.Date = Date;
            add.Status = "Have not feed";
            db.ZooTrainerAnimal.Add(add);
            db.SaveChanges();
            return add;
        }
    }
}
