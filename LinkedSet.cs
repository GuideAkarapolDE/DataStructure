using Collections;

namespace SET
{
    public class LinkedSet : LinkedHeaderCollection, Set
    {
        public LinkedSet() { }
        public new void add(object e)
        {
            if (!base.contains(e))
            {
                base.add(e);
            }
        }
    }
}
