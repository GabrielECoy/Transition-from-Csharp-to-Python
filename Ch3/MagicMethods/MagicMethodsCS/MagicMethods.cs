using System;

namespace MagicMethodsCS
{
    class MagicMethods
    {
        public string _name;
        public int _size;

        public MagicMethods(string name, int size)
        {
            _name = name;
            _size = size;
        }

        public override string ToString()
        {
            string str = base.ToString();
            return "My class name is: " + str;
        }

        public override bool Equals(object obj)
        {
            MagicMethods tempobj = obj as MagicMethods;
            if (tempobj == null)
                return false;
            return (_name.Equals(tempobj._name) &&
                    _size == tempobj._size);
        }
    }
}
