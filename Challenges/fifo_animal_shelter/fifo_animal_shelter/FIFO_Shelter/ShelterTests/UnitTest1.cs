using System;
using Xunit;
using FIFO_Shelter.Classes;

namespace ShelterTests
{
    public class UnitTest1
    {
        [Fact]
        public void AnimalShelterCanEnqueueDogs()
        {
            Animal dog = new Dog("Rufus");
            AnimalShelter animalShelter = new AnimalShelter();
            animalShelter.Enqueue(dog);
            Assert.Equal("Rufus", animalShelter.InQueue.Front.Value.Name);
        }
        [Fact]
        public void AnimalShelterCanEnqueueCats()
        {
            Animal cat = new Cat("Fuzzy");
            AnimalShelter animalShelter = new AnimalShelter();
            animalShelter.Enqueue(cat);
            Assert.Equal("Fuzzy", animalShelter.InQueue.Front.Value.Name);
        }
        [Fact]
        public void AnimalShelterEnqueuesInOrder()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal dog = new Dog("Rufus");
            Animal cat = new Cat("Fuzzy");
            animalShelter.Enqueue(dog);
            animalShelter.Enqueue(cat);
            Assert.Equal("Fuzzy", animalShelter.InQueue.Front.Next.Value.Name);
        }
        [Fact]
        public void AnimalShelterEnqueueDoesNotTouchOutQueue()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal dog = new Dog("Rufus");
            animalShelter.Enqueue(dog);
            Assert.Null(animalShelter.OutQueue.Front);
            Assert.Null(animalShelter.OutQueue.Rear);
        }
        [Fact]
        public void AnimalShelterDequeuesWithNoPreferenceProperly()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal dog = new Dog("Rufus");
            Animal cat = new Cat("Fuzzy");
            animalShelter.Enqueue(dog);
            animalShelter.Enqueue(cat);
            Assert.Equal("Rufus", animalShelter.Dequeue().Name);
        }
        [Fact]
        public void AnimalShelterDequeuesWithPreferenceProperly()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal dog = new Dog("Rufus");
            Animal cat = new Cat("Fuzzy");
            animalShelter.Enqueue(dog);
            animalShelter.Enqueue(cat);
            Assert.Equal("Fuzzy", animalShelter.Dequeue("Cat").Name);
        }
        [Fact]
        public void AnimalShelterDequeuesFirstAnimalOfPref()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal dog = new Dog("Rufus");
            Animal cat = new Cat("Fuzz0");
            Animal dogTwo = new Dog("Rufio");
            Animal catTwo = new Cat("Fuzzy");
            animalShelter.Enqueue(dog);
            animalShelter.Enqueue(cat);
            animalShelter.Enqueue(dogTwo);
            animalShelter.Enqueue(catTwo);
            Assert.Equal("Fuzz0", animalShelter.Dequeue("Cat").Name);
        }
        [Fact]
        public void AnimalShelterKeepsOrderAfterDequeue()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal dog = new Dog("Rufus");
            Animal cat = new Cat("Fuzz0");
            Animal dogTwo = new Dog("Rufio");
            Animal dogThree = new Dog("Fuzzy");
            animalShelter.Enqueue(dog);
            animalShelter.Enqueue(cat);
            animalShelter.Enqueue(dogTwo);
            animalShelter.Enqueue(dogThree);
            animalShelter.Dequeue("Cat");
            Assert.Equal("Rufus", animalShelter.InQueue.Front.Value.Name);
            Assert.Equal("Rufio", animalShelter.InQueue.Front.Next.Value.Name);
            Assert.Equal("Fuzzy", animalShelter.InQueue.Front.Next.Next.Value.Name);
        }
    }
}
