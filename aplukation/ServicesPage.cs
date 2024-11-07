using System;

namespace PapkaMain
{
    internal class ServicesPage
    {
        public ServicesPage()
        {
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public class Service
        {
            public string Name { get; set; }
            public string Description { get; set; }

            public Service(string name, string description)
            {
                Name = name;
                Description = description;
            }
        }
    }
}
