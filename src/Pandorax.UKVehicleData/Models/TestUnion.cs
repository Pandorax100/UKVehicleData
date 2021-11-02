namespace Pandorax.UKVehicleData.Models
{
    public partial struct TestUnion
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public string String;
        public UKVehicleDataResponse TestClass;

        public static implicit operator TestUnion(object[] AnythingArray) => new TestUnion { AnythingArray = AnythingArray };
        public static implicit operator TestUnion(bool Bool) => new TestUnion { Bool = Bool };
        public static implicit operator TestUnion(double Double) => new TestUnion { Double = Double };
        public static implicit operator TestUnion(long Integer) => new TestUnion { Integer = Integer };
        public static implicit operator TestUnion(string String) => new TestUnion { String = String };
        public static implicit operator TestUnion(UKVehicleDataResponse TestClass) => new TestUnion { TestClass = TestClass };
        public bool IsNull => AnythingArray == null && Bool == null && TestClass == null && Double == null && Integer == null && String == null;
    }
}
