using System;
using System.Collections.Generic;
using System.Text;

namespace FIFO_Shelter.Classes
{
    class AnimalShelter
    {
        public Queue<Animal> InQueue;
        public Queue<Animal> OutQueue;

        /// <summary>
        /// Enqueues an animal into the InQueue, which is the "main" queue of the AnimalShelter. All animals here are kept in a first-come, first-removed basis - this order is kept during the selective dequeue process through the use of the helper queue OutQueue.
        /// </summary>
        /// <param name="animal"></param>
        public void Enqueue(Animal animal)
        {
            if(animal.Type != "Cat" && animal.Type != "Dog")
            {
                return;
            }
            InQueue.Enqueue(animal);
        }

        /// <summary>
        /// "Stretch" goal - if there are any animals in the shelter and no preference is given, dequeue the oldest animal in there - since we're keeping our FIFO property with how we cycle through InQueue and OutQueue, that will always be the front-most animal in the InQueue.
        /// </summary>
        /// <returns>The first animal in the shelter, or null if there are no animals in the shelter.</returns>
        public Animal Dequeue()
        {
            if(InQueue.Peek() == null)
            {
                return null;
            }
            return InQueue.Dequeue();
        }

        /// <summary>
        /// Given a preference of Animal type, dequeues and returns the first Animal in the animal shelter of the preferred type without disrupting the order of the other animals.
        /// </summary>
        /// <param name="pref">The type of animal to be dequeued - must be either "Dog" or "Cat"</param>
        /// <returns>The first animal of type pref found, or null</returns>
        public Animal Dequeue(string pref)
        {
            //If the preference isn't a dog or cat, turn the request away
            if (pref != "Cat" && pref != "Dog")
            {
                return null;
            }
            //Else, dequeue animals from the InQueue into the OutQueue until we either hit the end of the InQueue or we find an animal whose type matches the preference
            while(InQueue.Peek() != null && InQueue.Peek().Type != pref)
            {
                OutQueue.Enqueue(InQueue.Dequeue());
            }
            //Assume the worst case - the above while exited because the InQueue is now empty (no animals of Type pref found)
            Animal adoptedAnimal = null;
            //If the queue is not empty, then the first while loop exited because we found a valid match - dequeue from the InQueue and save it in the temporary animal variable 
            if(InQueue.Peek() != null)
            {
                adoptedAnimal = InQueue.Dequeue();
            }
            //If there's any animals left in the InQueue after the found animal has been dequeued, also shift them into the OutQueue
            while (InQueue.Peek() != null)
            {
                OutQueue.Enqueue(InQueue.Dequeue());
            }
            //Return all animals to the OutQueue in order to keep order correct when new animals are enqueued
            while (OutQueue.Peek() != null)
            {
                InQueue.Enqueue(OutQueue.Dequeue());
            }
            return adoptedAnimal;
        }
    }
}
