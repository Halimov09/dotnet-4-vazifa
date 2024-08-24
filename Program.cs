// check number 1
Console.Write("enter number ");
uint checkNumber = uint.Parse(Console.ReadLine());
if ( !(checkNumber % 2 == 0 || checkNumber % 3 == 0 || checkNumber % 5 == 0 || checkNumber == 3 || checkNumber == 5 || checkNumber == 7))
{   if (checkNumber == 1)
    {
         Console.WriteLine($"bu {checkNumber} son tub ham murakkab ham emas");
    }else{
    Console.WriteLine($"bu {checkNumber} tub son");
    }
}else{
    if (checkNumber == 3 || checkNumber == 5 || checkNumber == 7 || checkNumber == 2)
    {
        Console.WriteLine($"bu {checkNumber} tub son");  
    }else{
        Console.WriteLine($"bu {checkNumber} murakkab son");
    }
}


// proccec number 2
Console.Write("enter number ");
int proccecNumber = int.Parse(Console.ReadLine());

int inc = 2;
string safe = "boluvchilari: ";


for (int i = 0; i <= proccecNumber; i++){
    if (proccecNumber % inc == 0)
    {

        safe += inc.ToString();
        safe += ", ";
        inc++;
    }else{
        inc++;
    }
}

Console.WriteLine(safe);




// daraja raqami 3
Console.Write("enter number ");
int enterNumber = int.Parse(Console.ReadLine());
Console.Write("daraja raqami ");
int addNumber = int.Parse(Console.ReadLine());

int equalNumber = 1;

for (int i = 0; i < addNumber; i++)
{
    equalNumber = equalNumber * enterNumber;
}
Console.WriteLine(equalNumber);








// total price 4
Console.Write("Harajatlar to'plamlarini kiriting (vergul bilan ajrating): ");
string input = Console.ReadLine();

string[] amounts = input.Split(',');

int total = 0;
foreach (string item in amounts)
{
    if (int.TryParse(item.Trim(), out int value))
    {
        total += value;
    }
    else
    {
        Console.WriteLine($"Xato: {item} son emas.");
        return;
    }
}

Console.WriteLine($"Yig'indi: {total}");





// armstrong son 5
Console.Write("son kiriting: ");
int armNumber = int.Parse(Console.ReadLine());
string armNumberStr = armNumber.ToString();
string add = "";

for (int i = 0; i < armNumberStr.Length; i++)
{
   add += armNumberStr[i]; 
   add += ",";  

}

string[] numberMassiv = add.TrimEnd(',').Split(',');

int natija = 0;
int lastNumber = int.Parse(numberMassiv[numberMassiv.Length - 1]);
for (int i = 0; i < numberMassiv.Length; i++)
{
    int number = int.Parse(numberMassiv[i]);
    natija += (int)Math.Pow(number, lastNumber); 
}

if (armNumber == natija)
{
    Console.WriteLine($"bu son {armNumber} armstrong son");
}else{
    Console.WriteLine($"bu son {armNumber} armstrong son emas");
}


// how much number 6
Console.Write("enter number ");
uint plusNumber = uint.Parse(Console.ReadLine());

int equalNumbers = 0;

for (int i = 1; i < plusNumber; i++)
{
    if (plusNumber % i == 0)
    {
        equalNumbers++;
    }
}

Console.WriteLine($"boluvchilari soni {equalNumbers - 1} ta");