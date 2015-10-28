using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MyRandom
{
  private Random r;
  private List<int> prev_numbers;
  private int counter = 0;
  public MyRandom()
  {
    r = new Random();
    prev_numbers = new List<int>();
  }

  public int Prev()
  {
    counter--;
    if (counter > 0)
      return prev_numbers[counter];
    else
      return 0;

  }

  public int Next(int from, int to) {
    counter++;
    if (counter < prev_numbers.Count)
      return prev_numbers[counter];
    else
    {
      var new_num = r.Next(from, to);
      prev_numbers.Add(new_num);
      return new_num;
    }
  }

}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                