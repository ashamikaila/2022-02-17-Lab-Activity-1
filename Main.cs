using System;

class Program {
  public static void Main (string[] args) {

int x = 30; 

    for (int i = 1; i <= x; i++) {
        string output = "";
        if (i % 3 == 0) output += "Foo";
        if (i % 5 == 0) output += "Bar";
      
        if (output == "") {
            output = i.ToString();
        } else {
            output = $"{i} - {output}";
        }

        Console.WriteLine(output);
    }
  }
}