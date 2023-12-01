using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4Sem2
{
    [Orient(false)]
    public class Bitcoin
    {
        [DisplayAtr(false)] // FALSE
        public string Address { get; set; }


        public int Amount { get; set; }


        public bool IsOperationDone { get; set; }

        public Bitcoin(string address, int amount, bool isDone)
        {
            Address = address;
            Amount = amount;
            IsOperationDone = isDone;
        }
    }
    [Orient(true)]
    public class ThetherUS
    {
        

        public string Address { get; set; }


        public int Amount { get; set; }


        public string System {  get; set; }


        public bool IsOperationDone { get; set; }

        public ThetherUS(string address,string sys, int amount, bool isDone)
        {
            System = sys;
            Address = address;
            Amount = amount;
            IsOperationDone = isDone;
        }
    }
    public class DisplayAtrAttribute : Attribute // атрибут который отвечает за отображение свойства
    {
        public bool IsDisplay { get; set; }
        public DisplayAtrAttribute(bool isDisplay)
        {
            IsDisplay = isDisplay;
        }
    }
    public class OrientAttribute : Attribute //Принимает булл, если тру то вертикально если фолз то горизонтально
    {
        public bool IsVertically { get; set; }
        public OrientAttribute(bool isVertically)
        {
            IsVertically = isVertically;
        }
    }
 }
