
Console.WriteLine("Please Enter your name");
string name = Console.ReadLine();

Console.Write("Enter your age");
int age = int.Parse(Console.ReadLine()); // int.Parse converts the entered string into an integer. The resulting integer value is then stored in the variable age.

Console.WriteLine("Enter your height");
double height = double.Parse(Console.ReadLine());  // double.Parse() converts the entered string into a double (floating-point) value. The resulting double value is then stored in the variable height.

Console.WriteLine("Hello " + name + ", you are " + age + " years old, and your height is " + height + " cm");
