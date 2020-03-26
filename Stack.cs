using System;
using System.Collections.Generic;


namespace Data_Structures_2
{
    class Stack
    {
        private List<int> elements = new List<int>();

        //push
        public void Push(int elementToPush) {
                elements.Add(elementToPush);

        }

        //pop
        public int Pop() {
            int lastIndex = elements.Count -1 ;

            int lastElement = elements[lastIndex];  //se accede igual que en arreglo

            // destroy last element
            elements.RemoveAt(lastIndex);

            return lastElement;
        }

        //top
        public int Top() {
            int lastIndex = elements.Count -1;

            int lastElement = elements[lastIndex];

            return lastElement;
        }    



        //bottom
        public int Bottom() {
            int firstIndex = 0;

            int firstElement = elements[firstIndex];

            return firstElement;
        }

        public override string ToString() {
            string stackAsString = "";

            for (int i = 0; i < elements.Count; i++)
            {
                int inverseIndex = elements.Count - i - 1;

                //Asumamos que hay una lista de 5 elementos
                //elements.Count => 5
                //i = 0
                //5 - 0 - 1 => 4

                //i = 1
                //5 - 1 - 1 => 3

                stackAsString += elements[inverseIndex];
                stackAsString += "\n";

            }
            return stackAsString;
        }
    }
}
