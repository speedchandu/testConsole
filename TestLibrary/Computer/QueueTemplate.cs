using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Computer
{
    public class QueueTemplateV3<T>
    {
        public List<T> Item { get; set; }

        public QueueTemplateV3()
        {
            Item = new List<T>();
        }
        public void Enqueue(T i)
        {
            Item.Add(i);
        }

        public void Dequeue()
        {
            Item.RemoveAt(0);
        }
        
        public T GetValueAt0()
        {
            return Item[0];
        }

    }

    public class QueueTemplateV2<T>
    {
        private T[] _item = new T[1];
        public int Count = 0;

        public void Enqueue(T i)
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
                //_item[Count - 1] = 0;
                Count--;
            }
        }

        public T[] GetItem()
        {
            T[] tmp = new T[Count];
            Array.Copy(_item, tmp, Count);
            return tmp;

        }
    }
}
