namespace org.ek.HandMeAFile.commons.Tools
{
    public interface ICreateRandomValues
    {
        int Next();
        int Next(int maxValue);
        int Next(int minValue, int maxValue);
        double NextDouble();
        void NextBytes(byte[] buffer);
        uint NextUint(uint minValue, uint maxValue);
        ulong NextULong(ulong minValue, ulong maxValue);
    }
}