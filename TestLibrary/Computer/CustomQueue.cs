using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Computer
{
    public class CustomQueue
    {
        private int[] _item { get; set; }
        public int Count = 0;

        public CustomQueue(int i)
        {
            _item = new int[i];
        }
        public CustomQueue()
        {
            _item = new int[10];
        }

        public void Enqueue(int i)
        {
            _item[Count] = i;
            Count++;
        }

        public void Dequeue()
        {
            for (int i = 1; i < Count; i++)
            {
                _item[i - 1] = _item[i];
            }
            _item[Count - 1] = 0;
            Count--;
        }

        public int[] GetItem()
        {
            int[] tmp = new int[Count];
            Array.Copy(_item, tmp, Count);
            return tmp;

        }


    }

    public class CustomQueueV2
    {
        private int[] _item = new int[1];
        public int Count = 0;

        public void Enqueue(int i)
        {
            _item[Count] = i;
            Count++;
            Array.Resize(ref _item, Count + 1);
        }

        public void Dequeue()
        {
            if (Count > 0)
            {
                for (int i = 1; i < Count; i++)
                {
                    _item[i - 1] = _item[i];
                }
                _item[Count - 1] = 0;
                Count--;
            }
        }

        public int[] GetItem()
        {
            int[] tmp = new int[Count];
            Array.Copy(_item, tmp, Count);
            return tmp;

        }
    }

    public class CustomQueueV3
    {
        public List<int> Items = new List<int>();

        public void Enqueue(int i)
        {
            Items.Add(i);
        }

        public void Dequeue()
        {
            Items.RemoveAt(Items.Count - 1);
        }


    }
}











