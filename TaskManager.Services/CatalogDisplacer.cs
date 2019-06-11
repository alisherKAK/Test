using System.IO;

namespace TaskManager.Services
{
    public class CatalogDisplacer
    {
        public void DisplaceCatalog(string from, string to)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(from);

            string name = directoryInfo.Name;

            directoryInfo.MoveTo(to + directoryInfo.Name);
        }
    }
}
