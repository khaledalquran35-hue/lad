//switch



/*
int graed = Convert.ToInt32(Console.ReadLine());
switch (graed) {
    case 0:
        Console.WriteLine($"Correct{graed}");
        break;



    case 1:
        Console.WriteLine($"Correct{graed}");
        break;

    case 2:
        Console.WriteLine($"Correct{graed}");
        break;



    default:
        Console.WriteLine("kkjkj");
        break;


}

*/



/*---------------------------------------*/



Console.WriteLine("enter numper 1:");
double num_1 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("enter numper 2:");
double num_2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("enter numper 1:");
char @operator = Convert.ToChar(Console.ReadLine());


int graed = Convert.ToInt32(Console.ReadLine());
switch (@operator)
{
    case '+' :
        Console.WriteLine($"the result of opartor {@operator} for {num_1}and {num_2}is :{num_1+num_2}");
        break;



    case '-':
        Console.WriteLine($"the result of opartor {@operator} for {num_1}and {num_2}is :{num_1 - num_2}");
        break;

    case '*':
        Console.WriteLine($"the result of opartor {@operator} for {num_1}and {num_2}is :{num_1 * num_2}");
        break;

    case '/':
        Console.WriteLine($"the result of opartor {@operator} for {num_1}and {num_2}is :{num_1 / num_2}");
        break;

    default:
        Console.WriteLine($"invalied oparetor ");
        break;


}