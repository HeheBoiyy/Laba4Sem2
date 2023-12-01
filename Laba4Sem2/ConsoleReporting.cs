using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4Sem2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Reflection;

    public class ConsoleReporting
    {
        private IEnumerable<object> objects;

        public ConsoleReporting(IEnumerable<object> objects)
        {
            this.objects = objects;
        }

        public void Render()
        {
            foreach (var obj in objects)
            {
                var properties = obj.GetType().GetProperties();
                var orientatr = obj.GetType().GetCustomAttribute<OrientAttribute>();
                if (orientatr != null) // Проверка на наличие атрибута
                {
                    if (orientatr.IsVertically) // Вертикальная проверка
                    {
                        Console.WriteLine($"------------" + obj.GetType().Name + "------------");
                        foreach (var property in properties)
                        {
                            if (ShouldDisplayProperty(property))
                            {
                                var value = property.GetValue(obj);
                                Console.WriteLine($"{property.Name}: {value}");
                            }
                        }
                        Console.WriteLine("----------------------------");
                    }
                    else
                    {
                        Console.WriteLine($"------------" + obj.GetType().Name + "------------");
                        foreach (var property in properties)
                        {
                            if (ShouldDisplayProperty(property))
                            {
                                var value = property.GetValue(obj);
                                Console.Write($"{property.Name}: {value}  |  ");
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("----------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("АТРИБУТ ОРИЕНТАЦИИ ОТОБРАЖЕНИЯ ОТСУТСТВУЕТ!");
                }
                
            }
        }
        private bool ShouldDisplayProperty(PropertyInfo property)
        {
            var displayAttribute = property.GetCustomAttribute<DisplayAtrAttribute>();
            if (displayAttribute != null)
            {
                if (!displayAttribute.IsDisplay)
                {
                    return false; // Если у свойства есть атрибут Display и установлено свойство AutoGenerateField в false, то не отображаем свойство
                }
            }
            return true; 
        }
    }

}
