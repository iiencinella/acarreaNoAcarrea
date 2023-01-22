// Declare local variable
string? result = "";

Console.WriteLine("Ingrese dos números separados por un caracter de espacio:");
string? entryValues = Console.ReadLine();

string[] numbers = entryValues.Split(' ');

// Converting numbers to binary
List<string> resultNumbers = new List<string>();
foreach (string item in numbers)
{
  resultNumbers.Add(ConvertToBinary(int.Parse(item)));
  result = ""; // Cleaning for evade bugs
}

for (int position = 0; position < resultNumbers.Count; position++)
{
  string numberItem = "";
  numberItem = resultNumbers[position];
  string dumpy = "";
  for (int pos = 0; pos < (32 - numberItem.Length); dumpy += "0", pos++) ;

  resultNumbers[position] = dumpy + numberItem;
}

Console.WriteLine(ConvertToDecimal(SumMofiz(resultNumbers[0], resultNumbers[1])));

#region Functionalities for the problem
string ConvertToBinary(int number)
{
  if (number > 1)
  {
    int num = number / 2;
    ConvertToBinary(num);
  }
  result = result + (number % 2).ToString();
  return result;
}

string SumMofiz(string num1, string num2)
{
  result = "";
  for (int pos = 0; pos < 32; pos++)
  {
    result += (num1[pos] != num2[pos]) ? "1" : "0";
  }

  return result;
}

double ConvertToDecimal(string number)
{
  double numDecimal = 0;
  int pos = 0;
  int maxPos = number.Length - 1;

  foreach (char character in number)
  {
    numDecimal += int.Parse(character.ToString()) * Math.Pow(2, (maxPos - pos));
    pos++;
  }

  return numDecimal;
}
#endregion
