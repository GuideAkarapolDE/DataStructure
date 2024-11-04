namespace Collections
{
    public class ArrayCollection : Collection
    {
        private int SIZE;
        private int cap;
        private object[] data;

        public ArrayCollection(int cap)
        {
            data = new object[cap];
            this.cap = cap;
        }

        public void add(object e)
        {
            ensureCapacity();
            data [SIZE++] = e;
        }

        private void ensureCapacity()
        {
            if (SIZE+1 > data.Length)
            {
                object[] tempdata = new object[ 2 * SIZE];
                for (int i = 0; i < SIZE; i++)
                {
                    tempdata [i] = data [i];
                }
                data = tempdata;
            }
        }

        public bool contains(object e)
        {
            return Index(e) != -1;
        }

        private int Index(object e)
        {
            for (int i = 0; i < SIZE; i++)
                if (data[i].Equals(e))
                    return i;
            return -1;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public void remove(object e)
        {
            int i = Index(e);
            if (i < 0)
            {
                return;
            }
            data[i] = data[--SIZE];
            data[SIZE] = null;
        }

        public int size()
        {
            return SIZE;
        }
    }
}
    