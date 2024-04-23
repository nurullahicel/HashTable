using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable
{
    public class MyHashTable
    {
        public string[] _hashTable;
        public MyHashTable()
        {
            _hashTable = new string[10];
        }
        private int _hash(int key)
        {
            return key % 5;
        }
        public void Set(int key, string value)
        {
            int hashedKey = _hash(key);
            if (_hashTable[hashedKey] != null)
            {
                Console.WriteLine("collision has occured");
            }
            else
            {
                _hashTable[hashedKey] = value;
            }
        }
        public string Get(int key)
        {
            int hashedKey= _hash(key);
            return _hashTable[hashedKey];
        }
    }
}
