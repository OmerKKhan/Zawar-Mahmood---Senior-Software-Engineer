using System;

// Task # 1
// Given an integer x, return true if x is palindrome integer.
// An integer is a palindrome when it reads the same backward as forward.
// For example, 121 is a palindrome while 123 is not.
// Example 1:
// Input: x = 121
// Output: true
// Explanation: 121 reads as 121 from left to right and from right to left.
// Example 2:
// Input: x = -121
// Output: false
// Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
// Example 3:

// Input: x = 10
// Output: false
// Explanation: Reads 01 from right to left. Therefore it is not a palindrome.


class Task1 {
  public static void Main (string[] args) {
    int palindrome = 21212;
   
    int length = GetLength(palindrome);
   var result = Match(palindrome, length);
    
    Console.WriteLine(length);
    Console.ReadLine();
    // separate 1st and last digit
  }

  public static int GetLength(int number)
  {
    int i = 1;
    while(number > 10)
    {
      number/= 10; //2112,
      i++; //1,2,3,4
    }
    return i;
  }


  public static bool Match1(int palindrome)
  {
    var result = 0;
    var length = GetLength(palindrome); //
    //2121 // 1 * length , result + 
    for(int i = 1; i < length; i++) //1000
    { //2121 / 1000
      //1 *length 
      //2121/100
      //21
      // 
               //  21212 % 10  = 2
               //  var remaider = 21212/10; = 2121
               //  2 * 10 ^ length = 20000
               //  result += 20000;
               //  remainder % 10 = 2121 % 10 = 1
               //  1 * 10 ^ length - 1
               //  212
               
      
      
      result += ( (int)(palindrome % Math.Pow(10, i)) ) * length;
    }
    return result == palindrome;
  }
  
  
  public static bool Match(int palindrome, int length)
  {
    var lastDigit = palindrome/10; // 21212/10000 = 2121 
    var firstDigit = palindrome/ Math.Pow(10, length);   // max digit length
    if(firstDigit != lastDigit)
    {
      return false;
    }
    else
    {
      var newPalindrome = palindrome/
      return  Match( palindrome ,  ); // ignore last and 1st value );
    }
    
  }
}

//Task 2
// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// You can return the answer in any order.

// Example 1:

     


// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
// Example 2:

// Input: nums = [3,2,4], target = 6
// Output: [1,2]
// Example 3:

// Input: nums = [3,3], target = 6
// Output: [0,1]

class Task2 {
  public static void Main (string[] args) {
    
    
    // separate 1st and last digit
  }
}