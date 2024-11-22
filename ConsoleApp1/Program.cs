// static void Hello32()
// {
//     for (int i = 0; i < 32 ; i++)
//     {
//         Console.WriteLine("Hello, World");
//     }
// }


// Hello32();

// Console.ReadLine();
// //______________________________________________________

// static void fun(int n)
// {
//     Console.WriteLine(n * n);
// }


// fun(2);

// Console.ReadLine();
// // _____________________________________________________

// static void Multi(float m , float n)
// {
//     Console.WriteLine(m * n);
// }

// Multi(2.2f,4.2f);

// Console.ReadLine();

// //______________________________________________________

// static float RightTriangleArea(float dog, float dog2)
// {
//     return dog * dog2;
// }

// float a = RightTriangleArea(1.1f , 2.2f);
// Console.WriteLine(a/2);
// Console.ReadLine();

// //______________________________________________________
// static float RightTriangleArea(float rad, float rad2)
// {
//     return rad * rad2;
// }

// float radrad2 = RightTriangleArea(1.1f , 1.1f);
// Console.WriteLine(radrad2*3.14);

// Console.ReadLine();
// //______________________________________________________

// static int GetNumberInput()
// {

//     bool trool = false;
//     int result = 0;

//     while (trool == false)
//     {
//         string read = Console.ReadLine();

//         trool = int.TryParse(read, out result);
//         if (trool == false)
//         {
//             Console.WriteLine("skirv igen");
//         }

//     }
//     return result;

// }


// GetNumberInput();
// //__________________________________________________________

// FEL FEL FEL FEL FEL FEL FEL FEL FEL FEL FEL FEL FEL FEL FEL FEL FEL 
//  static string getchoice(string sting1 ,string sting2,string sting3)
// {

//     return sting1 + sting2 + sting3;
// }

// getchoice("dog","dog2","dog3");
List<string> valja = ["","dog1","dog2","dog3","dog4"];

for (int i = 1; i < valja.Count ; i++)
{
    Console.WriteLine(valja[i]);
}
Console.WriteLine("välj en");

static int getchoice()
{
int result = 0;

string read = Console.ReadLine();

int.TryParse(read, out result);

return result;
}
int wow = getchoice();


Console.WriteLine(valja[wow]);
Console.ReadLine();