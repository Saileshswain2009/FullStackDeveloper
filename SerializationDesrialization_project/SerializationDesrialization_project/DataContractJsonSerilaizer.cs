using System;
using System.IO;

namespace SerializationDesrialization_project
{
    internal class DataContractJsonSerilaizer
    {
        private Type type;

        public DataContractJsonSerilaizer(Type type)
        {
            this.type = type;
        }

        internal void WriteObject(MemoryStream ms, Person per)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error");
            }
        }
    }
}