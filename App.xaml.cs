using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Up05.Properties;

namespace Up05
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    { } 
        namespace SchoolApp
    {
        public class Service
        {
            public string Name { get; set; }
            public string Description { get; set; }

            public Service(string name, string description)
            {
                Name = name;
                Description = description;
            }

            public override string ToString()
            {
                return Name; // Для отображения в ListBox



            }
        }
    }
                }

