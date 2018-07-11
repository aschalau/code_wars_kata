function GetSum(a, b)
{
   var j = a, k = b, sum = 0;
   if(a > b) k = a, j = b;
   
   for(i = j; i <= k; i++) sum += i;
   
   return sum;
}
