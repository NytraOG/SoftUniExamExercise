using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class Hardware
    {
        private string name;
        private string type;
        private int maximumCapacity;
        private int maximumMemory;
        private List<Software> listOfInstalledSoftware = new List<Software>();

        public string Name { get; set; }
        public string Type { get; set; }
        public int MaximumCapacity { get; set; }
        public int MaximumMemory { get; set; }
        public List<Software> ListOfInstalledSoftware { get; set; }
    }
}
