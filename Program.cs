string paroll="";
int urinish=2;
for (int ie=0; ie<=urinish;ie++)
{
      System.Console.Write("\nParolni kiriting : ");
      paroll=Console.ReadLine();
      if (paroll=="paroll")
      {
            System.Console.WriteLine("\nTizimga muvaffaqiyatli kirdingiz!");
            break;
      }
      else 
      {
            System.Console.WriteLine("\nParol xato!");
      }
}
if (paroll=="paroll")
{
      System.Console.Write("");
}
else 
{
      System.Console.WriteLine("\nSiz 3 marta muvaffaqiyatsiz urinish qildingiz!\n");
}

Console.Write("\nBirinchi sonni kiriting : ");
int bir=Convert.ToInt32(Console.ReadLine());
Console.Write("\nAmalni kiriting (+, -, *, /, %) : ");
string amal=Console.ReadLine();
Console.Write("\nIkkinchi sonni kiriting : ");
int ikki=Convert.ToInt32(Console.ReadLine());

string message=amal switch 
{
      "+" =>$"\nResult : {bir} + {ikki} = {bir+ikki}\n",
      "-"=>$"\nResult : {bir} - {ikki} = {bir-ikki}\n",
      "*"=>$"\nResult : {bir} * {ikki} = {bir*ikki}\n",
      "/"=>$"\nResult : {bir} / {ikki} = {bir/ikki}\n",
      "%"=>$"\nResult : {bir} % {ikki} = {bir%ikki}\n",
      _ =>"\nAmal xato kiritildi!"
};
System.Console.WriteLine(message);

