using Newtonsoft.Json;

namespace PatternsExamples.Creational.Prototype
{
    public abstract class Clonable<T>
    {
        // Shallow copy
        // the reference value type variable shared a same memory location
        public T Clone()
        {
            return (T)MemberwiseClone();
        }

        // Deep Copy
        // create a new reference in new object
        public T DeepCopy()
        {
            string result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}