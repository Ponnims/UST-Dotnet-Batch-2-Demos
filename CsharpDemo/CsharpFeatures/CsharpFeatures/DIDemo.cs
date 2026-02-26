using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{

    interface ISwitch
    {
        public void SwitchOn();
        public void SwitchOff();
    }
    class ClassicSwitch : ISwitch
    {
        // injecting the dependency through constructor injection
        private readonly IElectronicEquipment electronicEquipment;

        public ClassicSwitch(IElectronicEquipment electronicEquipment)
        {
            this.electronicEquipment= electronicEquipment;

        }
        public void SwitchOn()
        {
            electronicEquipment.On();
        }
        public void SwitchOff()
        {
             electronicEquipment.Off();
        }
    }
    

    class ModernSwitch : ISwitch
    {
        // injecting the dependency through constructor injection
        private readonly IElectronicEquipment electronicEquipment;
        public ModernSwitch(IElectronicEquipment electronicEquipment)
        {
            this.electronicEquipment = electronicEquipment;
        }
        public void SwitchOn()
        {
            electronicEquipment.On();
        }
        public void SwitchOff()
        {
            electronicEquipment.Off();
        }
    }

    interface IElectronicEquipment
        {
        public void On();
        public void Off();
    }

    class Light :IElectronicEquipment
    {
        public void On()
        {
            Console.WriteLine("Light is on");
        }
        public void Off()
        {
            Console.WriteLine("Light is off");
        }
    }

    class Fan : IElectronicEquipment
    {
        public void On()
        {
            Console.WriteLine("Fan is on");
        }
        public void Off()
        {
            Console.WriteLine("Fan is off");
        }
    }

    internal class DIDemo
    {
            static void Main(string[] args)
            {
            IElectronicEquipment light = new Light();
            IElectronicEquipment fan = new Fan();
            ISwitch switchobj = new ModernSwitch(fan);
            ISwitch switchobj2 = new ClassicSwitch(light);
            switchobj.SwitchOn();
            switchobj.SwitchOff();
        }
        }
}
