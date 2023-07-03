using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Shelter
    {
        

        public List<Pet> Pets;

        
        public Shelter()
        {
            Pets = new List<Pet>();
        }

        public void AddPet(Pet pet)
        {
            Pets.Add(pet);
            Console.WriteLine("Your  " + pet.Species + ", " + pet.Name + " has been added to the shelter");
            Console.ReadLine();
        }
        public void AddPet1(Pet robot)
        {
            Pets.Add(robot);
            Console.WriteLine("Your  " + robot.Species + ", " + robot.Name + " has been added to the shelter");
            Console.ReadLine();
        }

        public void RemovePet(Pet pet)
        {
            Pets.Remove( pet);
            Console.WriteLine("Your  " + pet.Species + ", " + pet.Name + " has been removed from the shelter");
            Console.ReadLine();
        }

        public void FeedAllPets()
        {
            foreach (Pet pet in Pets)
            {
                pet.Feed();
            }
        }

        public void PlayWithAllPets()
        {
            foreach (Pet pet in Pets)
            {
                pet.PlayWithPet();
            }
        }

        public void TakeAllPetsToDoctor()
        {
            foreach (Pet pet in Pets)
            {
                pet.TakePetToVet();
            }
        }

        public void PrintAllPets()
        {
            foreach (Pet pet in Pets)
            {
                Console.WriteLine("Name: " + pet.Name);
                Console.WriteLine("Species: " + pet.Species);

            }
            Console.ReadLine();
        }
        public static void GetAllAnimalsInfo(List<Pet> pets)
        {

            Console.WriteLine("Please choose a pet to view the info for");
            int counter = 1;

            foreach (Pet i in pets)
            {
                Console.WriteLine(counter + ": " + i.Name);
                counter++;
            }

            int userChosenIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine(pets[userChosenIndex].Name + " " + pets[userChosenIndex].Species);
        }
        public void PrintAllPetsStatus()
        {
            Console.WriteLine("Status of All Pets:");
            foreach (var pet in Pets)
            {
                Console.WriteLine("--------------------------");
                pet.PetStats2();
            }
        }



    }
}
