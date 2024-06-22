using System;
using System.Collections;

namespace lab1
{ 
	public class Class1
	{
        public Class1()
        {
            char[] gender = { 'm', 'f', 'f', 'm', 'm', 'm', 'f', 'm', 'f', 'f', 'm' };

            Hashtable genderCount = new Hashtable();

            foreach (char g in gender)
            {
                if (genderCount.ContainsKey(g))
                {
                    genderCount[g] = Convert.ToInt32(genderCount[g]) + 1;
                }
                else
                {
                    genderCount.Add(g, 1);
                }
            }

            foreach (DictionaryEntry entry in genderCount)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }
        }
	}
}