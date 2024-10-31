// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

House house = new House();
Console.WriteLine(house.ToString());

Console.ReadLine();


class House
{
    int NumRooms = 3;
    bool hasKitchen = true;
    bool hasBuiltinKitchen = false;

    public override string ToString()
    {
        string KitchenOut = "";
        if (hasKitchen)
        {
            KitchenOut = " with kitchen ";

            if (hasBuiltinKitchen)
            {
                KitchenOut += " attached to dining room";
            }
        }

        return "NumRooms: " + NumRooms + KitchenOut;
    }
}


