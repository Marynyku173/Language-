Console.WriteLine("Enter your X coordinste: ");
int xCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Y coordinste: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

int Koords(int x, int y)
{
        if (xCoord == 0 || yCoord == 0 )
        {
        Console.WriteLine("Its impossible value for this task!");
            return ;
        }
        
        else     
        {
            int number_quater;
            if (x > 0 && y > 0)
                number_quater = 1;
            else if (x < 0 && y > 0)
                number_quater = 2;
            else if (x < 0 && y < 0)
                number_quater = 3;
            else 
                number_quater = 4;

        return number_quater;
        }
   
}


int quater = Koords(xCoord, yCoord );
Console.WriteLine(quater);
//if (xCoord == 0 || yCoord == 0 )
//{
//Console.WriteLine("Its impossible value for this task!");
//    return;
//}
//else     Koords(xCoord, yCoord ); 

