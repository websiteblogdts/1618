using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWLab5StoreBoxes
{
    public class BoxList
    {
        private List<Box> ListOfBoxes = new List<Box>();
        public void EnterInfor()
        {
            Console.WriteLine("Enter information of box{Serial Number} {Item Name} {Item Quantity} {itemPrice}: ");
            string[] box = Console.ReadLine().Split();

            Box tmp = new Box();

            tmp.SerialNumber = int.Parse(box[0]);
            tmp.Item.Name = box[1];
            tmp.ItemQuantity = int.Parse(box[2]);
            tmp.Item.Price = double.Parse(box[3]);
            tmp.PriceBox = tmp.Item.Price * tmp.ItemQuantity;

            ListOfBoxes.Add(tmp);
        }
        public void SoftList()
        {

        }
        public void DisplayInfor()
        {
            foreach (Box box in ListOfBoxes)
            {
                Console.WriteLine($"{box.SerialNumber} -- {box.Item.Name} - ${box.Item.Price:F1}: {box.ItemQuantity} -- ${box.PriceBox:F2}");
            }
        }
    }
}
