using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_8__7_18
{
    class CapacityList
    {
        private const int InitialCapacity = 2;
        private Pair[] items;
        private int startIndex = 0; //показва първият индекс, от който започваме да сумираме текущите елементи
        private int nextIndex = 0; //показва поредният индекс, на който можем да поставим елемент
        private  int count = -1;


        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];

        }



        public int Count
        {

            get;

            private set;

        }



        public Pair SumIntervalPairs(Pair firstColor, int i)
        {

            Pair newColor = new Pair(0,0);
            newColor.First = firstColor.First + items[i].First;
            newColor.Last = firstColor.Last + items[i].Last;
            return newColor;

        }

        public Pair Now()
        {
            Pair newColor = new Pair(0, 0);
            if (nextIndex == items.Length)
            {
                for (int i = startIndex; i < items.Length; i++)
                {
                    newColor = SumIntervalPairs(newColor, i);
                }
            }
            return newColor;
        }

        public Pair Sum()
        {
            Pair newColor = new Pair(0, 0);
            for (int i = 0; i < startIndex; i++)
            {
                newColor = SumIntervalPairs(newColor, i);
            }
            return newColor;
            //TODO: сумирайте двойките от 0 до this.Count – всички двойки, които имат право да участват в класирането

        }



        public void Add(Pair item)
        {
            if (nextIndex < items.Length)
            {
                items[nextIndex] = item;
                nextIndex++;
                if (nextIndex == items.Length)
                {
                    items[startIndex] = Now();
                    startIndex++;
                    for (int i = startIndex; i < items.Length; i++)
                    {
                        items[i] = null;
                    }
                    nextIndex = startIndex;
                }
            }

            //TODO: Добавяне на двойката         

        }



        public void PrintCurrentState()
        {

            //TODO: отпечатайте всички двойки от 0 до nextIndex

        }
    }
}
