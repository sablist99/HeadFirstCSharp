using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Form1 : Form
    {
        Location CurrentLocation;

        Outside Garden;
        OutsideWithDoor BackYard;
        OutsideWithDoor FrontYard;

        Room DiningRoom;
        RoomWithDoor LivingRoom;
        RoomWithDoor Kitchen;

        public Form1()
        {
            InitializeComponent();

            CreateLocations();

            MoveToANewLocation(LivingRoom);
        }

        private void CreateLocations()
        {
            Garden = new Outside("Сад", false);
            BackYard = new OutsideWithDoor("Задний двор", true, "детчатая дверь");
            FrontYard = new OutsideWithDoor("Лужайка", false, "дубовая дверь с латунной ручкой");

            DiningRoom = new Room("Столовая", "хрустальная люстра");
            LivingRoom = new RoomWithDoor("Гостиная", "старинный ковер", "дубовая дверь с латунной ручкой");
            Kitchen = new RoomWithDoor("Кухня", "плита из нержавеющей стали", "сетчатая дверь");


            Garden.Exits = new Location[] { BackYard, FrontYard };
            BackYard.Exits = new Location[] { FrontYard, Garden };
            FrontYard.Exits = new Location[] { BackYard, Garden };

            DiningRoom.Exits = new Location[] { LivingRoom, Kitchen };
            LivingRoom.Exits = new Location[] { DiningRoom };
            Kitchen.Exits = new Location[] { DiningRoom };


            LivingRoom.DoorLocation = FrontYard;
            FrontYard.DoorLocation = LivingRoom;

            Kitchen.DoorLocation = BackYard;
            BackYard.DoorLocation = Kitchen;
        }

        private void MoveToANewLocation(Location newLocation)
        {
            CurrentLocation = newLocation;
            exits.Items.Clear();
            for (int i = 0; i < CurrentLocation.Exits.Length; i++)
            {
                exits.Items.Add(CurrentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;

            description.Text = CurrentLocation.Description;

            if (CurrentLocation is IHasExteriorDoor)
                goThroughTheDoor.Enabled = true;
            else
                goThroughTheDoor.Enabled = false;

        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(CurrentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            //считаем, что если на эту кнопку получилось нажать, то это гарантирует, что нисходящее приведение выполнится успешно
            IHasExteriorDoor hasDoor = CurrentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
