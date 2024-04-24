using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializeAndDeserialize
{
    [Serializable]
    public class Developer : ISerializable
    {
        private static int _id;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }   
        public double Salary { get; set; }
        public string DevelopmentSkills { get; set; }
        public int Experience { get; set; }

        public Developer()
        {
            _id++;
            Id = _id;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Surname} - {Age} - {Salary} - {DevelopmentSkills} - {Experience}";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id, typeof(Developer));
            info.AddValue("Name", Name, typeof(Developer));
            info.AddValue("Surname", Surname, typeof(Developer));
            info.AddValue("Age", Age, typeof(Developer));
            info.AddValue("Salary", Salary, typeof(Developer));
            info.AddValue("Development Skills", DevelopmentSkills, typeof(Developer));
            info.AddValue("Experience", Experience, typeof(Developer));

        }
    }
}
