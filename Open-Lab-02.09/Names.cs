using System;

namespace Open_Lab_02._09
{
    public class Names
    {
        public string ConcatName(string firstName, string lastName)
        {
            return string.Format("{0}, {1}", lastName, firstName);
        }
    }
}
