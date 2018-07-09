namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO
{
    public interface IPath
    {
        string Combine(string path1, string path2);
        string GetFileName(string path);
        string GetDirectoryName(string path);
    }
}