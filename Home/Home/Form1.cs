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
        int Moves;

        Location CurrentLocation;

        OutsideWithHidingPlace Garden;
        OutsideWithHidingPlace Driveway;
        OutsideWithDoor BackYard;
        OutsideWithDoor FrontYard;

        RoomWithHidingPlace DiningRoom;
        RoomWithDoor LivingRoom;
        RoomWithDoor Kitchen;
        Room Stairs;
        RoomWithHidingPlace Hallway;
        RoomWithHidingPlace Bathroom;
        RoomWithHidingPlace MasterBedroom;
        RoomWithHidingPlace SecondBedroom;

        Opponent opponent;


        public Form1()
        {
            InitializeComponent();

            CreateLocations();
            opponent = new Opponent(FrontYard);
            ResetGame(false);
        }

        private void CreateLocations()
        {
            Garden = new OutsideWithHidingPlace("Сад", false, "в сарае");
            BackYard = new OutsideWithDoor("Задний двор", true, "детчатая дверь");
            FrontYard = new OutsideWithDoor("Лужайка", false, "дубовая дверь с латунной ручкой");
            Driveway = new OutsideWithHidingPlace("Подъезд", true, "в гараже");

            DiningRoom = new RoomWithHidingPlace("Столовая", "хрустальная люстра", "в высоком шкафу");
            LivingRoom = new RoomWithDoor("Гостиная", "старинный ковер", "дубовая дверь с латунной ручкой", "в гардеробе");
            Kitchen = new RoomWithDoor("Кухня", "плита из нержавеющей стали", "сетчатая дверь", "в сундуке");
            Stairs = new Room("Лестница", "деревянные перила");
            Hallway = new RoomWithHidingPlace("Верхний коридор", "картина с собакой", "в гардеробе");
            Bathroom = new RoomWithHidingPlace("Ванная", "раковина и туалет", "в душе");
            MasterBedroom = new RoomWithHidingPlace("Главная спальня", "большая кровать", "под кроватью");
            SecondBedroom = new RoomWithHidingPlace("Вторая спальня", "маленькая кровать", "под кроватью");


            Garden.Exits = new Location[] { BackYard, FrontYard };
            BackYard.Exits = new Location[] { FrontYard, Garden, Driveway };
            FrontYard.Exits = new Location[] { BackYard, Garden, Driveway };
            Driveway.Exits = new Location[] { BackYard, FrontYard };

            DiningRoom.Exits = new Location[] { LivingRoom, Kitchen };
            LivingRoom.Exits = new Location[] { DiningRoom, Stairs };
            Kitchen.Exits = new Location[] { DiningRoom };
            Stairs.Exits = new Location[] { LivingRoom, Hallway };
            Hallway.Exits = new Location[] { Stairs, Bathroom, MasterBedroom, SecondBedroom };
            Bathroom.Exits = new Location[] { Hallway };
            MasterBedroom.Exits = new Location[] { Hallway };
            SecondBedroom.Exits = new Location[] { Hallway };
            
            LivingRoom.DoorLocation = FrontYard;
            FrontYard.DoorLocation = LivingRoom;

            Kitchen.DoorLocation = BackYard;
            BackYard.DoorLocation = Kitchen;
        }

        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            CurrentLocation = newLocation;
            RedrawForm();
        }

        private void RedrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < CurrentLocation.Exits.Length; i++)
            {
                exits.Items.Add(CurrentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;
            description.Text = CurrentLocation.Description + "\r\n(перемещение №" + Moves + ")";

            if (CurrentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = CurrentLocation as IHidingPlace;
                check.Text = "Check " + hidingPlace.HidingPlace;
                check.Visible = true;
            }
            else
                check.Visible = false;

            if (CurrentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
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

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;
            for (int i = 1; i < 11; i++)
            {
                opponent.Move();
                description.Text += i + "...\n";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }

            description.Text = "Я иду искать!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(LivingRoom);
        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("Меня нашли за " + Moves + " ходов!");
                IHidingPlace foundLocation = CurrentLocation as IHidingPlace;
                description.Text = "Соперник найден за " + Moves + " ходов! Он прятался " + foundLocation.HidingPlace + ".";
            }

            Moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughTheDoor.Visible = false;
            exits.Visible = false;
        }

        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(CurrentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }
    }
}
